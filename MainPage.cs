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
    public partial class formMainPage : Form
    {
        private User currentUser;  // Зберігаємо користувача

        public formMainPage(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser != null)
            {
                lbRoleText.Text = currentUser.Role.ToUpper();
                lbUserText.Text = currentUser.LastName + " " + currentUser.FirstName;
            }
            
            else
            {
                lbRoleText.Text = "Без ролі";
                lbUserText.Text = "Невідомий";
            }

            // Обмеження за роллю
            // if (currentUser.Role.Contains("КЛІЄНТ"))
            // {
            //     btnDeliveries.Enabled = false;  // Ховаємо "Поставки" для клієнтів
            // }
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";
        public List<clSales> sales = new List<clSales>();

        private void btnGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGoods formGoods = new formGoods(currentUser);
            formGoods.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCustomers formCustomers = new formCustomers(currentUser);
            formCustomers.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSales formSales = new formSales(currentUser);
            formSales.Show();
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDeliveries formDeliveries = new formDeliveries(currentUser);
            formDeliveries.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReport formReport = new formReport(currentUser);
            formReport.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (msMainMenu.Visible == false) msMainMenu.Visible = true;
            else msMainMenu.Visible = false;
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
