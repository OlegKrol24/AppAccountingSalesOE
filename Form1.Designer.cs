namespace AppAccountingSalesOE
{
    partial class formGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGoods = new System.Windows.Forms.Button();
            this.btnEditGoods = new System.Windows.Forms.Button();
            this.btnDeleteGoods = new System.Windows.Forms.Button();
            this.lvGoods = new System.Windows.Forms.ListView();
            this.btnFilterGoods = new System.Windows.Forms.Button();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSupplies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.name_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturing_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pbLanguageUA = new System.Windows.Forms.PictureBox();
            this.pbLanguageUS = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGoods
            // 
            this.dgvGoods.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_goods,
            this.category,
            this.manufacturing_country,
            this.price});
            this.dgvGoods.Location = new System.Drawing.Point(29, 152);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            this.dgvGoods.RowHeadersWidth = 51;
            this.dgvGoods.RowTemplate.Height = 24;
            this.dgvGoods.Size = new System.Drawing.Size(781, 552);
            this.dgvGoods.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(400, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "012 345 67 89";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "Товари";
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddGoods.Location = new System.Drawing.Point(283, 95);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(130, 43);
            this.btnAddGoods.TabIndex = 27;
            this.btnAddGoods.Text = "Додати";
            this.btnAddGoods.UseVisualStyleBackColor = false;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnEditGoods
            // 
            this.btnEditGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditGoods.Location = new System.Drawing.Point(463, 95);
            this.btnEditGoods.Name = "btnEditGoods";
            this.btnEditGoods.Size = new System.Drawing.Size(130, 43);
            this.btnEditGoods.TabIndex = 28;
            this.btnEditGoods.Text = "Редагувати";
            this.btnEditGoods.UseVisualStyleBackColor = false;
            this.btnEditGoods.Click += new System.EventHandler(this.btnEditGoods_Click);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteGoods.Location = new System.Drawing.Point(643, 95);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.Size = new System.Drawing.Size(130, 43);
            this.btnDeleteGoods.TabIndex = 29;
            this.btnDeleteGoods.Text = "Видалити";
            this.btnDeleteGoods.UseVisualStyleBackColor = false;
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // lvGoods
            // 
            this.lvGoods.HideSelection = false;
            this.lvGoods.Location = new System.Drawing.Point(829, 152);
            this.lvGoods.Name = "lvGoods";
            this.lvGoods.Size = new System.Drawing.Size(464, 551);
            this.lvGoods.TabIndex = 30;
            this.lvGoods.UseCompatibleStateImageBehavior = false;
            // 
            // btnFilterGoods
            // 
            this.btnFilterGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFilterGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilterGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFilterGoods.Location = new System.Drawing.Point(45, 95);
            this.btnFilterGoods.Name = "btnFilterGoods";
            this.btnFilterGoods.Size = new System.Drawing.Size(130, 43);
            this.btnFilterGoods.TabIndex = 31;
            this.btnFilterGoods.Text = "Фільтрація";
            this.btnFilterGoods.UseVisualStyleBackColor = false;
            this.btnFilterGoods.Click += new System.EventHandler(this.btnFilterGoods_Click);
            // 
            // msMainMenu
            // 
            this.msMainMenu.AutoSize = false;
            this.msMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.msMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainPage,
            this.tsmiCustomers,
            this.tsmiSales,
            this.tsmiSupplies,
            this.tsmiReports});
            this.msMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMainMenu.Location = new System.Drawing.Point(1145, 74);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(156, 260);
            this.msMainMenu.TabIndex = 32;
            this.msMainMenu.Text = "menuStrip1";
            this.msMainMenu.Visible = false;
            // 
            // tsmiMainPage
            // 
            this.tsmiMainPage.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiMainPage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiMainPage.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.tsmiMainPage.Name = "tsmiMainPage";
            this.tsmiMainPage.Size = new System.Drawing.Size(142, 29);
            this.tsmiMainPage.Text = "Головна";
            this.tsmiMainPage.Click += new System.EventHandler(this.tsmiMainPage_Click);
            // 
            // tsmiCustomers
            // 
            this.tsmiCustomers.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiCustomers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiCustomers.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiCustomers.Name = "tsmiCustomers";
            this.tsmiCustomers.Size = new System.Drawing.Size(142, 29);
            this.tsmiCustomers.Text = "Клієнти";
            this.tsmiCustomers.Click += new System.EventHandler(this.tsmiCustomers_Click);
            // 
            // tsmiSales
            // 
            this.tsmiSales.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiSales.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiSales.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Size = new System.Drawing.Size(142, 29);
            this.tsmiSales.Text = "Продажі";
            this.tsmiSales.Click += new System.EventHandler(this.tsmiSales_Click);
            // 
            // tsmiSupplies
            // 
            this.tsmiSupplies.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiSupplies.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiSupplies.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiSupplies.Name = "tsmiSupplies";
            this.tsmiSupplies.Size = new System.Drawing.Size(142, 29);
            this.tsmiSupplies.Text = "Поставки";
            this.tsmiSupplies.Click += new System.EventHandler(this.tsmiSupplies_Click);
            // 
            // tsmiReports
            // 
            this.tsmiReports.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiReports.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiReports.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(142, 29);
            this.tsmiReports.Text = "Звіти";
            this.tsmiReports.Click += new System.EventHandler(this.tsmiReports_Click);
            // 
            // name_goods
            // 
            this.name_goods.HeaderText = "Назва товару";
            this.name_goods.MinimumWidth = 6;
            this.name_goods.Name = "name_goods";
            this.name_goods.ReadOnly = true;
            this.name_goods.Width = 240;
            // 
            // category
            // 
            this.category.HeaderText = "Категорія";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 200;
            // 
            // manufacturing_country
            // 
            this.manufacturing_country.HeaderText = "Країна виробник";
            this.manufacturing_country.MinimumWidth = 6;
            this.manufacturing_country.Name = "manufacturing_country";
            this.manufacturing_country.ReadOnly = true;
            this.manufacturing_country.Width = 115;
            // 
            // price
            // 
            this.price.HeaderText = "Ціна";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 70;
            // 
            // pbMainMenu
            // 
            this.pbMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pbMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMainMenu.Image = global::AppAccountingSalesOE.Properties.Resources.Menu;
            this.pbMainMenu.Location = new System.Drawing.Point(1187, 1);
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.Size = new System.Drawing.Size(74, 70);
            this.pbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainMenu.TabIndex = 24;
            this.pbMainMenu.TabStop = false;
            this.pbMainMenu.Click += new System.EventHandler(this.pbMainMenu_Click);
            // 
            // pbCart
            // 
            this.pbCart.BackColor = System.Drawing.Color.SteelBlue;
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = global::AppAccountingSalesOE.Properties.Resources.Cart;
            this.pbCart.Location = new System.Drawing.Point(917, 8);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(56, 55);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCart.TabIndex = 23;
            this.pbCart.TabStop = false;
            // 
            // pbLanguageUA
            // 
            this.pbLanguageUA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUA.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_UA;
            this.pbLanguageUA.Location = new System.Drawing.Point(746, 9);
            this.pbLanguageUA.Name = "pbLanguageUA";
            this.pbLanguageUA.Size = new System.Drawing.Size(91, 53);
            this.pbLanguageUA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLanguageUA.TabIndex = 22;
            this.pbLanguageUA.TabStop = false;
            // 
            // pbLanguageUS
            // 
            this.pbLanguageUS.BackColor = System.Drawing.Color.SteelBlue;
            this.pbLanguageUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUS.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_USA;
            this.pbLanguageUS.Location = new System.Drawing.Point(606, 9);
            this.pbLanguageUS.Name = "pbLanguageUS";
            this.pbLanguageUS.Size = new System.Drawing.Size(91, 53);
            this.pbLanguageUS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLanguageUS.TabIndex = 21;
            this.pbLanguageUS.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Image = global::AppAccountingSalesOE.Properties.Resources.Phone;
            this.pictureBox4.Location = new System.Drawing.Point(318, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1309, 81);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // formGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 753);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.btnFilterGoods);
            this.Controls.Add(this.lvGoods);
            this.Controls.Add(this.btnDeleteGoods);
            this.Controls.Add(this.btnEditGoods);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pbLanguageUA);
            this.Controls.Add(this.pbLanguageUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvGoods);
            this.Name = "formGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сторінка з товарами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGoods_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.PictureBox pbMainMenu;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pbLanguageUA;
        private System.Windows.Forms.PictureBox pbLanguageUS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddGoods;
        private System.Windows.Forms.Button btnEditGoods;
        private System.Windows.Forms.Button btnDeleteGoods;
        private System.Windows.Forms.ListView lvGoods;
        private System.Windows.Forms.Button btnFilterGoods;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiSupplies;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturing_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

