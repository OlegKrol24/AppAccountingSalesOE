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
using System.Windows.Forms.VisualStyles;

namespace AppAccountingSalesOE
{
    public partial class formGoods : Form
    {
        private User currentUser;

        public formGoods(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            if (currentUser != null)
            {
                if (currentUser.Role.Contains("клієнт"))
                {
                    btnAddGoods.Enabled = false;
                    btnEditGoods.Enabled = false;
                    btnDeleteGoods.Enabled = false;

                    tsmiCustomers.Enabled = false;
                    tsmiSales.Enabled = false;
                    tsmiSupplies.Enabled = false;
                    tsmiReports.Enabled = false;
                }

                if (currentUser.Role.Contains("менеджер"))
                {
                    btnEditGoods.Enabled = false;
                    btnDeleteGoods.Enabled = false;

                    tsmiSupplies.Enabled = false;
                }
            }
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<Goods> goods_list = new List<Goods>();

        void LoadData()
        {
            try { db.Execute<Goods>(file_db, "select g.id_goods, g.name_goods, g.category, g.manufacturing_country, g.price, g.warranty_months, g.description, g.image from goods g", ref goods_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowGoods(ref List<Goods> temp_goods, ref DataGridView data)
        {
            dgvGoods.Rows.Clear();

            if (goods_list.Count > 0)
            {
                foreach (Goods g in temp_goods)
                {
                    data.Rows.Add(g.Name, g.Category, g.ManufacturingCountry, g.Price);
                }
            }
        }

        private ImageList imageList;

        private void SetupListView()
        {
            lvGoods.View = View.LargeIcon;
            lvGoods.LargeImageList = new ImageList();
            imageList = lvGoods.LargeImageList;
            imageList.ImageSize = new Size(105, 105);
        }

        private void LoadGoodsToListViewFiltration(List<Goods> filteredGoods = null)
        {
            var goodsToDisplay = filteredGoods ?? goods_list;

            lvGoods.Items.Clear();
            imageList.Images.Clear();

            int imageIndex = 0;

            foreach (var product in goodsToDisplay.Distinct())
            {
                string current_path = Path.Combine(Directory.GetCurrentDirectory(), "Goods", product.Image);

                if (File.Exists(current_path))
                {
                    using (Image img = Image.FromFile(current_path)) imageList.Images.Add(img);

                    ListViewItem item = new ListViewItem(product.Name, imageIndex);
                    lvGoods.Items.Add(item);

                    imageIndex++;
                }

                else MessageBox.Show($"Файл не знайдено: {product.Image}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowGoods(ref goods_list, ref dgvGoods);
            SetupListView();
            LoadGoodsToListViewFiltration();
            UpdateCartLabels();
        }

        private void formGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnFilterGoods_Click(object sender, EventArgs e)
        {
            formFilter formFilter = new formFilter();

            if (formFilter.ShowDialog() == DialogResult.OK)
            {
                decimal? minPrice = formFilter.MinPrice;
                decimal? maxPrice = formFilter.MaxPrice;
                string selectedCountry = formFilter.SelectedCountry;
                List<string> selectedCategories = formFilter.SelectedCategories;
                List<int> selectedWarranties = formFilter.SelectedWarranties;

                var filteredGoods = goods_list.AsQueryable();

                if (minPrice.HasValue) filteredGoods = filteredGoods.Where(g => g.Price >= minPrice.Value).OrderBy(g => g.Price);

                if (maxPrice.HasValue) filteredGoods = filteredGoods.Where(g => g.Price <= maxPrice.Value).OrderBy(g => g.Price);

                if (!string.IsNullOrEmpty(selectedCountry)) filteredGoods = filteredGoods.Where(g => g.ManufacturingCountry.Equals(selectedCountry, StringComparison.OrdinalIgnoreCase));

                if (selectedCategories.Count > 0) filteredGoods = filteredGoods.Where(g => selectedCategories.Contains(g.Category));

                if (selectedWarranties.Count > 0) filteredGoods = filteredGoods.Where(g => selectedWarranties.Contains(g.WarrantyMonths));

                List<Goods> temp_goods = filteredGoods.ToList();

                ShowGoods(ref temp_goods, ref dgvGoods);
                LoadGoodsToListViewFiltration(temp_goods);

                MessageBox.Show("Фільтр застосовано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCart formCart = new formCart(currentUser);
            formCart.Show();
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

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            formWorkingWithGoods addForm = new formWorkingWithGoods("add", -1);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                goods_list.Clear();
                dgvGoods.Rows.Clear();

                LoadData();
                ShowGoods(ref goods_list, ref dgvGoods);

                MessageBox.Show("Товар додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditGoods_Click(object sender, EventArgs e)
        {
            if (dgvGoods.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvGoods.SelectedRows[0].Index;

                Goods selectedGood = goods_list[selectedIndex];

                formWorkingWithGoods editForm = new formWorkingWithGoods("edit", selectedGood.ID);

                editForm.tbNameGoods.Text = selectedGood.Name;
                editForm.cbCategory.Text = selectedGood.Category;
                editForm.tbManufacturingCountry.Text = selectedGood.ManufacturingCountry;
                editForm.tbPrice.Text = selectedGood.Price.ToString();
                editForm.cbWarrantyMonths.Text = selectedGood.WarrantyMonths.ToString();
                editForm.rtbDescription.Text = selectedGood.Description;

                if (!string.IsNullOrEmpty(selectedGood.Image) && File.Exists(selectedGood.Image))
                {
                    editForm.pbImageGoods.Image = Image.FromFile(selectedGood.Image);
                }

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    goods_list.Clear();
                    dgvGoods.Rows.Clear();

                    LoadData();
                    ShowGoods(ref goods_list, ref dgvGoods);

                    MessageBox.Show("Дані про товар оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else MessageBox.Show("Виберіть товар для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            if (dgvGoods.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvGoods.SelectedRows[0].Index;

                Goods selectedGoods = goods_list[selectedIndex];

                DialogResult confirm = MessageBox.Show($"Ви впевнені, що хочете видалити товар '{selectedGoods.Name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        goods_list.Clear();
                        dgvGoods.Rows.Clear();

                        string deleteQuery = $"delete from goods where id_goods = {selectedGoods.ID}";

                        db.ExecuteNonQuery(file_db, deleteQuery);
                        LoadData();
                        ShowGoods(ref goods_list, ref dgvGoods);

                        MessageBox.Show("Товар видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else MessageBox.Show("Виберіть товар для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            goods_list.Clear();
            LoadData();
            ShowGoods(ref goods_list, ref dgvGoods);
            LoadGoodsToListViewFiltration();
            UpdateCartLabels();
        }

        private void UpdateCartLabels()
        {
            int totalQuantity = Cart.GoodsInCart.Sum(item => item.Quantity);
            decimal totalPrice = Cart.GoodsInCart.Sum(item => item.Goods.Price * item.Quantity);

            label2.Text = $"{totalQuantity} шт";
            label4.Text = $"{totalPrice:F2} грн";
        }

        private void lvGoods_DoubleClick(object sender, EventArgs e)
        {
            if (lvGoods.SelectedItems.Count > 0)
            {
                var selectedItem = lvGoods.SelectedItems[0];
                var selectedGoods = goods_list.FirstOrDefault(g => g.Name == selectedItem.Text);

                if (selectedGoods != null)
                {
                    Cart.AddToCart(selectedGoods);

                    MessageBox.Show($"{selectedGoods.Name} додано до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    UpdateCartLabels();
                }

                else MessageBox.Show("Товар не знайдено!");
            }
        }
    }
}