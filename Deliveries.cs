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

        List<Goods> globalgoods = new List<Goods>();
        public List<Supplies> supplies_list = new List<Supplies>();
        public List<Supplies_details> supplies_details_list = new List<Supplies_details>();
        public List<Suppliers> suppliers_list = new List<Suppliers>();
        List<Stock> stock_list = new List<Stock>();

        void LoadData()
        {
            globalgoods.Clear();
            supplies_list.Clear();
            suppliers_list.Clear();
            supplies_details_list.Clear();
            stock_list.Clear();

            try { db.Execute<Goods>(file_db, "select id_goods, name_goods, category, manufacturing_country, price, warranty_months, description, image from goods", ref globalgoods); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Supplies>(file_db, "select s.id_supply, s.id_supplier, s.delivery_date, s.total_cost from supplies s", ref supplies_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Supplies_details>(file_db, "select sd.id_supply_details, sd.id_supply, sd.id_goods, sd.quantity, sd.unit_cost from supplies_details sd", ref supplies_details_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Suppliers>(file_db, "select sp.id_supplier, sp.full_name, sp.company_name, sp.phone_number, sp.email from suppliers sp", ref suppliers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try { db.Execute<Stock>(file_db, "select id_stock, id_goods, quantity from stock", ref stock_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowSupplies(ref DataGridView data)
        {
            data.Rows.Clear();

            foreach (Supplies s in supplies_list)
            {
                Suppliers supplier = suppliers_list.FirstOrDefault(sp => sp.ID == s.ID_Supplier);

                if (supplier != null)
                {
                    data.Rows.Add(supplier.Full_name, supplier.Company_name, s.DeliveryDate.ToString("dd.MM.yyyy"), s.TotalCost.ToString("N2"));
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
            ShowSupplies(ref dgvSupplies);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            formSuppliers suppliersForm = new formSuppliers();

            suppliersForm.ShowDialog();

            LoadData();
            ShowSupplies(ref dgvSupplies);
        }

        private void btnAddSupplies_Click(object sender, EventArgs e)
        {
            formWorkingWithDeliveries addForm = new formWorkingWithDeliveries("add", -1);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                ShowSupplies(ref dgvSupplies);

                MessageBox.Show("Поставку додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditSupplies_Click(object sender, EventArgs e)
        {
            if (dgvSupplies.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSupplies.SelectedRows[0].Index;

                Supplies selectedSupply = supplies_list[selectedIndex];

                formWorkingWithDeliveries editForm = new formWorkingWithDeliveries("edit", selectedSupply.ID);

                Suppliers supplier = suppliers_list.FirstOrDefault(sp => sp.ID == selectedSupply.ID_Supplier);

                if (supplier != null) editForm.cbSupplier.Text = supplier.Full_name;

                editForm.dtpDeliveryDate.Value = selectedSupply.DeliveryDate;
                editForm.tbTotalCost.Text = selectedSupply.TotalCost.ToString();

                List<Supplies_details> details = supplies_details_list.Where(sd => sd.ID_supply == selectedSupply.ID).ToList();

                foreach (var detail in details)
                {
                    Goods good = globalgoods.FirstOrDefault(g => g.ID == detail.ID_goods);

                    if (good != null)
                    {
                        decimal totalPrice = detail.Quantity * detail.Unit_cost;

                        editForm.dgvDetails.Rows.Add(good.Name, detail.Quantity, detail.Unit_cost, totalPrice);
                    }
                }

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                    ShowSupplies(ref dgvSupplies);

                    MessageBox.Show("Поставку оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else MessageBox.Show("Виберіть поставку для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UpdateStock(int id_goods, int deltaQuantity)
        {
            string checkQuery = $"select quantity from stock where id_goods = {id_goods}";
            object currentQtyObj = db.ExecuteScalar(file_db, checkQuery);

            if (currentQtyObj != null)
            {
                int currentQty = Convert.ToInt32(currentQtyObj);
                int newQty = currentQty + deltaQuantity;

                if (newQty < 0) newQty = 0;

                string updateQuery = $"update stock set quantity = {newQty} where id_goods = {id_goods}";

                db.ExecuteNonQuery(file_db, updateQuery);
            }

            else if (deltaQuantity > 0)
            {
                string insertQuery = $"insert into stock (id_goods, quantity) values ({id_goods}, {deltaQuantity})";

                db.ExecuteNonQuery(file_db, insertQuery);
            }
        }

        private void btnDeleteSupplies_Click(object sender, EventArgs e)
        {
            if (dgvSupplies.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSupplies.SelectedRows[0].Index;
                Supplies selectedSupply = supplies_list[selectedIndex];
                DialogResult confirm = MessageBox.Show($"Ви впевнені, що хочете видалити поставку від {selectedSupply.DeliveryDate:dd.MM.yyyy}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        List<Supplies_details> detailsToDelete = supplies_details_list.Where(sd => sd.ID_supply == selectedSupply.ID).ToList();
                        
                        foreach (var detail in detailsToDelete) UpdateStock(detail.ID_goods, -detail.Quantity);

                        string deleteDetailsQuery = $"delete from supplies_details where id_supply = {selectedSupply.ID}";
                        
                        db.ExecuteNonQuery(file_db, deleteDetailsQuery);
                        
                        string deleteQuery = $"delete from supplies where id_supply = {selectedSupply.ID}";
                        
                        db.ExecuteNonQuery(file_db, deleteQuery);
                        LoadData();
                        
                        ShowSupplies(ref dgvSupplies);
                        MessageBox.Show("Поставку видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else MessageBox.Show("Виберіть поставку для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}