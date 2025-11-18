using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAccountingSalesOE
{
    public partial class formWorkingWithCustomers : Form
    {
        private string mode;  // "add" або "edit"
        private int customerId;   // ID для редагування

        public formWorkingWithCustomers(string mode, int id)
        {
            InitializeComponent();

            this.mode = mode;
            this.customerId = id;
            this.Text = mode == "add" ? "Додавання клієнта" : "Редагування клієнта";
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<clCustomers> customers_list = new List<clCustomers>();

        void LoadData()
        {
            try { db.Execute<clCustomers>(file_db, "select c.id_customer, c.full_name, c.phone_number, c.email, c.address from customers c", ref customers_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void formWorkingWithCustomers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFullNameCustomers.Text) || string.IsNullOrWhiteSpace(tbPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) || string.IsNullOrWhiteSpace(tbAddress.Text))
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
                    query = $"insert into customers (full_name, phone_number, email, address) " +
                    $"values ('{tbFullNameCustomers.Text.Replace("'", "''")}', '{tbPhoneNumber.Text.Replace("'", "''")}', " +
                    $"'{tbEmail.Text.Replace("'", "''")}', '{tbAddress.Text.Replace("'", "'")}')";
                }

                else  // edit
                {
                    query = $"update customers set full_name = '{tbFullNameCustomers.Text.Replace("'", "''")}', " +
                    $"phone_number = '{tbPhoneNumber.Text.Replace("'", "''")}', " + 
                    $"email = '{tbEmail.Text.Replace("'", "''")}', address = '{tbAddress.Text.Replace("'", "''")}' " +
                    $"where id_customer = {customerId}";
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
