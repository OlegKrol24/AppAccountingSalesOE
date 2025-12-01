using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;

namespace AppAccountingSalesOE
{
    public partial class formCart : Form
    {
        private User currentUser;

        public formCart(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser != null)
            {
                if (currentUser.Role.Contains("клієнт"))
                {
                    tsmiCustomers.Enabled = false;
                    tsmiSales.Enabled = false;
                    tsmiSupplies.Enabled = false;
                    tsmiReports.Enabled = false;
                }

                if (currentUser.Role.Contains("менеджер")) tsmiSupplies.Enabled = false;
            }
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        List<Goods> globalgoods = new List<Goods>();
        List<Stock> stock = new List<Stock>();
        List<Employees> employees = new List<Employees>();
        List<clCustomers> customers = new List<clCustomers>();
        List<clSales> sales = new List<clSales>();
        List<clSalesDetails> salesDetails = new List<clSalesDetails>();

        void LoadData()
        {
            try { db.Execute<Goods>(file_db, "select id_goods, name_goods, category, manufacturing_country, price, warranty_months, description, image from goods", ref globalgoods); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            try { db.Execute<Stock>(file_db, "select id_stock, id_goods, quantity from stock", ref stock); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            try { db.Execute<Employees>(file_db, "select e.id_employee, e.full_name, e.\"position\", e.phone_number, e.email, e.address, e.sex from employees e", ref employees); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            try { db.Execute<clCustomers>(file_db, "select c.id_customer, c.full_name, c.phone_number, c.email, c.address from customers c", ref customers); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            try { db.Execute<clSales>(file_db, "select id_sale, sale_date, id_customer, id_employee, total_amount from sales", ref sales); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            try { db.Execute<clSalesDetails>(file_db, "select id_sale_details, id_sale, id_goods, quantity, unit_price from sales_details", ref salesDetails); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadCartItems()
        {
            dgvCart.Rows.Clear();

            decimal totalSum = 0m;

            foreach (var item in Cart.GoodsInCart)
            {
                decimal itemTotal = item.Goods.Price * item.Quantity;

                dgvCart.Rows.Add(item.Goods.Name, item.Goods.Price.ToString("N2"), item.Quantity, itemTotal.ToString("N2"));

                totalSum += itemTotal;
            }

            lbTotalAmount.Text = $"{totalSum:N2} грн";
        }

        private void UpdateCartLabels()
        {
            int totalQuantity = Cart.GoodsInCart.Sum(item => item.Quantity);
            decimal totalPrice = Cart.GoodsInCart.Sum(item => item.Goods.Price * item.Quantity);

            label2.Text = $"{totalQuantity} шт";
            label4.Text = $"{totalPrice:F2} грн";
        }

        private void formCart_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCartItems();
            UpdateCartLabels();
        }

        private CartItem selectedCartItem = null;

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvCart.CurrentCell is DataGridViewButtonCell && dgvCart.CurrentCell.ColumnIndex == 4 && dgvCart.CurrentCell.RowIndex >= 0)
                {
                    string name_g = dgvCart.Rows[dgvCart.CurrentCell.RowIndex].Cells[0].Value?.ToString();

                    if (!string.IsNullOrEmpty(name_g))
                    {
                        var cartItem = Cart.GoodsInCart.FirstOrDefault(item => item.Goods.Name == name_g);

                        if (cartItem != null)
                        {
                            Cart.GoodsInCart.Remove(cartItem);
                            LoadCartItems();
                            UpdateCartLabels();
                        }
                    }

                    return;
                }

                string name = dgvCart.Rows[e.RowIndex].Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(name))
                {
                    selectedCartItem = Cart.GoodsInCart.FirstOrDefault(item => item.Goods.Name == name);

                    if (selectedCartItem != null)
                    {
                        dgvCart.ClearSelection();
                        dgvCart.Rows[e.RowIndex].Selected = true;
                    }
                }
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            if (selectedCartItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть товар у кошику, натиснувши на його назву", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stockItem = stock.FirstOrDefault(s => s.ID_Goods == selectedCartItem.Goods.ID);

            if (stockItem != null && stockItem.Quantity > selectedCartItem.Quantity)
            {
                selectedCartItem.Quantity++;

                LoadCartItems();
                UpdateCartLabels();
            }

            else MessageBox.Show("Недостатньо товару на складі", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (selectedCartItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть товар у кошику, натиснувши на його назву", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedCartItem.Quantity--;

            if (selectedCartItem.Quantity <= 0)
            {
                Cart.GoodsInCart.Remove(selectedCartItem);
                selectedCartItem = null;
            }

            LoadCartItems();
            UpdateCartLabels();
        }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                var row = dgvCart.Rows[e.RowIndex];

                string name = row.Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(name))
                {
                    int newQuantity;

                    if (int.TryParse(row.Cells[2].Value?.ToString(), out newQuantity) && newQuantity > 0)
                    {
                        var cartItem = Cart.GoodsInCart.FirstOrDefault(item => item.Goods.Name == name);

                        if (cartItem != null)
                        {
                            var stockItem = stock.FirstOrDefault(s => s.ID_Goods == cartItem.Goods.ID);

                            if (stockItem != null && stockItem.Quantity >= newQuantity)
                            {
                                cartItem.Quantity = newQuantity;
                                decimal itemTotal = cartItem.Goods.Price * newQuantity;
                                row.Cells[3].Value = itemTotal.ToString("N2");
                                LoadCartItems();
                            }

                            else
                            {
                                MessageBox.Show("Недостатньо товару на складі", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                LoadCartItems();
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Введіть коректну кількість (ціле число > 0)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadCartItems();
                    }
                }
            }
        }

        private int InsertSale(DateTime saleDate, int? customerId, int? employeeId, decimal totalAmount)
        {
            string insertQuery = $"insert into sales (sale_date, id_customer, id_employee, total_amount) values ('{saleDate:dd.MM.yyyy}', {customerId ?? (object)"NULL"}, {employeeId ?? (object)"NULL"}, {totalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture)})";
            
            try
            {
                db.ExecuteNonQuery(file_db, insertQuery);

                object lastId = db.ExecuteScalar(file_db, "select last_insert_rowid()");

                return Convert.ToInt32(lastId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка вставки продажу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void InsertSalesDetails(int saleId)
        {
            foreach (var item in Cart.GoodsInCart)
            {
                string query = $"insert into sales_details (id_sale, id_goods, quantity, unit_price) values ({saleId}, {item.Goods.ID}, {item.Quantity}, {item.Goods.Price.ToString(System.Globalization.CultureInfo.InvariantCulture)})";
                
                try { db.ExecuteNonQuery(file_db, query); }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка вставки деталів продажу для '{item.Goods.Name}': {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateStockAfterPurchase()
        {
            foreach (var item in Cart.GoodsInCart)
            {
                string updateQuery = $"update stock set quantity = quantity - {item.Quantity} where id_goods = {item.Goods.ID}";
                
                try { db.ExecuteNonQuery(file_db, updateQuery); }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка оновлення складу для '{item.Goods.Name}': {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (Cart.GoodsInCart.Count == 0)
            {
                MessageBox.Show("Кошик порожній", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = Cart.GoodsInCart.Sum(item => item.Goods.Price * item.Quantity);
            int? customerId = null;
            int? employeeId = null;
            string customerName = "Роздрібний покупець";
            string employeeName = "Касир";

            Random rand = new Random();

            if (currentUser.Role.Contains("клієнт"))
            {
                customerId = currentUser.ID;

                var cust = customers.FirstOrDefault(c => c.ID == customerId);

                if (cust != null) customerName = cust.Full_name;

                if (employees.Count > 0)
                {
                    var emp = employees[rand.Next(employees.Count)];

                    employeeId = emp.ID;
                    employeeName = emp.Full_name;
                }
            }

            else if (currentUser.Role.Contains("менеджер"))
            {
                employeeId = currentUser.ID;
                
                var emp = employees.FirstOrDefault(e => e.ID == employeeId);

                if (emp != null) employeeName = emp.Full_name;

                if (customers.Count > 0)
                {
                    var cust = customers[rand.Next(customers.Count)];
                    
                    customerId = cust.ID;
                    customerName = cust.Full_name;
                }
            }

            int saleId = InsertSale(DateTime.Now, customerId, employeeId, totalAmount);
            if (saleId == -1) return;

            InsertSalesDetails(saleId);
            UpdateStockAfterPurchase();


            var chequeReport = new List<ChequeReportDTO>
            {
                new ChequeReportDTO
                {
                    CustomerFullName = customerName,
                    EmployeeFullName = employeeName,
                    TotalAmount = totalAmount,
                    Details = Cart.GoodsInCart.Select((item, index) => new ChequeDetailDTO
                    {
                        ID = index + 1,
                        GoodsName = item.Goods.Name,
                        Quantity = item.Quantity,
                        UnitPrice = item.Goods.Price
                    }).ToList()
                }
            };

            string chequeXmlPath = Path.Combine(Directory.GetCurrentDirectory(), "cheque.xml");

            ClassSerialize.SerializeToXml(ref chequeReport, chequeXmlPath);

            try
            {
                using (var report = new Report())
                {
                    string reportPath = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "Cheque.frx");

                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show("Не знайдено файл Cheque.frx у папці Reports", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    report.Load(reportPath);

                    report.RegisterData(chequeXmlPath, "Cheque");

                    report.Prepare();
                    report.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка чеку: " + ex.Message);
            }

            Cart.GoodsInCart.Clear();
            LoadCartItems();
            UpdateCartLabels();

            MessageBox.Show("Замовлення успішно оформлено!\nЧек сформовано.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbMainMenu_Click(object sender, EventArgs e)
        {
            if (msMainMenu.Visible == false) msMainMenu.Visible = true;
            else msMainMenu.Visible = false;
        }

        private void formCart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGoods formGoods = new formGoods(currentUser);
            formGoods.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cart.GoodsInCart.Clear();
            LoadCartItems();
            UpdateCartLabels();
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

        private void tsmiReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReport formReport = new formReport(currentUser);
            formReport.Show();
        }
    }
}
