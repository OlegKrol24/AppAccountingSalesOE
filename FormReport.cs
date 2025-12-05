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
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked) UpdateDataGridViews();
        }

        private void PrepareReportData(DateTime? fromDate, DateTime? toDate)
        {
            ClassSerialize.SerializeToXml(ref goods_list, "goods.xml");

            var filteredSales = sales_list.Where(s =>
                (!fromDate.HasValue || s.SaleDate.Date >= fromDate.Value) &&
                (!toDate.HasValue || s.SaleDate.Date <= toDate.Value)
            ).OrderBy(s => s.SaleDate).ToList();

            List<SalesReportDTO> salesReport = new List<SalesReportDTO>();

            foreach (var sale in filteredSales)
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
                    GoodsSummary = goodsListString,
                    FromDate = fromDate ?? DateTime.MinValue,
                    ToDate = toDate ?? DateTime.MaxValue
                });
            }

            ClassSerialize.SerializeToXml(ref salesReport, "sales.xml");

            DateTime actualFromDate = fromDate ?? DateTime.MinValue;
            DateTime actualToDate = toDate ?? DateTime.MaxValue;

            var filteredSupplies = supplies_list.Where(s =>
                (!fromDate.HasValue || s.DeliveryDate.Date >= fromDate.Value) &&
                (!toDate.HasValue || s.DeliveryDate.Date <= toDate.Value)
            ).OrderBy(s => s.DeliveryDate).ToList();

            List<SuppliesReportDTO> suppliesReport = new List<SuppliesReportDTO>();

            foreach (var supply in filteredSupplies)
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

                string goodsListString = string.Join(",\n", supplyDetails.Select(x => $"{x.GoodsName} ({x.Quantity} шт.)"));

                suppliesReport.Add(new SuppliesReportDTO
                {
                    ID = supply.ID,
                    ID_Supplier = supply.ID_Supplier,
                    DeliveryDate = supply.DeliveryDate,
                    TotalCost = supply.TotalCost,
                    SupplierFullName = supplierFullName,
                    CompanyName = companyName,
                    Details = supplyDetails,
                    GoodsSummary = goodsListString,
                    FromDate = fromDate ?? DateTime.MinValue,
                    ToDate = toDate ?? DateTime.MaxValue
                });
            }

            ClassSerialize.SerializeToXml(ref suppliesReport, "supplies.xml");

            var customerSalesForXml = customers_list.Select(c => new
            {
                Customer = c,
                SalesSum = sales_list.Where(s => s.ID_Customer == c.ID &&
                    (!fromDate.HasValue || s.SaleDate.Date >= fromDate.Value) &&
                    (!toDate.HasValue || s.SaleDate.Date <= toDate.Value))
                    .Sum(s => s.TotalAmount)
            }).ToList();

            ClassSerialize.SerializeToXml(ref customers_list, "customers.xml");
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

                formReportView viewForm = new formReportView();

                FastReport.Preview.PreviewControl pcForView = new FastReport.Preview.PreviewControl();
                pcForView.Dock = DockStyle.Fill;

                viewForm.pnlReportPreview.Controls.Add(pcForView); 

                report.Preview = pcForView;

                report.Show(false);

                viewForm.ShowDialog();
            }
        }

        private void UpdateDataGridViews()
        {
            dgvReport.Rows.Clear();
            dgvReport.Columns.Clear();

            DateTime? fromDate = mcReportDate.SelectionStart != mcReportDate.MinDate ? mcReportDate.SelectionRange.Start.Date : (DateTime?)null;
            DateTime? toDate = mcReportDate.SelectionStart != mcReportDate.MinDate ? mcReportDate.SelectionRange.End.Date : (DateTime?)null;

            if (rbGoods.Checked)
            {
                dgvReport.Columns.Clear();
                dgvReport.Columns.Add("Name", "Назва");
                dgvReport.Columns.Add("Category", "Категорія");
                dgvReport.Columns.Add("Country", "Країна");
                dgvReport.Columns.Add("Price", "Ціна");
                dgvReport.Columns.Add("Warranty", "Гарантія (міс.)");
                dgvReport.Columns.Add("Description", "Опис");

                foreach (var g in goods_list)
                {
                    dgvReport.Rows.Add(g.Name, g.Category, g.ManufacturingCountry, g.Price, g.WarrantyMonths, g.Description);
                }

                decimal totalPrice = goods_list.Sum(g => g.Price);
                int count = goods_list.Count;
                decimal avgPrice = count > 0 ? totalPrice / count : 0;

                dgvReport.Rows.Add("");
                dgvReport.Rows.Add("Загальна сума цін", totalPrice.ToString("N2"));
                dgvReport.Rows.Add("Кількість товарів", count);
                dgvReport.Rows.Add("Середня ціна", avgPrice.ToString("N2"));
            }

            else if (rbCustomers.Checked)
            {
                dgvReport.Columns.Clear();
                dgvReport.Columns.Add("FullName", "ПІБ");
                dgvReport.Columns.Add("Phone", "Телефон");
                dgvReport.Columns.Add("Email", "Email");
                dgvReport.Columns.Add("Address", "Адреса");
                dgvReport.Columns.Add("TotalSales", "Загальна сума покупок");

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
                    dgvReport.Rows.Add(cs.Customer.Full_name, cs.Customer.Phone_number, cs.Customer.Email, cs.Customer.Address, cs.SalesSum.ToString("N2"));
                }

                decimal totalCustomerSales = customerSales.Sum(cs => cs.SalesSum);
                int customerCount = customerSales.Count(cs => cs.SalesSum > 0);
                decimal avgCustomerSales = customerCount > 0 ? totalCustomerSales / customerCount : 0;

                dgvReport.Rows.Add("");
                dgvReport.Rows.Add("Загальна сума покупок клієнтів", totalCustomerSales.ToString("N2"));
                dgvReport.Rows.Add("Кількість активних клієнтів", customerCount);
                dgvReport.Rows.Add("Середня сума на клієнта", avgCustomerSales.ToString("N2"));
            }

            else if (rbSales.Checked)
            {
                dgvReport.Columns.Clear();
                dgvReport.Columns.Add("SaleDate", "Дата продажу");
                dgvReport.Columns.Add("Customer", "Клієнт");
                dgvReport.Columns.Add("Employee", "Працівник");
                dgvReport.Columns.Add("TotalAmount", "Сума");

                var filteredSales = sales_list.Where(s =>
                    (!fromDate.HasValue || s.SaleDate.Date >= fromDate.Value) &&
                    (!toDate.HasValue || s.SaleDate.Date <= toDate.Value)
                ).OrderBy(s => s.SaleDate).ToList();

                foreach (var s in filteredSales)
                {
                    var customer = customers_list.FirstOrDefault(c => c.ID == s.ID_Customer);
                    var employee = employees_list.FirstOrDefault(emp => emp.ID == s.ID_Employee);
                    
                    if (customer != null && employee != null)
                    {
                        dgvReport.Rows.Add(s.SaleDate.ToString("dd.MM.yyyy"), customer.Full_name, employee.Full_name, s.TotalAmount.ToString("N2"));
                    }
                }

                decimal totalSales = filteredSales.Sum(s => s.TotalAmount);
                int salesCount = filteredSales.Count;
                decimal avgSale = salesCount > 0 ? totalSales / salesCount : 0;

                dgvReport.Rows.Add("");
                dgvReport.Rows.Add("Загальна сума продажів", totalSales.ToString("N2"));
                dgvReport.Rows.Add("Кількість продажів", salesCount);
                dgvReport.Rows.Add("Середня сума продажу", avgSale.ToString("N2"));
            }

            else if (rbSupplies.Checked)
            {
                dgvReport.Columns.Clear();
                dgvReport.Columns.Add("DeliveryDate", "Дата поставки");
                dgvReport.Columns.Add("Supplier", "Постачальник");
                dgvReport.Columns.Add("Company", "Компанія");
                dgvReport.Columns.Add("TotalCost", "Сума");

                var filteredSupplies = supplies_list.Where(s =>
                    (!fromDate.HasValue || s.DeliveryDate.Date >= fromDate.Value) &&
                    (!toDate.HasValue || s.DeliveryDate.Date <= toDate.Value)
                ).OrderBy(s => s.DeliveryDate).ToList();

                foreach (var s in filteredSupplies)
                {
                    var supplier = suppliers_list.FirstOrDefault(sp => sp.ID == s.ID_Supplier);
                    
                    if (supplier != null)
                    {
                        dgvReport.Rows.Add(s.DeliveryDate.ToString("dd.MM.yyyy"), supplier.Full_name, supplier.Company_name, s.TotalCost.ToString("N2"));
                    }
                }

                decimal totalSupplies = filteredSupplies.Sum(s => s.TotalCost);
                int suppliesCount = filteredSupplies.Count;
                decimal avgSupply = suppliesCount > 0 ? totalSupplies / suppliesCount : 0;

                dgvReport.Rows.Add("");
                dgvReport.Rows.Add("Загальна сума поставок", totalSupplies.ToString("N2"));
                dgvReport.Rows.Add("Кількість поставок", suppliesCount);
                dgvReport.Rows.Add("Середня сума поставки", avgSupply.ToString("N2"));
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            LoadData();

            mcReportDate.SelectionStart = mcReportDate.MinDate;
            mcReportDate.SelectionEnd = mcReportDate.MinDate;

            UpdateDataGridViews();
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

                    repExcel.SetValue("Sheet1", "A1", "Звіт", "string", true);

                    int currentRow = 2;

                    for (int col = 0; col < dgvReport.Columns.Count; col++)
                    {
                        repExcel.SetValue("Sheet1", $"{(char)('A' + col)}{currentRow}", dgvReport.Columns[col].HeaderText, "string", true);
                    }

                    currentRow++;

                    for (int row = 0; row < dgvReport.Rows.Count; row++)
                    {
                        if (dgvReport.Rows[row].IsNewRow) continue;

                        for (int col = 0; col < dgvReport.Columns.Count; col++)
                        {
                            repExcel.SetValue("Sheet1", $"{(char)('A' + col)}{currentRow}", dgvReport.Rows[row].Cells[col].Value?.ToString(), "string");
                        }

                        currentRow++;
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

                    List<string> headers = new List<string>();

                    for (int i = 0; i < dgvReport.Columns.Count; i++) headers.Add(dgvReport.Columns[i].HeaderText);
                    tableData.Add(headers);

                    for (int row = 0; row < dgvReport.Rows.Count; row++)
                    {
                        if (dgvReport.Rows[row].IsNewRow) continue;

                        List<string> rowData = new List<string>();

                        for (int col = 0; col < dgvReport.Columns.Count; col++) rowData.Add(dgvReport.Rows[row].Cells[col].Value?.ToString());

                        tableData.Add(rowData);
                    }

                    repWord.InsertTable(tableData);

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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime? fromDate = mcReportDate.SelectionStart != mcReportDate.MinDate ? mcReportDate.SelectionRange.Start.Date : (DateTime?)null;
            DateTime? toDate = mcReportDate.SelectionStart != mcReportDate.MinDate ? mcReportDate.SelectionRange.End.Date : (DateTime?)null;

            PrepareReportData(fromDate, toDate);

            UpdateDataGridViews();
            UpdateReport();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mcReportDate.SelectionStart = mcReportDate.MinDate;
            mcReportDate.SelectionEnd = mcReportDate.MinDate;

            UpdateDataGridViews();
        }
    }
}