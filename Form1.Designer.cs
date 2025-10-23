namespace AppAccountingSalesOE
{
    partial class Form1
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
            this.btnReport = new System.Windows.Forms.Button();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.name_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturing_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warranty_months = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(477, 615);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(203, 41);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Звіт";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dgvGoods
            // 
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_goods,
            this.category,
            this.manufacturing_country,
            this.price,
            this.warranty_months,
            this.stock_quantity,
            this.description});
            this.dgvGoods.Location = new System.Drawing.Point(62, 34);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.RowHeadersWidth = 51;
            this.dgvGoods.RowTemplate.Height = 24;
            this.dgvGoods.Size = new System.Drawing.Size(998, 552);
            this.dgvGoods.TabIndex = 1;
            // 
            // name_goods
            // 
            this.name_goods.HeaderText = "Назва товару";
            this.name_goods.MinimumWidth = 6;
            this.name_goods.Name = "name_goods";
            this.name_goods.ReadOnly = true;
            this.name_goods.Width = 150;
            // 
            // category
            // 
            this.category.HeaderText = "Категорія";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // manufacturing_country
            // 
            this.manufacturing_country.HeaderText = "Країна виробник";
            this.manufacturing_country.MinimumWidth = 6;
            this.manufacturing_country.Name = "manufacturing_country";
            this.manufacturing_country.ReadOnly = true;
            this.manufacturing_country.Width = 130;
            // 
            // price
            // 
            this.price.HeaderText = "Ціна";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // warranty_months
            // 
            this.warranty_months.HeaderText = "Гарантія (міс.)";
            this.warranty_months.MinimumWidth = 6;
            this.warranty_months.Name = "warranty_months";
            this.warranty_months.ReadOnly = true;
            this.warranty_months.Width = 125;
            // 
            // stock_quantity
            // 
            this.stock_quantity.HeaderText = "Кількість на складі";
            this.stock_quantity.MinimumWidth = 6;
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.ReadOnly = true;
            this.stock_quantity.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "Опис";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 691);
            this.Controls.Add(this.dgvGoods);
            this.Controls.Add(this.btnReport);
            this.Name = "Form1";
            this.Text = "Товари";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturing_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn warranty_months;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}

