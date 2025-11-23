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
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbUnitCost = new System.Windows.Forms.TextBox();
            this.Name_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManufacturingCountry
            // 
            this.lbManufacturingCountry.AutoSize = true;
            this.lbManufacturingCountry.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManufacturingCountry.Location = new System.Drawing.Point(344, 604);
            this.lbManufacturingCountry.Name = "lbManufacturingCountry";
            this.lbManufacturingCountry.Size = new System.Drawing.Size(132, 19);
            this.lbManufacturingCountry.TabIndex = 7;
            this.lbManufacturingCountry.Text = "Загальна вартість";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(173, 99);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(124, 19);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Дата постачання";
            // 
            // lbNameGoods
            // 
            this.lbNameGoods.AutoSize = true;
            this.lbNameGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameGoods.Location = new System.Drawing.Point(173, 43);
            this.lbNameGoods.Name = "lbNameGoods";
            this.lbNameGoods.Size = new System.Drawing.Size(107, 19);
            this.lbNameGoods.TabIndex = 5;
            this.lbNameGoods.Text = "Постачальник";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(348, 42);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(262, 24);
            this.cbSupplier.TabIndex = 8;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(348, 99);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(264, 22);
            this.dtpDeliveryDate.TabIndex = 9;
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Location = new System.Drawing.Point(513, 604);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.Size = new System.Drawing.Size(162, 22);
            this.tbTotalCost.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(638, 647);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbGoods
            // 
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.Location = new System.Drawing.Point(348, 150);
            this.cbGoods.Name = "cbGoods";
            this.cbGoods.Size = new System.Drawing.Size(363, 24);
            this.cbGoods.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Список товарів";
            // 
            // dgvDetails
            // 
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_goods,
            this.Quantity,
            this.Unit_cost,
            this.Total_cost});
            this.dgvDetails.Location = new System.Drawing.Point(20, 315);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(760, 261);
            this.dgvDetails.TabIndex = 14;
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDetail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddDetail.Location = new System.Drawing.Point(24, 639);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(273, 51);
            this.btnAddDetail.TabIndex = 15;
            this.btnAddDetail.Text = "Додати деталі про поставку";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ціна за шт.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Кількість";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(348, 202);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(189, 22);
            this.tbQuantity.TabIndex = 18;
            // 
            // tbUnitCost
            // 
            this.tbUnitCost.Location = new System.Drawing.Point(348, 254);
            this.tbUnitCost.Name = "tbUnitCost";
            this.tbUnitCost.Size = new System.Drawing.Size(189, 22);
            this.tbUnitCost.TabIndex = 19;
            // 
            // Name_goods
            // 
            this.Name_goods.HeaderText = "Назва товару";
            this.Name_goods.MinimumWidth = 6;
            this.Name_goods.Name = "Name_goods";
            this.Name_goods.ReadOnly = true;
            this.Name_goods.Width = 170;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Кількість";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
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
            // formWorkingWithDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 702);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_cost;
    }
}