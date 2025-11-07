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
        public formMainPage()
        {
            InitializeComponent();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGoods formGoods = new formGoods();
            formGoods.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCustomers formCustomers = new formCustomers();
            formCustomers.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSales formSales = new formSales();
            formSales.Show();
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDeliveries formDeliveries = new formDeliveries();
            formDeliveries.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReport formReport = new formReport();
            formReport.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
