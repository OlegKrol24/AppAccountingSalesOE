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
                if (currentUser.Role.Contains("менеджер"))
                {
                    //btnEditSale.Enabled = false;
                    //btnDeleteSale.Enabled = false;

                    tsmiSupplies.Enabled = false;
                }
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

        void ShowSales(ref DataGridView data)
        {
            data.Rows.Clear();

            foreach (clSales sal in sales_list)
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
        }
    }
}
