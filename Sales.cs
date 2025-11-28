using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAccountingSalesOE
{
    public partial class formSales : Form
    {
        private User currentUser;

        public formSales(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser != null)
            {
                if (currentUser.Role.Contains("менеджер")) tsmiSupplies.Enabled = false;
            }
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        List<clSales> sales_list = new List<clSales>();
        List<Employees> employees = new List<Employees>();
        List<clCustomers> customers = new List<clCustomers>();

        void LoadData()
        {
            try { db.Execute<clSales>(file_db, "select id_sale, sale_date, id_customer, id_employee, total_amount from sales", ref sales_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { db.Execute<Employees>(file_db, "select e.id_employee, e.full_name, e.\"position\", e.phone_number, e.email, e.address, e.sex from employees e", ref employees); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try { db.Execute<clCustomers>(file_db, "select c.id_customer, c.full_name, c.phone_number, c.email, c.address from customers c", ref customers); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowSales(ref DataGridView data, List<clSales> filteredSales = null)
        {
            data.Rows.Clear();

            var salesToShow = filteredSales ?? sales_list;

            foreach (clSales sal in salesToShow)
            {
                clCustomers customer = customers.FirstOrDefault(cust => cust.ID == sal.ID_Customer);
                Employees employee = employees.FirstOrDefault(emp => emp.ID == sal.ID_Employee);

                if (customer != null && employee != null)
                {
                    data.Rows.Add(sal.SaleDate.ToString("dd.MM.yyyy"), customer.Full_name, employee.Full_name, sal.TotalAmount.ToString("N2"));
                }
            }
        }

        private void formSales_FormClosing(object sender, FormClosingEventArgs e)
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

        private void formSales_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowSales(ref dgvSales);

            cbCustomers.DataSource = customers;
            cbCustomers.DisplayMember = "Full_name";
            cbCustomers.ValueMember = "ID";
            cbCustomers.SelectedIndex = -1;

            cbEmployees.DataSource = employees;
            cbEmployees.DisplayMember = "Full_name";
            cbEmployees.ValueMember = "ID";
            cbEmployees.SelectedIndex = -1;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            DateTime? fromDate = null;
            DateTime? toDate = null;
            int? filterCustomerId = null;
            int? filterEmployeeId = null;

            if (mcSaleDate.SelectionStart != mcSaleDate.MinDate)
            {
                fromDate = mcSaleDate.SelectionRange.Start.Date;
                toDate = mcSaleDate.SelectionRange.End.Date;

                MessageBox.Show($"Обраний діапазон дат: {fromDate.Value:dd.MM.yyyy} - {toDate.Value:dd.MM.yyyy}");
            }

            else MessageBox.Show("Дата не обрана — ігноруємо фільтр за датою");

            if (cbCustomers.SelectedValue != null)
            {
                filterCustomerId = (int)cbCustomers.SelectedValue;

                MessageBox.Show($"Обраний клієнт ID: {filterCustomerId.Value}");
            }

            else MessageBox.Show("Клієнт не обраний — ігноруємо");

            if (cbEmployees.SelectedValue != null)
            {
                filterEmployeeId = (int)cbEmployees.SelectedValue;

                MessageBox.Show($"Обраний працівник ID: {filterEmployeeId.Value}");
            }

            else MessageBox.Show("Працівник не обраний — ігноруємо");

            var filteredSales = sales_list.Where(s =>
                (!fromDate.HasValue || (s.SaleDate.Date >= fromDate.Value && s.SaleDate.Date <= toDate.Value)) &&
                (!filterCustomerId.HasValue || s.ID_Customer == filterCustomerId.Value) &&
                (!filterEmployeeId.HasValue || s.ID_Employee == filterEmployeeId.Value)
            ).ToList();

            MessageBox.Show($"Кількість відфільтрованих продажів: {filteredSales.Count}");

            ShowSales(ref dgvSales, filteredSales);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbCustomers.SelectedIndex = -1;
            cbEmployees.SelectedIndex = -1;
            mcSaleDate.SelectionStart = mcSaleDate.MinDate;
            mcSaleDate.SelectionEnd = mcSaleDate.MinDate;

            ShowSales(ref dgvSales);
        }
    }
}
