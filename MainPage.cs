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

namespace AppAccountingSalesOE
{
    public partial class formMainPage : Form
    {
        private User currentUser;

        public formMainPage(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser != null)
            {
                lbRoleText.Text = currentUser.Role.ToUpper();
                lbUserText.Text = currentUser.LastName + " " + currentUser.FirstName;

                if (currentUser.Role.Contains("клієнт"))
                {
                    btnCustomers.Enabled = false;
                    btnSales.Enabled = false;
                    btnDeliveries.Enabled = false;
                    btnReports.Enabled = false;

                    tsmiCustomers.Enabled = false;
                    tsmiSales.Enabled = false;
                    tsmiSupplies.Enabled = false;
                    tsmiReports.Enabled = false;
                }

                if (currentUser.Role.Contains("менеджер"))
                {
                    btnDeliveries.Enabled = false;

                    tsmiSupplies.Enabled = false;
                }
            }
            
            else
            {
                lbRoleText.Text = "Без ролі";
                lbUserText.Text = "Невідомий";
            }
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

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

        private void pbCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCart formCart = new formCart(currentUser);
            formCart.Show();
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

        private void UpdateCartLabels()
        {
            int totalQuantity = Cart.GoodsInCart.Sum(item => item.Quantity);
            decimal totalPrice = Cart.GoodsInCart.Sum(item => item.Goods.Price * item.Quantity);

            lbQuantityCart.Text = $"{totalQuantity} шт";
            lbTotalAmountCart.Text = $"{totalPrice:F2} грн";
        }

        List<Goods> popularGoods = new List<Goods>();
        private Dictionary<int, int> goodsSoldCount = new Dictionary<int, int>();
        private int currentIndex = 0;
        private int totalSalesCount = 0;

        private void ShowCurrentGoods()
        {
            if (popularGoods.Count == 0) return;

            var goods = popularGoods[currentIndex];
            string imagePath = goods.Image;

            string noImagePath = Path.Combine(Directory.GetCurrentDirectory(), "Goods", "NoGoods.png");

            if (pbPopularGoods.Image != null)
            {
                pbPopularGoods.Image.Dispose();
                pbPopularGoods.Image = null;
            }

            try
            {
                Image imageToLoad = null;
                string finalPath = Path.Combine(Directory.GetCurrentDirectory(), "Goods", imagePath);

                if (!File.Exists(finalPath)) finalPath = noImagePath;

                if (File.Exists(finalPath))
                {
                    using (var stream = new FileStream(finalPath, FileMode.Open, FileAccess.Read))
                    {
                        imageToLoad = Image.FromStream(stream);
                    }

                    pbPopularGoods.Image = imageToLoad;
                }

                else pbPopularGoods.Image = null;
            }
            catch (Exception ex)
            {
                pbPopularGoods.Image = null;

                MessageBox.Show($"Помилка завантаження зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int sold = goodsSoldCount.ContainsKey(goods.ID) ? goodsSoldCount[goods.ID] : 0;

            string toolTipText = $"Назва: {goods.Name}\n" +
                                 $"Категорія: {goods.Category}\n" +
                                 $"Країна: {goods.ManufacturingCountry}\n" +
                                 $"Ціна: {goods.Price:F2} грн\n" +
                                 $"Опис: {goods.Description}\n" +
                                 $"------------------------------------------------------------\n" +
                                 $"Продано: {sold} шт.";

            ttPopularGoods.SetToolTip(pbPopularGoods, toolTipText);

            lbSoldInfo.Text = $"{sold} / {totalSalesCount}";
        }

        void LoadData()
        {
            popularGoods.Clear();
            goodsSoldCount.Clear();
            totalSalesCount = 0;

            try
            {
                string totalQuery = "select sum(quantity) from sales_details";
                var result = db.ExecuteScalar(file_db, totalQuery);

                if (result != DBNull.Value && result != null && int.TryParse(result.ToString(), out int total)) totalSalesCount = total;
            }
            catch { totalSalesCount = 0; }

            string countQuery = "select g.id_goods, sum(sd.quantity) as sold_count " +
                                "from sales s " +
                                "join sales_details sd using(id_sale) " +
                                "join goods g using(id_goods) " +
                                "group by g.id_goods " +
                                "order by sold_count DESC " +
                                "limit 10";

            SqliteConnection con = null;

            try
            {
                using (var reader = db.ExecuteReader(file_db, countQuery, out con))
                {
                    var topIds = new List<int>();

                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id_goods"]);
                            int count = Convert.ToInt32(reader["sold_count"]);

                            goodsSoldCount[id] = count;
                            topIds.Add(id);
                        }
                    }

                    if (topIds.Count > 0)
                    {
                        string idsList = string.Join(",", topIds);
                        string goodsQuery = $"select id_goods, name_goods, category, manufacturing_country, price, warranty_months, description, image from goods where id_goods in ({idsList})";

                        var tempGoods = new List<Goods>();

                        db.Execute<Goods>(file_db, goodsQuery, ref tempGoods);

                        foreach (var g in tempGoods)
                        {
                            g.Image = Path.Combine(Directory.GetCurrentDirectory(), "Goods", g.Image ?? "NoGoods.png");
                            popularGoods.Add(g);
                        }

                        popularGoods.Sort((a, b) => goodsSoldCount[b.ID].CompareTo(goodsSoldCount[a.ID]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open) con.Close();
            }

            if (popularGoods.Count > 0)
            {
                currentIndex = 0;
                ShowCurrentGoods();
            }

            else
            {
                pbPopularGoods.Image = null;
                lbSoldInfo.Text = $"0 / {totalSalesCount}";
            }

            lbRoleText.Text = currentUser.Role.ToUpper();
            lbUserText.Text = currentUser.LastName + " " + currentUser.FirstName;
        }

        private void formMainPage_Load(object sender, EventArgs e)
        {
            LoadData();

            UpdateCartLabels();
        }

        private void pbArrowLeft_Click(object sender, EventArgs e)
        {
            if (popularGoods.Count == 0) return;

            int count = popularGoods.Count;

            currentIndex = (currentIndex - 1 + count) % count;

            ShowCurrentGoods();
        }

        private void pbArrowRight_Click(object sender, EventArgs e)
        {
            if (popularGoods.Count == 0) return;

            currentIndex = (currentIndex + 1) % popularGoods.Count;

            ShowCurrentGoods();
        }
    }
}
