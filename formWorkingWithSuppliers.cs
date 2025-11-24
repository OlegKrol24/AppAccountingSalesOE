using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAccountingSalesOE
{
    public partial class formWorkingWithSuppliers : Form
    {

        private string mode;
        private int supplierId;
        public formWorkingWithSuppliers(string mode, int id)
        {
            InitializeComponent();

            this.mode = mode;
            this.supplierId = id;
            this.Text = mode == "add" ? "Додавання постачальника" : "Редагування постачальника";
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        List<Suppliers> suppliers_list = new List<Suppliers>();

        void LoadData()
        {
            try { db.Execute<Suppliers>(file_db, "select id_supplier, full_name, company_name, phone_number, email from suppliers", ref suppliers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void formWorkingWithSuppliers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFullNameSupplier.Text) || string.IsNullOrWhiteSpace(tbCompanyName.Text) ||
                string.IsNullOrWhiteSpace(tbPhoneNumber.Text) || string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Заповніть всі обов'язкові поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pattern_phone_number = @"^\+?380\d{9}$";
            string pattern_email = @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$";

            string phone_number;

            if (!Regex.IsMatch(tbPhoneNumber.Text.Trim(), pattern_phone_number))
            {
                MessageBox.Show("Некоректний номер телефону!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email;

            if (!Regex.IsMatch(tbEmail.Text.Trim(), pattern_email))
            {
                MessageBox.Show("Некоректна електронна пошта!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query;

                if (mode == "add")
                {
                    query = $"insert into suppliers (full_name, company_name, phone_number, email) " +
                    $"values ('{tbFullNameSupplier.Text.Replace("'", "''")}', '{tbCompanyName.Text.Replace("'", "''")}', " +
                    $"'{tbPhoneNumber.Text.Replace("'", "''")}', '{tbEmail.Text.Replace("'", "'")}')";
                }

                else
                {
                    query = $"update suppliers set full_name = '{tbFullNameSupplier.Text.Replace("'", "''")}', " +
                    $"company_name = '{tbCompanyName.Text.Replace("'", "''")}', " +
                    $"phone_number = '{tbPhoneNumber.Text.Replace("'", "''")}', email = '{tbEmail.Text.Replace("'", "''")}' " +
                    $"where id_supplier = {supplierId}";
                }

                db.ExecuteNonQuery(file_db, query);

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
