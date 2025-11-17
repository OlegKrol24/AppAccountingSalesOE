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
    public partial class formWorkingWithGoods : Form
    {
        private string mode;  // "add" або "edit"
        private int goodId;   // ID для редагування

        public formWorkingWithGoods(string mode, int id)
        {
            InitializeComponent();

            this.mode = mode;
            this.goodId = id;
            this.Text = mode == "add" ? "Додавання товару" : "Редагування товару";
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<Goods> goods_list = new List<Goods>();

        void LoadData()
        {
            try { db.Execute<Goods>(file_db, "select g.id_goods, g.name_goods, g.category, g.manufacturing_country, g.price, g.warranty_months, g.description, g.image from goods g", ref goods_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowCategories(ref List<Goods> temp_goods, ref ComboBox comboBox)
        {
            comboBox.Items.Clear();

            var uniqueCategories = temp_goods.Select(g => g.Category).Distinct().ToList();

            foreach (var type in uniqueCategories) comboBox.Items.Add(type);
        }

        void ShowWarranties(ref List<Goods> temp_goods, ref ComboBox comboBox)
        {
            comboBox.Items.Clear();

            var uniqueWarranties = temp_goods.Select(g => g.WarrantyMonths).Distinct().ToList();

            foreach (var type in uniqueWarranties) comboBox.Items.Add(type);
        }

        private void formWorkingWithGoods_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowCategories(ref goods_list, ref cbCategory);
            ShowWarranties(ref goods_list, ref cbWarrantyMonths);
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK) pbImageGoods.Image = Image.FromFile(ofdImage.FileName);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNameGoods.Text) || string.IsNullOrWhiteSpace(cbCategory.Text) ||
                string.IsNullOrWhiteSpace(tbManufacturingCountry.Text) || string.IsNullOrWhiteSpace(tbPrice.Text) ||
                string.IsNullOrWhiteSpace(cbWarrantyMonths.Text))
            {
                MessageBox.Show("Заповніть всі обов'язкові поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price;

            if (!decimal.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Некоректна ціна!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int warranty;

            if (!int.TryParse(cbWarrantyMonths.Text, out warranty))
            {
                MessageBox.Show("Некоректна гарантія!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string imagePath = "";

            if (pbImageGoods.Image != null && !string.IsNullOrEmpty(ofdImage.FileName))
            {
                string imagesFolder = Path.Combine(Directory.GetCurrentDirectory(), "Photos");

                if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);

                string fileName = Path.GetFileName(ofdImage.FileName);

                imagePath = Path.Combine("Photos", fileName);

                File.Copy(ofdImage.FileName, Path.Combine(Directory.GetCurrentDirectory(), imagePath), true);
            }
            try
            {
                string query;

                if (mode == "add")
                {
                    query = $"insert into goods (name_goods, category, manufacturing_country, price, warranty_months, description, image) " +
                    $"values ('{tbNameGoods.Text.Replace("'", "''")}', '{cbCategory.Text.Replace("'", "''")}', " +
                    $"'{tbManufacturingCountry.Text.Replace("'", "''")}', {price.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {warranty}, " +
                    $"'{rtbDescription.Text.Replace("'", "''")}', '{imagePath.Replace("'", "''")}')";
                }
                else  // edit
                {
                    query = $"update goods set name_goods = '{tbNameGoods.Text.Replace("'", "''")}', " +
                    $"category = '{cbCategory.Text.Replace("'", "''")}', " +
                    $"manufacturing_country = '{tbManufacturingCountry.Text.Replace("'", "''")}', " +
                    $"price = {price.ToString(System.Globalization.CultureInfo.InvariantCulture)}, warranty_months = {warranty}, " +
                    $"description = '{rtbDescription.Text.Replace("'", "''")}', " +
                    $"image = '{imagePath.Replace("'", "''")}' " +
                    $"WHERE id_goods = {goodId}";
                }

                db.ExecuteNonQuery(file_db, query);  // Припустимо, що ClassDataBase має метод ExecuteNonQuery для INSERT/UPDATE
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
