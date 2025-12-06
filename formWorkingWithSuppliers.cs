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

            LocalizationHelper.ApplyLocalization(this, LanguageManager.CurrentCulture);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = tbFullNameSupplier.Text.Trim();
            string companyName = tbCompanyName.Text.Trim();
            string phone = tbPhoneNumber.Text.Trim();
            string email = tbEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Заповніть всі обов'язкові поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patternPhone = @"^\+?380\d{9}$";

            if (!Regex.IsMatch(phone, patternPhone))
            {
                MessageBox.Show("Некоректний номер телефону! Формат: +380XXXXXXXXX", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pattern_email = @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, pattern_email))
            {
                MessageBox.Show("Некоректна електронна пошта!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Suppliers> checkSuppliers = new List<Suppliers>();

                string checkQuery = $"select * from suppliers " +
                                    $"where lower(full_name) = lower('{fullName}') " +
                                    $"and lower(company_name) = lower('{companyName}') " +
                                    $"and lower(phone_number) = lower('{phone}') " +
                                    $"and lower(email) = lower('{email}')";

                if (mode == "edit") checkQuery += $" and id_supplier <> {supplierId}";

                db.Execute(file_db, checkQuery, ref checkSuppliers);

                if (checkSuppliers.Count > 0)
                {
                    MessageBox.Show("Постачальник з такими даними вже існує! Будь ласка, перевірте введені дані або відредагуйте вже існуючого", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFullNameSupplier.Clear();
            tbCompanyName.Clear();
            tbPhoneNumber.Clear();
            tbEmail.Clear();
        }
    }
}
