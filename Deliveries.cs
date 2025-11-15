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
    public partial class formDeliveries : Form
    {
        private User currentUser;

        public formDeliveries(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<Supplies> supplies_list = new List<Supplies>();
        public List<Suppliers> suppliers_list = new List<Suppliers>();

        void LoadData()
        {
            try { db.Execute<Supplies>(file_db, "select s.id_supply, s.id_supplier, s.delivery_date, s.total_cost from supplies s", ref supplies_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Suppliers>(file_db, "select sp.id_supplier, sp.full_name, sp.company_name, sp.phone_number, sp.email from suppliers sp", ref suppliers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowGoods(ref List<Supplies> temp_supplies, ref List<Suppliers> temp_suppliers, ref DataGridView data)
        {
            dgvDeliveries.Rows.Clear();

            if (supplies_list.Count > 0)
            {
                foreach (Supplies s in temp_supplies)
                {
                    data.Rows.Add(s.DeliveryDate, s.TotalCost);
                }
            }
        }

        private void formDeliveries_FormClosing(object sender, FormClosingEventArgs e)
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

        private void tsmiGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGoods formGoods = new formGoods(currentUser);
            formGoods.Show();
        }

        private void tsmiReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReport formReport = new formReport(currentUser);
            formReport.Show();
        }

        private void formDeliveries_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowGoods(ref supplies_list, ref suppliers_list, ref dgvDeliveries);
        }
    }
}
