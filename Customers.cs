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

            if (currentUser != null)
            {
                // Обмеження за роллю
                if (currentUser.Role.Contains("менеджер"))
                {
                    btnEditCustomer.Enabled = false;
                    btnDeleteCustomer.Enabled = false;

                    tsmiSupplies.Enabled = false;
                }
            }
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<clCustomers> customers_list = new List<clCustomers>();

        void LoadData()
        {
            try { db.Execute<clCustomers>(file_db, "select c.id_customer, c.full_name, c.phone_number, c.email, c.address from customers c", ref customers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowCustomers(ref List<clCustomers> temp_customers, ref DataGridView data)
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
            ShowCustomers(ref customers_list, ref dgvCustomers);
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            formWorkingWithCustomers addForm = new formWorkingWithCustomers("add", -1);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                customers_list.Clear();
                dgvCustomers.Rows.Clear();

                LoadData();
                ShowCustomers(ref customers_list, ref dgvCustomers);

                MessageBox.Show("Клієнта додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCustomers.SelectedRows[0].Index;

                clCustomers selectedCustomer = customers_list[selectedIndex];

                formWorkingWithCustomers editForm = new formWorkingWithCustomers("edit", selectedCustomer.ID);

                editForm.tbFullNameCustomers.Text = selectedCustomer.Full_name;
                editForm.tbPhoneNumber.Text = selectedCustomer.Phone_number;
                editForm.tbEmail.Text = selectedCustomer.Email;
                editForm.tbAddress.Text = selectedCustomer.Address;

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    customers_list.Clear();
                    dgvCustomers.Rows.Clear();

                    LoadData();
                    ShowCustomers(ref customers_list, ref dgvCustomers);

                    MessageBox.Show("Дані про клієнта оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else MessageBox.Show("Виберіть клієнта для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCustomers.SelectedRows[0].Index;

                clCustomers selectedCustomer = customers_list[selectedIndex];

                DialogResult confirm = MessageBox.Show($"Ви впевнені, що хочете видалити клієнта '{selectedCustomer.Full_name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        customers_list.Clear();
                        dgvCustomers.Rows.Clear();

                        string deleteQuery = $"delete from customers where id_customer = {selectedCustomer.ID}";

                        db.ExecuteNonQuery(file_db, deleteQuery);
                        LoadData();
                        ShowCustomers(ref customers_list, ref dgvCustomers);

                        MessageBox.Show("Клієнта видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else MessageBox.Show("Виберіть клієнта для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbSearching.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                ShowCustomers(ref customers_list, ref dgvCustomers);
                return;
            }

            var filtered = customers_list
                .Where(c =>
                    (c.Full_name?.ToLower().Contains(searchText) ?? false) ||
                    (c.Phone_number?.ToLower().Contains(searchText) ?? false) ||
                    (c.Email?.ToLower().Contains(searchText) ?? false) ||
                    (c.Address?.ToLower().Contains(searchText) ?? false)
                )
                .ToList();

            ShowCustomers(ref filtered, ref dgvCustomers);
        }
    }
}
