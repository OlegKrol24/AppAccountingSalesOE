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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formWorkingWithDeliveries));
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
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbUnitCost = new System.Windows.Forms.TextBox();
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.Name_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManufacturingCountry
            // 
            resources.ApplyResources(this.lbManufacturingCountry, "lbManufacturingCountry");
            this.lbManufacturingCountry.Name = "lbManufacturingCountry";
            // 
            // lbCategory
            // 
            resources.ApplyResources(this.lbCategory, "lbCategory");
            this.lbCategory.Name = "lbCategory";
            // 
            // lbNameGoods
            // 
            resources.ApplyResources(this.lbNameGoods, "lbNameGoods");
            this.lbNameGoods.Name = "lbNameGoods";
            // 
            // cbSupplier
            // 
            resources.ApplyResources(this.cbSupplier, "cbSupplier");
            this.cbSupplier.DropDownHeight = 50;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Name = "cbSupplier";
            // 
            // dtpDeliveryDate
            // 
            resources.ApplyResources(this.dtpDeliveryDate, "dtpDeliveryDate");
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            // 
            // tbTotalCost
            // 
            resources.ApplyResources(this.tbTotalCost, "tbTotalCost");
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.ReadOnly = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbGoods
            // 
            resources.ApplyResources(this.cbGoods, "cbGoods");
            this.cbGoods.DropDownHeight = 50;
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.Name = "cbGoods";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvDetails
            // 
            resources.ApplyResources(this.dgvDetails, "dgvDetails");
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
            this.dgvDetails.RowTemplate.Height = 24;
            // 
            // btnAddDetail
            // 
            resources.ApplyResources(this.btnAddDetail, "btnAddDetail");
            this.btnAddDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.UseVisualStyleBackColor = false;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbQuantity
            // 
            resources.ApplyResources(this.tbQuantity, "tbQuantity");
            this.tbQuantity.Name = "tbQuantity";
            // 
            // tbUnitCost
            // 
            resources.ApplyResources(this.tbUnitCost, "tbUnitCost");
            this.tbUnitCost.Name = "tbUnitCost";
            // 
            // btnEditDetail
            // 
            resources.ApplyResources(this.btnEditDetail, "btnEditDetail");
            this.btnEditDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.UseVisualStyleBackColor = false;
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnDeleteDetail
            // 
            resources.ApplyResources(this.btnDeleteDetail, "btnDeleteDetail");
            this.btnDeleteDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDetail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.UseVisualStyleBackColor = false;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // Name_goods
            // 
            resources.ApplyResources(this.Name_goods, "Name_goods");
            this.Name_goods.Name = "Name_goods";
            this.Name_goods.ReadOnly = true;
            // 
            // Quantity
            // 
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit_cost
            // 
            resources.ApplyResources(this.Unit_cost, "Unit_cost");
            this.Unit_cost.Name = "Unit_cost";
            this.Unit_cost.ReadOnly = true;
            // 
            // Total_cost
            // 
            resources.ApplyResources(this.Total_cost, "Total_cost");
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.ReadOnly = true;
            // 
            // formWorkingWithDeliveries
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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