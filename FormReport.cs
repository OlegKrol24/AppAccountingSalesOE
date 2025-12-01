using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Utils;
using FastReport.Data;
using FastReport.Design;
using FastReport.Design.StandardDesigner;
using System.IO;

namespace AppAccountingSalesOE
{
    public partial class formReport : Form
    {
        private User currentUser;

        public formReport(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser != null)
            {
                if (currentUser.Role.Contains("менеджер"))
                {
                    rbSupplies.Enabled = false;
                    tsmiSupplies.Enabled = false;
                }
            }

            rbGoods.CheckedChanged += RadioButton_CheckedChanged;
            rbCustomers.CheckedChanged += RadioButton_CheckedChanged;
            rbSales.CheckedChanged += RadioButton_CheckedChanged;
            rbSupplies.CheckedChanged += RadioButton_CheckedChanged;
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<Goods> goods_list = new List<Goods>();
        List<clSales> sales_list = new List<clSales>();
        List<clSalesDetails> sales_details_list = new List<clSalesDetails>();
        List<clCustomers> customers_list = new List<clCustomers>();
        List<Employees> employees_list = new List<Employees>();
        List<Supplies> supplies_list = new List<Supplies>();
        List<Supplies_details> supplies_details_list = new List<Supplies_details>();
        List<Suppliers> suppliers_list = new List<Suppliers>();
        List<Stock> stock_list = new List<Stock>();

        void LoadData()
        {
            goods_list.Clear();
            sales_list.Clear();
            sales_details_list.Clear();
            customers_list.Clear();
            employees_list.Clear();
            supplies_list.Clear();
            supplies_details_list.Clear();
            suppliers_list.Clear();
            stock_list.Clear();

            try { db.Execute<Goods>(file_db, "select id_goods, name_goods, category, manufacturing_country, price, warranty_months, description, image from goods", ref goods_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<clSales>(file_db, "select id_sale, sale_date, id_customer, id_employee, total_amount from sales", ref sales_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<clSalesDetails>(file_db, "select id_sale_details, id_sale, id_goods, quantity, unit_price from sales_details", ref sales_details_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<clCustomers>(file_db, "select id_customer, full_name, phone_number, email, address from customers", ref customers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Employees>(file_db, "select id_employee, full_name, position, phone_number, email, address, sex from employees", ref employees_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Supplies>(file_db, "select id_supply, id_supplier, delivery_date, total_cost from supplies", ref supplies_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Supplies_details>(file_db, "select id_supply_details, id_supply, id_goods, quantity, unit_cost from supplies_details", ref supplies_details_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Suppliers>(file_db, "select id_supplier, full_name, company_name, phone_number, email from suppliers", ref suppliers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Stock>(file_db, "select id_stock, id_goods, quantity from stock", ref stock_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            List<SalesReportDTO> salesReport = new List<SalesReportDTO>();

            foreach (var sale in sales_list)
            {
                string customerName = customers_list.FirstOrDefault(c => c.ID == sale.ID_Customer)?.Full_name ?? "Невідомий";
                string employeeName = employees_list.FirstOrDefault(emp => emp.ID == sale.ID_Employee)?.Full_name ?? "Невідомий";

                var saleDetails = sales_details_list.Where(sd => sd.ID_Sale == sale.ID).Select(sd => new SalesDetailReportDTO
                {
                    ID = sd.ID,
                    GoodsName = goods_list.FirstOrDefault(g => g.ID == sd.ID_Goods)?.Name ?? "Невідомий товар",
                    Quantity = sd.Quantity,
                    UnitPrice = sd.UnitPrice
                }).ToList();

                string goodsListString = string.Join(",\n", saleDetails.Select(x => $"{x.GoodsName} ({x.Quantity} шт.)"));

                salesReport.Add(new SalesReportDTO
                {
                    ID = sale.ID,
                    SaleDate = sale.SaleDate,
                    CustomerFullName = customerName,
                    EmployeeFullName = employeeName,
                    TotalAmount = sale.TotalAmount,
                    Details = saleDetails,
                    GoodsSummary = goodsListString
                });
            }

            List<SuppliesReportDTO> suppliesReport = new List<SuppliesReportDTO>();

            foreach (var supply in supplies_list)
            {
                string supplierFullName = suppliers_list.FirstOrDefault(sp => sp.ID == supply.ID_Supplier)?.Full_name ?? "Невідомий";
                string companyName = suppliers_list.FirstOrDefault(sp => sp.ID == supply.ID_Supplier)?.Company_name ?? "Невідома";

                var supplyDetails = supplies_details_list.Where(sd => sd.ID_supply == supply.ID).Select(sd => new SuppliesDetailReportDTO
                {
                    ID = sd.ID,
                    ID_Supply = sd.ID_supply,
                    GoodsName = goods_list.FirstOrDefault(g => g.ID == sd.ID_goods)?.Name ?? "Невідомий товар",
                    Quantity = sd.Quantity,
                    UnitCost = sd.Unit_cost
                }).ToList();

                suppliesReport.Add(new SuppliesReportDTO
                {
                    ID = supply.ID,
                    ID_Supplier = supply.ID_Supplier,
                    DeliveryDate = supply.DeliveryDate,
                    TotalCost = supply.TotalCost,
                    SupplierFullName = supplierFullName,
                    CompanyName = companyName,
                    Details = supplyDetails
                });
            }

            ClassSerialize.SerializeToXml(ref goods_list, "goods.xml");
            ClassSerialize.SerializeToXml(ref customers_list, "customers.xml");
            ClassSerialize.SerializeToXml(ref salesReport, "sales.xml");
            ClassSerialize.SerializeToXml(ref suppliesReport, "supplies.xml");
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked) UpdateDataGridViews();
        }

        private void UpdateReport()
        {
            Report report = new Report();

            string reportFile = "";
            string xmlFile = "";

            if (rbGoods.Checked)
            {
                reportFile = "Reports\\GoodsReport.frx";
                xmlFile = "goods.xml";
            }

            else if (rbCustomers.Checked)
            {
                reportFile = "Reports\\CustomersReport.frx";
                xmlFile = "customers.xml";
            }

            else if (rbSales.Checked)
            {
                reportFile = "Reports\\SalesReport.frx";
                xmlFile = "sales.xml";
            }

            else if (rbSupplies.Checked)
            {
                reportFile = "Reports\\SuppliesReport.frx";
                xmlFile = "supplies.xml";
            }

            if (!string.IsNullOrEmpty(reportFile))
            {
                report.Load(reportFile);
                report.Prepare();
                report.Preview = pc;
                report.Show();
            }
        }

        private void UpdateDataGridViews()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DateTime? fromDate = mcReportDate.SelectionStart != mcReportDate.MinDate ? mcReportDate.SelectionRange.Start.Date : (DateTime?)null;
            DateTime? toDate = mcReportDate.SelectionStart != mcReportDate.MinDate ? mcReportDate.SelectionRange.End.Date : (DateTime?)null;

            if (rbGoods.Checked)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Name", "Назва");
                dataGridView1.Columns.Add("Category", "Категорія");
                dataGridView1.Columns.Add("Country", "Країна");
                dataGridView1.Columns.Add("Price", "Ціна");
                dataGridView1.Columns.Add("Warranty", "Гарантія (міс.)");
                dataGridView1.Columns.Add("Description", "Опис");

                foreach (var g in goods_list)
                {
                    dataGridView1.Rows.Add(g.Name, g.Category, g.ManufacturingCountry, g.Price, g.WarrantyMonths, g.Description);
                }

                decimal totalPrice = goods_list.Sum(g => g.Price);
                int count = goods_list.Count;
                decimal avgPrice = count > 0 ? totalPrice / count : 0;

                dataGridView1.Rows.Add("");
                dataGridView1.Rows.Add("Загальна сума цін", totalPrice.ToString("N2"));
                dataGridView1.Rows.Add("Кількість товарів", count);
                dataGridView1.Rows.Add("Середня ціна", avgPrice.ToString("N2"));
            }

            else if (rbCustomers.Checked)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("FullName", "ПІБ");
                dataGridView1.Columns.Add("Phone", "Телефон");
                dataGridView1.Columns.Add("Email", "Email");
                dataGridView1.Columns.Add("Address", "Адреса");
                dataGridView1.Columns.Add("TotalSales", "Загальна сума покупок");

                var customerSales = customers_list.Select(c => new
                {
                    Customer = c,
                    SalesSum = sales_list.Where(s => s.ID_Customer == c.ID &&
                        (!fromDate.HasValue || s.SaleDate.Date >= fromDate.Value) &&
                        (!toDate.HasValue || s.SaleDate.Date <= toDate.Value))
                        .Sum(s => s.TotalAmount)
                }).ToList();

                foreach (var cs in customerSales)
                {
                    dataGridView1.Rows.Add(cs.Customer.Full_name, cs.Customer.Phone_number, cs.Customer.Email, cs.Customer.Address, cs.SalesSum.ToString("N2"));
                }

                decimal totalCustomerSales = customerSales.Sum(cs => cs.SalesSum);
                int customerCount = customerSales.Count(cs => cs.SalesSum > 0);
                decimal avgCustomerSales = customerCount > 0 ? totalCustomerSales / customerCount : 0;

                dataGridView1.Rows.Add("");
                dataGridView1.Rows.Add("Загальна сума покупок клієнтів", totalCustomerSales.ToString("N2"));
                dataGridView1.Rows.Add("Кількість активних клієнтів", customerCount);
                dataGridView1.Rows.Add("Середня сума на клієнта", avgCustomerSales.ToString("N2"));
            }

            else if (rbSales.Checked)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("SaleDate", "Дата продажу");
                dataGridView1.Columns.Add("Customer", "Клієнт");
                dataGridView1.Columns.Add("Employee", "Працівник");
                dataGridView1.Columns.Add("TotalAmount", "Сума");

                var filteredSales = sales_list.Where(s =>
                    (!fromDate.HasValue || s.SaleDate.Date >= fromDate.Value) &&
                    (!toDate.HasValue || s.SaleDate.Date <= toDate.Value)
                ).ToList();

                foreach (var s in filteredSales)
                {
                    var customer = customers_list.FirstOrDefault(c => c.ID == s.ID_Customer);
                    var employee = employees_list.FirstOrDefault(emp => emp.ID == s.ID_Employee);
                    
                    if (customer != null && employee != null)
                    {
                        dataGridView1.Rows.Add(s.SaleDate.ToString("dd.MM.yyyy"), customer.Full_name, employee.Full_name, s.TotalAmount.ToString("N2"));
                    }
                }

                decimal totalSales = filteredSales.Sum(s => s.TotalAmount);
                int salesCount = filteredSales.Count;
                decimal avgSale = salesCount > 0 ? totalSales / salesCount : 0;

                dataGridView1.Rows.Add("");
                dataGridView1.Rows.Add("Загальна сума продажів", totalSales.ToString("N2"));
                dataGridView1.Rows.Add("Кількість продажів", salesCount);
                dataGridView1.Rows.Add("Середня сума продажу", avgSale.ToString("N2"));
            }

            else if (rbSupplies.Checked)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("DeliveryDate", "Дата поставки");
                dataGridView1.Columns.Add("Supplier", "Постачальник");
                dataGridView1.Columns.Add("Company", "Компанія");
                dataGridView1.Columns.Add("TotalCost", "Сума");

                var filteredSupplies = supplies_list.Where(s =>
                    (!fromDate.HasValue || s.DeliveryDate.Date >= fromDate.Value) &&
                    (!toDate.HasValue || s.DeliveryDate.Date <= toDate.Value)
                ).ToList();

                foreach (var s in filteredSupplies)
                {
                    var supplier = suppliers_list.FirstOrDefault(sp => sp.ID == s.ID_Supplier);
                    
                    if (supplier != null)
                    {
                        dataGridView1.Rows.Add(s.DeliveryDate.ToString("dd.MM.yyyy"), supplier.Full_name, supplier.Company_name, s.TotalCost.ToString("N2"));
                    }
                }

                decimal totalSupplies = filteredSupplies.Sum(s => s.TotalCost);
                int suppliesCount = filteredSupplies.Count;
                decimal avgSupply = suppliesCount > 0 ? totalSupplies / suppliesCount : 0;

                dataGridView1.Rows.Add("");
                dataGridView1.Rows.Add("Загальна сума поставок", totalSupplies.ToString("N2"));
                dataGridView1.Rows.Add("Кількість поставок", suppliesCount);
                dataGridView1.Rows.Add("Середня сума поставки", avgSupply.ToString("N2"));
            }

            UpdateReport();
        }

        FastReport.Preview.PreviewControl pc = new FastReport.Preview.PreviewControl();

        private void FormReport_Load(object sender, EventArgs e)
        {
            LoadData();

            mcReportDate.SelectionStart = mcReportDate.MinDate;
            mcReportDate.SelectionEnd = mcReportDate.MinDate;

            UpdateDataGridViews();

            pc.Size = new Size(dataGridView2.Size.Width, dataGridView2.Size.Height);

            dataGridView2.Controls.Add(pc);

            UpdateCartLabels();
        }

        private void formReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbMainMenu_Click(object sender, EventArgs e)
        {
            if (msMainMenu.Visible == false) msMainMenu.Visible = true;
            else msMainMenu.Visible = false;
        }

        private void tsmiMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMainPage mainPage = new formMainPage(currentUser);
            mainPage.Show();
        }

        private void tsmiGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGoods formGoods = new formGoods(currentUser);
            formGoods.Show();
        }

        private void tsmiCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCustomers formCustomers = new formCustomers(currentUser);
            formCustomers.Show();
        }

        private void tsmiSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSales formSales = new formSales(currentUser);
            formSales.Show();
        }

        private void tsmiSupplies_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDeliveries formDeliveries = new formDeliveries(currentUser);
            formDeliveries.Show();
        }

        private void UpdateCartLabels()
        {
            int totalQuantity = Cart.GoodsInCart.Sum(item => item.Quantity);
            decimal totalPrice = Cart.GoodsInCart.Sum(item => item.Goods.Price * item.Quantity);

            lbQuantityCart.Text = $"{totalQuantity} шт";
            lbTotalAmountCart.Text = $"{totalPrice:F2} грн";
        }

        private void btnReportExcel_Click(object sender, EventArgs e)
        {
            string excelFilePath = Path.Combine(Environment.CurrentDirectory, "Report.xlsx");
            
            using (RepExcel repExcel = new RepExcel())
            {
                try
                {
                    repExcel.CreateNewBook(excelFilePath);
                    repExcel.OpenBook(excelFilePath);

                    repExcel.SetValue("Sheet1", "A1", "Дані", "string", true);
                    
                    for (int col = 0; col < dataGridView2.Columns.Count; col++)
                    {
                        repExcel.SetValue("Sheet1", $"{(char)('A' + col)}2", dataGridView2.Columns[col].HeaderText, "string", true);
                    }

                    for (int row = 0; row < dataGridView2.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView2.Columns.Count; col++)
                        {
                            repExcel.SetValue("Sheet1", $"{(char)('A' + col)}{row + 3}", dataGridView2.Rows[row].Cells[col].Value?.ToString(), "string");
                        }
                    }
                    
                    repExcel.SetValue("Sheet1", "A" + (dataGridView2.Rows.Count + 4), "Звіт", "string", true);
                    
                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {
                        repExcel.SetValue("Sheet1", "A" + (dataGridView2.Rows.Count + row + 5), dataGridView1.Rows[row].Cells[0].Value?.ToString(), "string");
                        repExcel.SetValue("Sheet1", "B" + (dataGridView2.Rows.Count + row + 5), dataGridView1.Rows[row].Cells[1].Value?.ToString(), "string");
                    }

                    repExcel.AutoFitColumns("Sheet1");
                    repExcel.Save(excelFilePath);
                    repExcel.CloseBook();
                    
                    MessageBox.Show($"Звіт створено: {excelFilePath}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при створенні звіту: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReportWord_Click(object sender, EventArgs e)
        {
            string wordFilePath = Path.Combine(Environment.CurrentDirectory, "Report.docx");
            
            using (RepWord repWord = new RepWord())
            {
                try
                {
                    repWord.CreateNewDocument(wordFilePath);
                    repWord.InsertText("Звіт", true, "center");

                    List<List<string>> tableData = new List<List<string>>();
                    List<string> headers2 = new List<string>();
                    
                    for (int i = 0; i < dataGridView2.Columns.Count; i++) headers2.Add(dataGridView2.Columns[i].HeaderText);
                    
                    tableData.Add(headers2);
                    
                    for (int row = 0; row < dataGridView2.Rows.Count; row++)
                    {
                        List<string> rowData = new List<string>();
                        for (int col = 0; col < dataGridView2.Columns.Count; col++) rowData.Add(dataGridView2.Rows[row].Cells[col].Value?.ToString());
                        tableData.Add(rowData);
                    }

                    repWord.InsertTable(tableData);
                    repWord.InsertText("\nЗвітні метрики:", true, "left");

                    List<List<string>> reportTable = new List<List<string>>();
                    
                    List<string> headers1 = new List<string> { "Метрика", "Значення" };
                    
                    reportTable.Add(headers1);
                    for (int row = 0; row < dataGridView1.Rows.Count; row++)
                    {
                        reportTable.Add(new List<string> { dataGridView1.Rows[row].Cells[0].Value?.ToString(), dataGridView1.Rows[row].Cells[1].Value?.ToString() });
                    }

                    repWord.InsertTable(reportTable);
                    repWord.Save(wordFilePath);
                    repWord.ExportToPdf(wordFilePath.Replace(".docx", ".pdf"));
                    repWord.CloseDocument();
                    
                    MessageBox.Show($"Документ створено: {wordFilePath}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при створенні документа: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCart formCart = new formCart(currentUser);
            formCart.Show();
        }
    }
}