namespace AppAccountingSalesOE
{
    partial class formDeliveries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDeliveries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSupplies = new System.Windows.Forms.DataGridView();
            this.Delivery_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTotalAmountCart = new System.Windows.Forms.Label();
            this.lbQuantityCart = new System.Windows.Forms.Label();
            this.btnDeleteSupplies = new System.Windows.Forms.Button();
            this.btnEditSupplies = new System.Windows.Forms.Button();
            this.btnAddSupplies = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.mcDeliveryDate = new System.Windows.Forms.MonthCalendar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.pbLanguageUA = new System.Windows.Forms.PictureBox();
            this.pbLanguageUS = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).BeginInit();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Name = "label5";
            // 
            // dgvSupplies
            // 
            resources.ApplyResources(this.dgvSupplies, "dgvSupplies");
            this.dgvSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSupplies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSupplies.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delivery_date,
            this.Supplier,
            this.Company_name,
            this.Total_cost});
            this.dgvSupplies.Name = "dgvSupplies";
            this.dgvSupplies.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplies.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplies.RowTemplate.Height = 24;
            // 
            // Delivery_date
            // 
            resources.ApplyResources(this.Delivery_date, "Delivery_date");
            this.Delivery_date.Name = "Delivery_date";
            this.Delivery_date.ReadOnly = true;
            // 
            // Supplier
            // 
            resources.ApplyResources(this.Supplier, "Supplier");
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Company_name
            // 
            resources.ApplyResources(this.Company_name, "Company_name");
            this.Company_name.Name = "Company_name";
            this.Company_name.ReadOnly = true;
            // 
            // Total_cost
            // 
            resources.ApplyResources(this.Total_cost, "Total_cost");
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.ReadOnly = true;
            // 
            // msMainMenu
            // 
            resources.ApplyResources(this.msMainMenu, "msMainMenu");
            this.msMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainPage,
            this.tsmiGoods,
            this.tsmiCustomers,
            this.tsmiSales,
            this.tsmiReports});
            this.msMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMainMenu.Name = "msMainMenu";
            // 
            // tsmiMainPage
            // 
            resources.ApplyResources(this.tsmiMainPage, "tsmiMainPage");
            this.tsmiMainPage.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiMainPage.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.tsmiMainPage.Name = "tsmiMainPage";
            this.tsmiMainPage.Click += new System.EventHandler(this.tsmiMainPage_Click);
            // 
            // tsmiGoods
            // 
            resources.ApplyResources(this.tsmiGoods, "tsmiGoods");
            this.tsmiGoods.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiGoods.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiGoods.Name = "tsmiGoods";
            this.tsmiGoods.Click += new System.EventHandler(this.tsmiGoods_Click);
            // 
            // tsmiCustomers
            // 
            resources.ApplyResources(this.tsmiCustomers, "tsmiCustomers");
            this.tsmiCustomers.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiCustomers.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiCustomers.Name = "tsmiCustomers";
            this.tsmiCustomers.Click += new System.EventHandler(this.tsmiCustomers_Click);
            // 
            // tsmiSales
            // 
            resources.ApplyResources(this.tsmiSales, "tsmiSales");
            this.tsmiSales.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiSales.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Click += new System.EventHandler(this.tsmiSales_Click);
            // 
            // tsmiReports
            // 
            resources.ApplyResources(this.tsmiReports, "tsmiReports");
            this.tsmiReports.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiReports.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Click += new System.EventHandler(this.tsmiReports_Click);
            // 
            // lbTotalAmountCart
            // 
            resources.ApplyResources(this.lbTotalAmountCart, "lbTotalAmountCart");
            this.lbTotalAmountCart.Name = "lbTotalAmountCart";
            // 
            // lbQuantityCart
            // 
            resources.ApplyResources(this.lbQuantityCart, "lbQuantityCart");
            this.lbQuantityCart.Name = "lbQuantityCart";
            // 
            // btnDeleteSupplies
            // 
            resources.ApplyResources(this.btnDeleteSupplies, "btnDeleteSupplies");
            this.btnDeleteSupplies.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSupplies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteSupplies.Name = "btnDeleteSupplies";
            this.btnDeleteSupplies.UseVisualStyleBackColor = false;
            this.btnDeleteSupplies.Click += new System.EventHandler(this.btnDeleteSupplies_Click);
            // 
            // btnEditSupplies
            // 
            resources.ApplyResources(this.btnEditSupplies, "btnEditSupplies");
            this.btnEditSupplies.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSupplies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditSupplies.Name = "btnEditSupplies";
            this.btnEditSupplies.UseVisualStyleBackColor = false;
            this.btnEditSupplies.Click += new System.EventHandler(this.btnEditSupplies_Click);
            // 
            // btnAddSupplies
            // 
            resources.ApplyResources(this.btnAddSupplies, "btnAddSupplies");
            this.btnAddSupplies.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddSupplies.Name = "btnAddSupplies";
            this.btnAddSupplies.UseVisualStyleBackColor = false;
            this.btnAddSupplies.Click += new System.EventHandler(this.btnAddSupplies_Click);
            // 
            // btnSuppliers
            // 
            resources.ApplyResources(this.btnSuppliers, "btnSuppliers");
            this.btnSuppliers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbCompanyName
            // 
            resources.ApplyResources(this.cbCompanyName, "cbCompanyName");
            this.cbCompanyName.DropDownHeight = 50;
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Name = "cbCompanyName";
            // 
            // cbSuppliers
            // 
            resources.ApplyResources(this.cbSuppliers, "cbSuppliers");
            this.cbSuppliers.DropDownHeight = 50;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Name = "cbSuppliers";
            // 
            // mcDeliveryDate
            // 
            resources.ApplyResources(this.mcDeliveryDate, "mcDeliveryDate");
            this.mcDeliveryDate.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.mcDeliveryDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.mcDeliveryDate.Name = "mcDeliveryDate";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApplyFilter
            // 
            resources.ApplyResources(this.btnApplyFilter, "btnApplyFilter");
            this.btnApplyFilter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // pbCart
            // 
            resources.ApplyResources(this.pbCart, "pbCart");
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = global::AppAccountingSalesOE.Properties.Resources.Cart;
            this.pbCart.Name = "pbCart";
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pbMainMenu
            // 
            resources.ApplyResources(this.pbMainMenu, "pbMainMenu");
            this.pbMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pbMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMainMenu.Image = global::AppAccountingSalesOE.Properties.Resources.Menu;
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.TabStop = false;
            this.pbMainMenu.Click += new System.EventHandler(this.pbMainMenu_Click);
            // 
            // pbLanguageUA
            // 
            resources.ApplyResources(this.pbLanguageUA, "pbLanguageUA");
            this.pbLanguageUA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUA.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_UA;
            this.pbLanguageUA.Name = "pbLanguageUA";
            this.pbLanguageUA.TabStop = false;
            this.pbLanguageUA.Click += new System.EventHandler(this.pbLanguageUA_Click);
            // 
            // pbLanguageUS
            // 
            resources.ApplyResources(this.pbLanguageUS, "pbLanguageUS");
            this.pbLanguageUS.BackColor = System.Drawing.Color.SteelBlue;
            this.pbLanguageUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUS.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_USA;
            this.pbLanguageUS.Name = "pbLanguageUS";
            this.pbLanguageUS.TabStop = false;
            this.pbLanguageUS.Click += new System.EventHandler(this.pbLanguageUS_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Image = global::AppAccountingSalesOE.Properties.Resources.Phone;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // formDeliveries
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCompanyName);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.mcDeliveryDate);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnDeleteSupplies);
            this.Controls.Add(this.btnEditSupplies);
            this.Controls.Add(this.btnAddSupplies);
            this.Controls.Add(this.lbTotalAmountCart);
            this.Controls.Add(this.lbQuantityCart);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dgvSupplies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.pbLanguageUA);
            this.Controls.Add(this.pbLanguageUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formDeliveries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDeliveries_FormClosing);
            this.Load += new System.EventHandler(this.formDeliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplies)).EndInit();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMainMenu;
        private System.Windows.Forms.PictureBox pbLanguageUA;
        private System.Windows.Forms.PictureBox pbLanguageUS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSupplies;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainPage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.Label lbTotalAmountCart;
        private System.Windows.Forms.Label lbQuantityCart;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnDeleteSupplies;
        private System.Windows.Forms.Button btnEditSupplies;
        private System.Windows.Forms.Button btnAddSupplies;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.MonthCalendar mcDeliveryDate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_cost;
    }
}