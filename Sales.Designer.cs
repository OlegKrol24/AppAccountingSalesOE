namespace AppAccountingSalesOE
{
    partial class formSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSupplies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTotalAmountCart = new System.Windows.Forms.Label();
            this.lbQuantityCart = new System.Windows.Forms.Label();
            this.mcSaleDate = new System.Windows.Forms.MonthCalendar();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.pbLanguageUA = new System.Windows.Forms.PictureBox();
            this.pbLanguageUS = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sale_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name_customers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
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
            // dgvSales
            // 
            resources.ApplyResources(this.dgvSales, "dgvSales");
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sale_date,
            this.Full_name_customers,
            this.Full_name_employee,
            this.Total_amount});
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSales.RowTemplate.Height = 24;
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
            this.tsmiSupplies,
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
            // tsmiSupplies
            // 
            resources.ApplyResources(this.tsmiSupplies, "tsmiSupplies");
            this.tsmiSupplies.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiSupplies.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiSupplies.Name = "tsmiSupplies";
            this.tsmiSupplies.Click += new System.EventHandler(this.tsmiSupplies_Click);
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
            // mcSaleDate
            // 
            resources.ApplyResources(this.mcSaleDate, "mcSaleDate");
            this.mcSaleDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.mcSaleDate.Name = "mcSaleDate";
            // 
            // cbCustomers
            // 
            resources.ApplyResources(this.cbCustomers, "cbCustomers");
            this.cbCustomers.DropDownHeight = 50;
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Name = "cbCustomers";
            // 
            // cbEmployees
            // 
            resources.ApplyResources(this.cbEmployees, "cbEmployees");
            this.cbEmployees.DropDownHeight = 50;
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Name = "cbEmployees";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
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
            // 
            // pbLanguageUS
            // 
            resources.ApplyResources(this.pbLanguageUS, "pbLanguageUS");
            this.pbLanguageUS.BackColor = System.Drawing.Color.SteelBlue;
            this.pbLanguageUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUS.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_USA;
            this.pbLanguageUS.Name = "pbLanguageUS";
            this.pbLanguageUS.TabStop = false;
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
            // Sale_date
            // 
            resources.ApplyResources(this.Sale_date, "Sale_date");
            this.Sale_date.Name = "Sale_date";
            this.Sale_date.ReadOnly = true;
            // 
            // Full_name_customers
            // 
            resources.ApplyResources(this.Full_name_customers, "Full_name_customers");
            this.Full_name_customers.Name = "Full_name_customers";
            this.Full_name_customers.ReadOnly = true;
            // 
            // Full_name_employee
            // 
            resources.ApplyResources(this.Full_name_employee, "Full_name_employee");
            this.Full_name_employee.Name = "Full_name_employee";
            this.Full_name_employee.ReadOnly = true;
            // 
            // Total_amount
            // 
            resources.ApplyResources(this.Total_amount, "Total_amount");
            this.Total_amount.Name = "Total_amount";
            this.Total_amount.ReadOnly = true;
            // 
            // formSales
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
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.mcSaleDate);
            this.Controls.Add(this.lbTotalAmountCart);
            this.Controls.Add(this.lbQuantityCart);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.pbLanguageUA);
            this.Controls.Add(this.pbLanguageUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formSales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSales_FormClosing);
            this.Load += new System.EventHandler(this.formSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainPage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiSupplies;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.Label lbTotalAmountCart;
        private System.Windows.Forms.Label lbQuantityCart;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.MonthCalendar mcSaleDate;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name_customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_amount;
    }
}