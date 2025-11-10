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

        private bool AuthorizeUser(string login, string password)
        {
            string query = "select id_user, login, password from users where login = '" + login + "' and password = '" + password + "'";

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
                MessageBox.Show("Авторизація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Add role 

                formMainPage mainPage = new formMainPage();
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
