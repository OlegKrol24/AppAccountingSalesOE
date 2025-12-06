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
    public partial class formFilter : Form
    {
        public formFilter()
        {
            InitializeComponent();
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";
        public List<Goods> goods_list = new List<Goods>();
        public decimal? MinPrice { get; private set; }
        public decimal? MaxPrice { get; private set; }
        public string SelectedCountry { get; private set; }
        public List<string> SelectedCategories { get; private set; } = new List<string>();
        public List<int> SelectedWarranties { get; private set; } = new List<int>();

        void LoadData()
        {
            goods_list.Clear();

            try { db.Execute<Goods>(file_db, "select g.id_goods, g.name_goods, g.category, g.manufacturing_country, g.price, g.warranty_months, g.description, g.image from goods g", ref goods_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowManufCountries(ref List<Goods> temp_goods, ref ComboBox comboBox)
        {
            comboBox.Items.Clear();

            var uniqueManufCountries = temp_goods.Select(g => g.ManufacturingCountry).Distinct().OrderBy(c => c).ToList();
            
            foreach (var country in uniqueManufCountries) comboBox.Items.Add(country);
        }

        void ShowCategories(ref List<Goods> temp_goods, ref CheckedListBox checkedListBox)
        {
            checkedListBox.Items.Clear();

            var uniqueCategories = temp_goods.Select(g => g.Category).Distinct().OrderBy(c => c).ToList();
            
            foreach (var category in uniqueCategories) checkedListBox.Items.Add(category);
        }

        void ShowWarranties(ref List<Goods> temp_goods, ref CheckedListBox checkedListBox)
        {
            checkedListBox.Items.Clear();

            var uniqueWarranties = temp_goods.Select(g => g.WarrantyMonths).Distinct().OrderBy(w => w).ToList();
            
            foreach (var warranty in uniqueWarranties) checkedListBox.Items.Add(warranty.ToString());
        }

        private void formFilter_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowManufCountries(ref goods_list, ref cbManufCountries);
            ShowCategories(ref goods_list, ref clbCategories);
            ShowWarranties(ref goods_list, ref clbWarranties);

            LocalizationHelper.ApplyLocalization(this, LanguageManager.CurrentCulture);
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            decimal minP = 0, maxP = 0;
            bool hasMinPrice = !string.IsNullOrWhiteSpace(tbPriceFrom.Text);
            bool hasMaxPrice = !string.IsNullOrWhiteSpace(tbPriceTo.Text);

            if (hasMinPrice && !decimal.TryParse(tbPriceFrom.Text, out minP))
            {
                MessageBox.Show("Некоректне значення мінімальної ціни!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hasMaxPrice && !decimal.TryParse(tbPriceTo.Text, out maxP))
            {
                MessageBox.Show("Некоректне значення максимальної ціни!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hasMinPrice && hasMaxPrice && minP > maxP)
            {
                MessageBox.Show("Мінімальна ціна не може бути більшою за максимальну!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MinPrice = hasMinPrice ? (decimal?)minP : null;
            MaxPrice = hasMaxPrice ? (decimal?)maxP : null;
            SelectedCountry = cbManufCountries.SelectedItem?.ToString() ?? "";

            SelectedCategories.Clear();

            foreach (string item in clbCategories.CheckedItems) SelectedCategories.Add(item);

            SelectedWarranties.Clear();

            foreach (string item in clbWarranties.CheckedItems)
            {
                if (int.TryParse(item, out int warranty)) SelectedWarranties.Add(warranty);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
