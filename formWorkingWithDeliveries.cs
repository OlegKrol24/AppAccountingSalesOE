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
    public partial class formWorkingWithDeliveries : Form
    {
        private string mode;
        private int supplyId;

        public formWorkingWithDeliveries(string mode, int id)
        {
            InitializeComponent();

            this.mode = mode;
            this.supplyId = id;
            this.Text = mode == "add" ? "Додавання поставки" : "Редагування поставки";
        }

        ClassDataBase db = new ClassDataBase();
        string file_db = "Сourse_ASOE";

        List<Suppliers> suppliers_list = new List<Suppliers>();
        List<Goods> goods_list = new List<Goods>();

        private void formWorkingWithDeliveries_Load(object sender, EventArgs e)
        {
            db.Execute<Suppliers>(file_db, "select id_supplier, full_name from suppliers", ref suppliers_list);

            cbSupplier.DataSource = suppliers_list;
            cbSupplier.DisplayMember = "Full_name";
            cbSupplier.ValueMember = "ID";

            db.Execute<Goods>(file_db, "select id_goods, name_goods from goods", ref goods_list);

            cbGoods.DataSource = goods_list;
            cbGoods.DisplayMember = "Name";
            cbGoods.ValueMember = "ID";
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (cbGoods.SelectedItem is Goods selectedGood && int.TryParse(tbQuantity.Text, out int quantity) && decimal.TryParse(tbUnitCost.Text, out decimal unitCost) && quantity > 0 && unitCost > 0)
            {
                decimal total = quantity * unitCost;
                dgvDetails.Rows.Add(selectedGood.Name, quantity, unitCost, total);

                UpdateTotalCost();
            }

            else MessageBox.Show("Заповніть коректно деталі!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UpdateTotalCost()
        {
            decimal total = 0m;

            foreach (DataGridViewRow row in dgvDetails.Rows)
            {
                if (row.Cells[3].Value != null) total += Convert.ToDecimal(row.Cells[3].Value);
            }

            tbTotalCost.Text = total.ToString("N2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbSupplier.SelectedValue is int supplierId && DateTime.TryParse(dtpDeliveryDate.Value.ToString("dd.MM.yyyy"), out DateTime deliveryDate) && decimal.TryParse(tbTotalCost.Text, out decimal totalCost))
            {
                int detailCount = 0;

                foreach (DataGridViewRow row in dgvDetails.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null && !string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString())) detailCount++;
                }

                if (detailCount == 0)
                {
                    MessageBox.Show("Додайте хоча б одну деталь поставки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    string query;

                    if (mode == "add")
                    {
                        query = $"insert into supplies (id_supplier, delivery_date, total_cost) values ({supplierId}, '{deliveryDate:dd.MM.yyyy}', {totalCost.ToString(System.Globalization.CultureInfo.InvariantCulture)})";
                        
                        db.ExecuteNonQuery(file_db, query);
                        
                        int newSupplyId = Convert.ToInt32(db.ExecuteScalar(file_db, "select last_insert_rowid()"));

                        foreach (DataGridViewRow row in dgvDetails.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string goodName = row.Cells[0].Value?.ToString();

                            if (string.IsNullOrWhiteSpace(goodName)) continue;

                            var good = goods_list.FirstOrDefault(g => g.Name == goodName);

                            if (good == null)
                            {
                                MessageBox.Show($"Товар '{goodName}' не знайдено в базі даних! Рядок {row.Index + 1}.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            int goodId = good.ID;
                            int quantity = Convert.ToInt32(row.Cells[1].Value);
                            decimal unitCost = Convert.ToDecimal(row.Cells[2].Value);
                            string detailQuery = $"insert into supplies_details (id_supply, id_goods, quantity, unit_cost) VALUES ({newSupplyId}, {goodId}, {quantity}, {unitCost.ToString(System.Globalization.CultureInfo.InvariantCulture)})";
                            
                            db.ExecuteNonQuery(file_db, detailQuery);
                        }
                    }
                    else
                    {
                        query = $"update supplies set id_supplier = {supplierId}, delivery_date = '{deliveryDate:dd.MM.yyyy}', total_cost = {totalCost.ToString(System.Globalization.CultureInfo.InvariantCulture)} WHERE id_supply = {supplyId}";
                        
                        db.ExecuteNonQuery(file_db, query);

                        string deleteDetails = $"delete from supplies_details where id_supply = {supplyId}";
                        
                        db.ExecuteNonQuery(file_db, deleteDetails);

                        foreach (DataGridViewRow row in dgvDetails.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string goodName = row.Cells[0].Value?.ToString();

                            if (string.IsNullOrWhiteSpace(goodName)) continue;

                            var good = goods_list.FirstOrDefault(g => g.Name == goodName);

                            if (good == null)
                            {
                                MessageBox.Show($"Товар '{goodName}' не знайдено в базі даних! Рядок {row.Index + 1}.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            int goodId = good.ID;
                            int quantity = Convert.ToInt32(row.Cells[1].Value);
                            decimal unitCost = Convert.ToDecimal(row.Cells[2].Value);
                            string detailQuery = $"insert into supplies_details (id_supply, id_goods, quantity, unit_cost) values ({supplyId}, {goodId}, {quantity}, {unitCost.ToString(System.Globalization.CultureInfo.InvariantCulture)})";
                            
                            db.ExecuteNonQuery(file_db, detailQuery);
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else MessageBox.Show("Заповніть всі поля та додайте деталі!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }            
    }
}