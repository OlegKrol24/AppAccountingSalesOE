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
        List<Supplies_details> old_details_list = new List<Supplies_details>();

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

            if (mode == "edit")
            {
                db.Execute<Supplies_details>(file_db, $"select id_supply_details, id_supply, id_goods, quantity, unit_cost from supplies_details where id_supply = {supplyId}", ref old_details_list);
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (cbGoods.SelectedItem is Goods selectedGood && int.TryParse(tbQuantity.Text, out int quantity) && decimal.TryParse(tbUnitCost.Text, out decimal unitCost) && quantity > 0 && unitCost > 0)
            {
                decimal total = quantity * unitCost;
                dgvDetails.Rows.Add(selectedGood.Name, quantity, unitCost, total);

                UpdateTotalCost();

                cbGoods.SelectedIndex = -1;
                tbQuantity.Text = "";
                tbUnitCost.Text = "";
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

                            UpdateStock(goodId, quantity);
                        }
                    }

                    else
                    {
                        foreach (var oldDetail in old_details_list) UpdateStock(oldDetail.ID_goods, -oldDetail.Quantity);

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

                            UpdateStock(goodId, quantity);
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

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDetails.SelectedRows[0];

                string goodName = selectedRow.Cells[0].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells[1].Value);
                decimal unitCost = Convert.ToDecimal(selectedRow.Cells[2].Value);

                cbGoods.Text = goodName;
                tbQuantity.Text = quantity.ToString();
                tbUnitCost.Text = unitCost.ToString("N2");

                dgvDetails.Rows.Remove(selectedRow);
                UpdateTotalCost();

                MessageBox.Show("Деталь завантажено для редагування. Внесіть зміни і додайте заново.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else MessageBox.Show("Виберіть деталь для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (dgvDetails.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Ви впевнені, що хочете видалити деталі поставки?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (confirm == DialogResult.Yes)
                {
                    dgvDetails.Rows.Remove(dgvDetails.SelectedRows[0]);
                    UpdateTotalCost();
                }
            }

            else MessageBox.Show("Виберіть деталь для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}