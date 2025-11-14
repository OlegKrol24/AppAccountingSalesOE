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
using System.Windows.Forms.VisualStyles;

namespace AppAccountingSalesOE
{
    public partial class formGoods : Form
    {
        private User currentUser;

        public formGoods(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        public List<Goods> goods_list = new List<Goods>();

        void LoadData()
        {
            try { db.Execute<Goods>(file_db, "select g.id_goods, g.name_goods, g.category, g.manufacturing_country, g.price, g.warranty_months, g.description, g.image from goods g", ref goods_list); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void ShowGoods(ref List<Goods> temp_goods, ref DataGridView data)
        {
            dgvGoods.Rows.Clear();

            if (goods_list.Count > 0)
            {
                foreach (Goods g in temp_goods)
                {
                    data.Rows.Add(g.Name, g.Category, g.ManufacturingCountry, g.Price, g.WarrantyMonths);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowGoods(ref goods_list, ref dgvGoods);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ClassSerialize.SerializeToXml<List<Goods>>(ref goods_list, "data.xml");

            // Інтеграція RepExcel для створення звіту в Excel
            string excelFilePath = Path.Combine(Environment.CurrentDirectory, "GoodsReport.xlsx"); // Шлях до файлу на робочому столі

            using (RepExcel repExcel = new RepExcel())
            {
                try
                {
                    // Створюємо нову книгу Excel
                    repExcel.CreateNewBook(excelFilePath);

                    // Відкриваємо книгу для редагування
                    repExcel.OpenBook(excelFilePath);

                    // Заповнюємо заголовки на аркуші "Saturn Data"
                    repExcel.SetValue("Saturn Data", "A1", "Назва товару", "string", true);
                    repExcel.SetValue("Saturn Data", "B1", "Категорія", "string", true);
                    repExcel.SetValue("Saturn Data", "C1", "Країна виробник", "string", true);
                    repExcel.SetValue("Saturn Data", "D1", "Ціна", "string", true);
                    repExcel.SetValue("Saturn Data", "E1", "Гарантія (міс.)", "string", true);
                    repExcel.SetValue("Saturn Data", "F1", "Опис", "string", true);
                    repExcel.SetValue("Saturn Data", "G1", "Зображення", "string", true); // Колонка для шляху до зображення (якщо потрібно вставити - див. нижче)

                    // Заповнюємо дані з goods_list
                    int rowIndex = 2; // Починаємо з рядка 2

                    foreach (Goods g in goods_list)
                    {
                        repExcel.SetValue("Saturn Data", $"A{rowIndex}", g.Name, "string");
                        repExcel.SetValue("Saturn Data", $"B{rowIndex}", g.Category, "string");
                        repExcel.SetValue("Saturn Data", $"C{rowIndex}", g.ManufacturingCountry, "string");
                        repExcel.SetValue("Saturn Data", $"D{rowIndex}", g.Price.ToString(), "double");
                        repExcel.SetValue("Saturn Data", $"E{rowIndex}", g.WarrantyMonths.ToString(), "double");
                        repExcel.SetValue("Saturn Data", $"F{rowIndex}", g.Description, "string");
                        repExcel.SetValue("Saturn Data", $"G{rowIndex}", g.Image, "string"); // Шлях до зображення (якщо є)

                        rowIndex++;
                    }

                    repExcel.AutoFitColumns("Saturn Data");

                    // Зберігаємо файл
                    repExcel.Save(excelFilePath);

                    // Закриваємо книгу
                    repExcel.CloseBook();

                    MessageBox.Show($"Звіт створено: {excelFilePath}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //formReport frmReport = new formReport();

                    //frmReport.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при створенні звіту: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void formGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReportWord_Click(object sender, EventArgs e)
        {
            string wordFilePath = Path.Combine(Environment.CurrentDirectory, "GoodsReport.docx");

            using (RepWord repWord = new RepWord())
            {
                try
                {
                    repWord.CreateNewDocument(wordFilePath);
                    repWord.InsertText("Звіт про товари", true, "center");

                    // Вставка таблиці з даними
                    List<List<string>> tableData = new List<List<string>>();

                    tableData.Add(new List<string> {"Назва", "Категорія", "Країна виробник", "Ціна", "Гарантія (міс.)", "Опис" }); // Заголовок таблиці

                    decimal counter = 0;

                    foreach (Goods g in goods_list)
                    {
                        tableData.Add(new List<string> { g.Name, g.Category, g.ManufacturingCountry, g.Price.ToString(), g.WarrantyMonths.ToString(), g.Description });

                        counter += g.Price;
                    }

                    repWord.InsertTable(tableData);

                    repWord.InsertText($"\nЗагальна сума цін товарів: {counter}", true, "right");

                    repWord.Save(wordFilePath);

                    repWord.ExportToPdf(wordFilePath.Replace(".docx", ".pdf"));

                    repWord.CloseDocument();

                    MessageBox.Show($"Документ створено: {wordFilePath}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //formReport frmReport = new formReport();

                    //frmReport.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при створенні документа: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFilterGoods_Click(object sender, EventArgs e)
        {
            formFilter formFilter = new formFilter();

            if (formFilter.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Фільтр застосовано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnAddGoods_Click(object sender, EventArgs e)
        {

        }
    }
}
