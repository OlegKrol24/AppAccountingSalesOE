namespace AppAccountingSalesOE
{
    partial class formWorkingWithDeliveries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbManufacturingCountry = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbNameGoods = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.tbTotalCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbGoods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.Name_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbUnitCost = new System.Windows.Forms.TextBox();
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManufacturingCountry
            // 
            this.lbManufacturingCountry.AutoSize = true;
            this.lbManufacturingCountry.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.lbManufacturingCountry.Location = new System.Drawing.Point(484, 599);
            this.lbManufacturingCountry.Name = "lbManufacturingCountry";
            this.lbManufacturingCountry.Size = new System.Drawing.Size(143, 20);
            this.lbManufacturingCountry.TabIndex = 7;
            this.lbManufacturingCountry.Text = "Загальна вартість";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbCategory.Location = new System.Drawing.Point(173, 99);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(124, 19);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Дата постачання";
            // 
            // lbNameGoods
            // 
            this.lbNameGoods.AutoSize = true;
            this.lbNameGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbNameGoods.Location = new System.Drawing.Point(173, 43);
            this.lbNameGoods.Name = "lbNameGoods";
            this.lbNameGoods.Size = new System.Drawing.Size(107, 19);
            this.lbNameGoods.TabIndex = 5;
            this.lbNameGoods.Text = "Постачальник";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownHeight = 50;
            this.cbSupplier.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.IntegralHeight = false;
            this.cbSupplier.Location = new System.Drawing.Point(348, 42);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(311, 27);
            this.cbSupplier.TabIndex = 8;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.dtpDeliveryDate.Location = new System.Drawing.Point(348, 99);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(264, 27);
            this.dtpDeliveryDate.TabIndex = 9;
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbTotalCost.Location = new System.Drawing.Point(650, 596);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.Size = new System.Drawing.Size(162, 27);
            this.tbTotalCost.TabIndex = 10;
            this.tbTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(701, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 51);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbGoods
            // 
            this.cbGoods.DropDownHeight = 50;
            this.cbGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.IntegralHeight = false;
            this.cbGoods.Location = new System.Drawing.Point(348, 150);
            this.cbGoods.Name = "cbGoods";
            this.cbGoods.Size = new System.Drawing.Size(388, 27);
            this.cbGoods.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label1.Location = new System.Drawing.Point(173, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Список товарів";
            // 
            // dgvDetails
            // 
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_goods,
            this.Quantity,
            this.Unit_cost,
            this.Total_cost});
            this.dgvDetails.Location = new System.Drawing.Point(17, 315);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(809, 261);
            this.dgvDetails.TabIndex = 14;
            // 
            // Name_goods
            // 
            this.Name_goods.HeaderText = "Назва товару";
            this.Name_goods.MinimumWidth = 6;
            this.Name_goods.Name = "Name_goods";
            this.Name_goods.ReadOnly = true;
            this.Name_goods.Width = 215;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Кількість";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 115;
            // 
            // Unit_cost
            // 
            this.Unit_cost.HeaderText = "Ціна за шт.";
            this.Unit_cost.MinimumWidth = 6;
            this.Unit_cost.Name = "Unit_cost";
            this.Unit_cost.ReadOnly = true;
            this.Unit_cost.Width = 125;
            // 
            // Total_cost
            // 
            this.Total_cost.HeaderText = "Загальна ціна";
            this.Total_cost.MinimumWidth = 6;
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.ReadOnly = true;
            this.Total_cost.Width = 130;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDetail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddDetail.Location = new System.Drawing.Point(17, 660);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(260, 51);
            this.btnAddDetail.TabIndex = 15;
            this.btnAddDetail.Text = "Додати деталі про поставку";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.Location = new System.Drawing.Point(173, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ціна за шт.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.Location = new System.Drawing.Point(173, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Кількість";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbQuantity.Location = new System.Drawing.Point(348, 202);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(189, 27);
            this.tbQuantity.TabIndex = 18;
            // 
            // tbUnitCost
            // 
            this.tbUnitCost.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbUnitCost.Location = new System.Drawing.Point(348, 254);
            this.tbUnitCost.Name = "tbUnitCost";
            this.tbUnitCost.Size = new System.Drawing.Size(189, 27);
            this.tbUnitCost.TabIndex = 19;
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDetail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditDetail.Location = new System.Drawing.Point(285, 660);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(260, 51);
            this.btnEditDetail.TabIndex = 20;
            this.btnEditDetail.Text = "Редагувати деталі поставки";
            this.btnEditDetail.UseVisualStyleBackColor = false;
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDetail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteDetail.Location = new System.Drawing.Point(566, 660);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(125, 51);
            this.btnDeleteDetail.TabIndex = 21;
            this.btnDeleteDetail.Text = "Видалити";
            this.btnDeleteDetail.UseVisualStyleBackColor = false;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // formWorkingWithDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 713);
            this.Controls.Add(this.btnDeleteDetail);
            this.Controls.Add(this.btnEditDetail);
            this.Controls.Add(this.tbUnitCost);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGoods);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTotalCost);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.lbManufacturingCountry);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbNameGoods);
            this.Name = "formWorkingWithDeliveries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання/редагування поставок";
            this.Load += new System.EventHandler(this.formWorkingWithDeliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManufacturingCountry;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbNameGoods;
        public System.Windows.Forms.ComboBox cbSupplier;
        public System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        public System.Windows.Forms.TextBox tbTotalCost;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cbGoods;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbQuantity;
        public System.Windows.Forms.TextBox tbUnitCost;
        private System.Windows.Forms.Button btnEditDetail;
        private System.Windows.Forms.Button btnDeleteDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_cost;
    }
}