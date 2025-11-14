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
    public partial class formCustomers : Form
    {
        private User currentUser;

        public formCustomers(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<clCustomers> customers_list = new List<clCustomers>();

        void LoadData()
        {
            try { db.Execute<clCustomers>(file_db, "select c.id_customer, c.full_name, c.phone_number, c.email, c.address from customers c", ref customers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowGoods(ref List<clCustomers> temp_customers, ref DataGridView data)
        {
            dgvCustomers.Rows.Clear();

            if (customers_list.Count > 0)
            {
                foreach (clCustomers c in temp_customers)
                {
                    data.Rows.Add(c.Full_name, c.Phone_number, c.Email, c.Address);
                }
            }
        }

        private void formCustomers_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowGoods(ref customers_list, ref dgvCustomers);
        }

        private void formCustomers_FormClosing(object sender, FormClosingEventArgs e)
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
            formMainPage formMainPage = new formMainPage(currentUser);
            formMainPage.Show();
        }

        private void tsmiGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGoods formGoods = new formGoods(currentUser);
            formGoods.Show();
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
