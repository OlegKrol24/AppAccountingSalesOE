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
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Поставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(400, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "012 345 67 89";
            // 
            // dgvSupplies
            // 
            this.dgvSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSupplies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSupplies.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.dgvSupplies.Location = new System.Drawing.Point(20, 167);
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
            this.dgvSupplies.RowHeadersWidth = 51;
            this.dgvSupplies.RowTemplate.Height = 24;
            this.dgvSupplies.Size = new System.Drawing.Size(947, 561);
            this.dgvSupplies.TabIndex = 34;
            // 
            // Delivery_date
            // 
            this.Delivery_date.HeaderText = "Дата постачання";
            this.Delivery_date.MinimumWidth = 6;
            this.Delivery_date.Name = "Delivery_date";
            this.Delivery_date.ReadOnly = true;
            this.Delivery_date.Width = 174;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Постачальник";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 169;
            // 
            // Company_name
            // 
            this.Company_name.HeaderText = "Назва компанії";
            this.Company_name.MinimumWidth = 6;
            this.Company_name.Name = "Company_name";
            this.Company_name.ReadOnly = true;
            this.Company_name.Width = 163;
            // 
            // Total_cost
            // 
            this.Total_cost.HeaderText = "Загальна вартість";
            this.Total_cost.MinimumWidth = 6;
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.ReadOnly = true;
            this.Total_cost.Width = 182;
            // 
            // msMainMenu
            // 
            this.msMainMenu.AutoSize = false;
            this.msMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.msMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainPage,
            this.tsmiGoods,
            this.tsmiCustomers,
            this.tsmiSales,
            this.tsmiReports});
            this.msMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMainMenu.Location = new System.Drawing.Point(1147, 74);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(156, 260);
            this.msMainMenu.TabIndex = 35;
            this.msMainMenu.Text = "menuStrip1";
            this.msMainMenu.Visible = false;
            // 
            // tsmiMainPage
            // 
            this.tsmiMainPage.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiMainPage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.tsmiMainPage.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.tsmiMainPage.Name = "tsmiMainPage";
            this.tsmiMainPage.Size = new System.Drawing.Size(144, 29);
            this.tsmiMainPage.Text = "Головна";
            this.tsmiMainPage.Click += new System.EventHandler(this.tsmiMainPage_Click);
            // 
            // tsmiGoods
            // 
            this.tsmiGoods.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiGoods.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.tsmiGoods.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiGoods.Name = "tsmiGoods";
            this.tsmiGoods.Size = new System.Drawing.Size(144, 29);
            this.tsmiGoods.Text = "Товари";
            this.tsmiGoods.Click += new System.EventHandler(this.tsmiGoods_Click);
            // 
            // tsmiCustomers
            // 
            this.tsmiCustomers.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiCustomers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.tsmiCustomers.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiCustomers.Name = "tsmiCustomers";
            this.tsmiCustomers.Size = new System.Drawing.Size(144, 29);
            this.tsmiCustomers.Text = "Клієнти";
            this.tsmiCustomers.Click += new System.EventHandler(this.tsmiCustomers_Click);
            // 
            // tsmiSales
            // 
            this.tsmiSales.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiSales.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.tsmiSales.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Size = new System.Drawing.Size(144, 29);
            this.tsmiSales.Text = "Продажі";
            this.tsmiSales.Click += new System.EventHandler(this.tsmiSales_Click);
            // 
            // tsmiReports
            // 
            this.tsmiReports.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiReports.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.tsmiReports.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(144, 29);
            this.tsmiReports.Text = "Звіти";
            this.tsmiReports.Click += new System.EventHandler(this.tsmiReports_Click);
            // 
            // lbTotalAmountCart
            // 
            this.lbTotalAmountCart.AutoSize = true;
            this.lbTotalAmountCart.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbTotalAmountCart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotalAmountCart.Location = new System.Drawing.Point(972, 43);
            this.lbTotalAmountCart.Name = "lbTotalAmountCart";
            this.lbTotalAmountCart.Size = new System.Drawing.Size(45, 19);
            this.lbTotalAmountCart.TabIndex = 39;
            this.lbTotalAmountCart.Text = "0 грн";
            this.lbTotalAmountCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQuantityCart
            // 
            this.lbQuantityCart.AutoSize = true;
            this.lbQuantityCart.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbQuantityCart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbQuantityCart.Location = new System.Drawing.Point(972, 13);
            this.lbQuantityCart.Name = "lbQuantityCart";
            this.lbQuantityCart.Size = new System.Drawing.Size(42, 19);
            this.lbQuantityCart.TabIndex = 38;
            this.lbQuantityCart.Text = "0 шт";
            this.lbQuantityCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteSupplies
            // 
            this.btnDeleteSupplies.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSupplies.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSupplies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteSupplies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteSupplies.Location = new System.Drawing.Point(820, 100);
            this.btnDeleteSupplies.Name = "btnDeleteSupplies";
            this.btnDeleteSupplies.Size = new System.Drawing.Size(130, 43);
            this.btnDeleteSupplies.TabIndex = 42;
            this.btnDeleteSupplies.Text = "Видалити";
            this.btnDeleteSupplies.UseVisualStyleBackColor = false;
            this.btnDeleteSupplies.Click += new System.EventHandler(this.btnDeleteSupplies_Click);
            // 
            // btnEditSupplies
            // 
            this.btnEditSupplies.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSupplies.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEditSupplies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditSupplies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditSupplies.Location = new System.Drawing.Point(660, 100);
            this.btnEditSupplies.Name = "btnEditSupplies";
            this.btnEditSupplies.Size = new System.Drawing.Size(130, 43);
            this.btnEditSupplies.TabIndex = 41;
            this.btnEditSupplies.Text = "Редагувати";
            this.btnEditSupplies.UseVisualStyleBackColor = false;
            this.btnEditSupplies.Click += new System.EventHandler(this.btnEditSupplies_Click);
            // 
            // btnAddSupplies
            // 
            this.btnAddSupplies.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplies.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddSupplies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddSupplies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddSupplies.Location = new System.Drawing.Point(500, 100);
            this.btnAddSupplies.Name = "btnAddSupplies";
            this.btnAddSupplies.Size = new System.Drawing.Size(130, 43);
            this.btnAddSupplies.TabIndex = 40;
            this.btnAddSupplies.Text = "Додати";
            this.btnAddSupplies.UseVisualStyleBackColor = false;
            this.btnAddSupplies.Click += new System.EventHandler(this.btnAddSupplies_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSuppliers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSuppliers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSuppliers.Location = new System.Drawing.Point(29, 100);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(176, 43);
            this.btnSuppliers.TabIndex = 43;
            this.btnSuppliers.Text = "Постачальники";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(1021, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 56;
            this.label7.Text = "За назвою компанії:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(1021, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "За постачальником:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1021, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "За датою постачання:";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.DropDownHeight = 50;
            this.cbCompanyName.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.IntegralHeight = false;
            this.cbCompanyName.Location = new System.Drawing.Point(991, 587);
            this.cbCompanyName.MaxDropDownItems = 5;
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(299, 27);
            this.cbCompanyName.TabIndex = 53;
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DropDownHeight = 50;
            this.cbSuppliers.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.IntegralHeight = false;
            this.cbSuppliers.Location = new System.Drawing.Point(991, 484);
            this.cbSuppliers.MaxDropDownItems = 5;
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(299, 27);
            this.cbSuppliers.TabIndex = 52;
            // 
            // mcDeliveryDate
            // 
            this.mcDeliveryDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mcDeliveryDate.Location = new System.Drawing.Point(1025, 205);
            this.mcDeliveryDate.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.mcDeliveryDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.mcDeliveryDate.Name = "mcDeliveryDate";
            this.mcDeliveryDate.TabIndex = 51;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(1155, 676);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 49);
            this.btnReset.TabIndex = 58;
            this.btnReset.Text = "Скинути";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyFilter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnApplyFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApplyFilter.Location = new System.Drawing.Point(991, 676);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(135, 49);
            this.btnApplyFilter.TabIndex = 57;
            this.btnApplyFilter.Text = "Пошук";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // pbCart
            // 
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = global::AppAccountingSalesOE.Properties.Resources.Cart;
            this.pbCart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbCart.Location = new System.Drawing.Point(855, 8);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(56, 55);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCart.TabIndex = 37;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox7.Location = new System.Drawing.Point(850, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(298, 63);
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            // 
            // pbMainMenu
            // 
            this.pbMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pbMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMainMenu.Image = global::AppAccountingSalesOE.Properties.Resources.Menu;
            this.pbMainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbMainMenu.Location = new System.Drawing.Point(1187, 1);
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.Size = new System.Drawing.Size(74, 70);
            this.pbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainMenu.TabIndex = 32;
            this.pbMainMenu.TabStop = false;
            this.pbMainMenu.Click += new System.EventHandler(this.pbMainMenu_Click);
            // 
            // pbLanguageUA
            // 
            this.pbLanguageUA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUA.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_UA;
            this.pbLanguageUA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLanguageUA.Location = new System.Drawing.Point(710, 9);
            this.pbLanguageUA.Name = "pbLanguageUA";
            this.pbLanguageUA.Size = new System.Drawing.Size(91, 53);
            this.pbLanguageUA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLanguageUA.TabIndex = 30;
            this.pbLanguageUA.TabStop = false;
            // 
            // pbLanguageUS
            // 
            this.pbLanguageUS.BackColor = System.Drawing.Color.SteelBlue;
            this.pbLanguageUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUS.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_USA;
            this.pbLanguageUS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLanguageUS.Location = new System.Drawing.Point(580, 9);
            this.pbLanguageUS.Name = "pbLanguageUS";
            this.pbLanguageUS.Size = new System.Drawing.Size(91, 53);
            this.pbLanguageUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLanguageUS.TabIndex = 29;
            this.pbLanguageUS.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Image = global::AppAccountingSalesOE.Properties.Resources.Phone;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(318, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1309, 81);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // formDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 753);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставки";
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