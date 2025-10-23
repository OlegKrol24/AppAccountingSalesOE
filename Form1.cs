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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<Goods> goods_list = new List<Goods>();

        void LoadData()
        {
            try { db.Execute<Goods>(file_db, "select g.id_goods, g.name_goods, g.category, g.manufacturing_country, g.price, g.warranty_months, g.stock_quantity, g.description, g.image from goods g", ref goods_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowGoods(ref List<Goods> temp_goods, ref DataGridView data)
        {
            dgvGoods.Rows.Clear();

            if (goods_list.Count > 0)
            {
                foreach (Goods g in temp_goods)
                {
                    data.Rows.Add(g.Name, g.Category, g.ManufacturingCountry, g.Price, g.WarrantyMonths, g.StockQuantity, g.Description);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowGoods(ref goods_list, ref dgvGoods);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ClassSerialize.SerializeToXml<List<Goods>>(ref goods_list, "data.xml");

            FormReport frmReport = new FormReport();

            frmReport.ShowDialog();
        }
    }
}
