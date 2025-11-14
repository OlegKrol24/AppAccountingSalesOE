using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAccountingSalesOE
{
    public partial class formAuthorization : Form
    {
        public formAuthorization()
        {
            InitializeComponent();

            tbPassword.PasswordChar = '*';

            LoadEyeImages();
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";
        public List<User> users = new List<User>();

        private bool isPasswordVisible = false;
        private Image eyeOpenImage;
        private Image eyeClosedImage;

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                MessageBox.Show("Будь ласка, введіть логін", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Будь ласка, введіть пароль", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Хешування паролів
        string GetMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private bool AuthorizeUser(string login, string password)
        {
            // Хешуємо введений пароль перед порівнянням
            string hashedPassword = GetMd5Hash(password);

            string query = "select u.id_user, u.login, u.password, u.role,\r\ncase\r\n\twhen u.role like 'адміністратор%' or u.role like 'менеджер%' then e.full_name\r\n    when u.role like 'клієнт%' then c.full_name\r\n    else '' \r\nend as full_name\r\nfrom users u\r\nleft join employees e on u.id_employee = e.id_employee \r\nleft join customers c on u.id_customer = c.id_customer\r\nwhere u.login = '" + login + "' and u.password = '" + hashedPassword + "'";

            try
            {
                db.Execute<User>(file_db, query, ref users);

                if (users.Count > 0) return true;
                else return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!IsInputValid()) return;

            if (AuthorizeUser(tbLogin.Text.Trim(), tbPassword.Text.Trim()))
            {
                var fullName = users.Where(u => u.Login == tbLogin.Text && u.Password == GetMd5Hash(tbPassword.Text)).Select(u => u.LastName + " " + u.FirstName).FirstOrDefault();

                MessageBox.Show($"Авторизація успішна!\nЛаскаво просимо, {fullName}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Передаємо об'єкт авторизованого користувача (users[0])
                formMainPage mainPage = new formMainPage(users[0]);
                mainPage.Show();
            }

            else MessageBox.Show("Невірний логін або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadEyeImages()
        {
            string currentPath = Path.Combine(Directory.GetCurrentDirectory(), "Photos");

            if (!Directory.Exists(currentPath))
            {
                MessageBox.Show("Директорія 'Resources' не знайдена!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string eyeOpenPath = Path.Combine(currentPath, "Open_eye.png");
                string eyeClosedPath = Path.Combine(currentPath, "Closed_eye.png");

                if (!File.Exists(eyeOpenPath))
                {
                    MessageBox.Show($"Зображення 'Open_eye.png' не знайдено: {eyeOpenPath}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!File.Exists(eyeClosedPath))
                {
                    MessageBox.Show($"Зображення 'Closed_eye.png' не знайдено: {eyeClosedPath}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                eyeOpenImage = Image.FromFile(eyeOpenPath);
                eyeClosedImage = Image.FromFile(eyeClosedPath);
                pbEye.Image = eyeClosedImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні зображень: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                tbPassword.PasswordChar = '\0';
                pbEye.Image = eyeOpenImage;
            }

            else
            {
                tbPassword.PasswordChar = '*';
                pbEye.Image = eyeClosedImage;
            }
        }

        private void formAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
