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
    public partial class formSuppliers : Form
    {
        public formSuppliers()
        {
            InitializeComponent();
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        List<Suppliers> suppliers_list = new List<Suppliers>();

        void LoadData()
        {
            try { db.Execute<Suppliers>(file_db, "select id_supplier, full_name, company_name, phone_number, email from suppliers", ref suppliers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowSuppliers(ref DataGridView data)
        {
            data.Rows.Clear();

            foreach (Suppliers sp in suppliers_list) data.Rows.Add(sp.Full_name, sp.Company_name, sp.Phone_number, sp.Email);
        }

        private void formSuppliers_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowSuppliers(ref dgvSuppliers);

            LocalizationHelper.ApplyLocalization(this, LanguageManager.CurrentCulture);
        }

        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            formWorkingWithSuppliers addForm = new formWorkingWithSuppliers("add", -1);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                suppliers_list.Clear();
                dgvSuppliers.Rows.Clear();

                LoadData();
                ShowSuppliers(ref dgvSuppliers);

                MessageBox.Show("Постачальника додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditSuppliers_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSuppliers.SelectedRows[0].Index;

                Suppliers selectedSupplier = suppliers_list[selectedIndex];

                formWorkingWithSuppliers editForm = new formWorkingWithSuppliers("edit", selectedSupplier.ID);

                editForm.tbFullNameSupplier.Text = selectedSupplier.Full_name;
                editForm.tbCompanyName.Text = selectedSupplier.Company_name;
                editForm.tbPhoneNumber.Text = selectedSupplier.Phone_number;
                editForm.tbEmail.Text = selectedSupplier.Email;

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    suppliers_list.Clear();
                    dgvSuppliers.Rows.Clear();

                    LoadData();
                    ShowSuppliers(ref dgvSuppliers);

                    MessageBox.Show("Дані про постачальника оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else MessageBox.Show("Виберіть постачальника для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDeleteSuppliers_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSuppliers.SelectedRows[0].Index;

                Suppliers selectedSupplier = suppliers_list[selectedIndex];

                DialogResult confirm = MessageBox.Show($"Ви впевнені, що хочете видалити постачальника '{selectedSupplier.Full_name}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        suppliers_list.Clear();
                        dgvSuppliers.Rows.Clear();

                        string deleteQuery = $"delete from suppliers where id_supplier = {selectedSupplier.ID}";

                        db.ExecuteNonQuery(file_db, deleteQuery);
                        LoadData();
                        ShowSuppliers(ref dgvSuppliers);

                        MessageBox.Show("Постачальника видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else MessageBox.Show("Виберіть постачальника для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
