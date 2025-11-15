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
            this.label1 = new System.Windows.Forms.Label();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pbLanguageUA = new System.Windows.Forms.PictureBox();
            this.pbLanguageUS = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "Поставки";
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
            this.pbMainMenu.TabIndex = 32;
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
            this.pbCart.TabIndex = 31;
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
            this.pbLanguageUA.TabIndex = 30;
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
            this.pbLanguageUS.TabIndex = 29;
            this.pbLanguageUS.TabStop = false;
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
            this.label5.TabIndex = 28;
            this.label5.Text = "012 345 67 89";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Image = global::AppAccountingSalesOE.Properties.Resources.Phone;
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
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1309, 81);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supplier,
            this.Company_name,
            this.Delivery_date,
            this.Total_cost});
            this.dgvDeliveries.Location = new System.Drawing.Point(81, 160);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.RowHeadersWidth = 51;
            this.dgvDeliveries.RowTemplate.Height = 24;
            this.dgvDeliveries.Size = new System.Drawing.Size(756, 479);
            this.dgvDeliveries.TabIndex = 34;
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
            this.msMainMenu.Location = new System.Drawing.Point(1145, 74);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(156, 260);
            this.msMainMenu.TabIndex = 35;
            this.msMainMenu.Text = "menuStrip1";
            this.msMainMenu.Visible = false;
            // 
            // tsmiMainPage
            // 
            this.tsmiMainPage.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiMainPage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiMainPage.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.tsmiMainPage.Name = "tsmiMainPage";
            this.tsmiMainPage.Size = new System.Drawing.Size(144, 29);
            this.tsmiMainPage.Text = "Головна";
            this.tsmiMainPage.Click += new System.EventHandler(this.tsmiMainPage_Click);
            // 
            // tsmiGoods
            // 
            this.tsmiGoods.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiGoods.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiGoods.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiGoods.Name = "tsmiGoods";
            this.tsmiGoods.Size = new System.Drawing.Size(144, 29);
            this.tsmiGoods.Text = "Товари";
            this.tsmiGoods.Click += new System.EventHandler(this.tsmiGoods_Click);
            // 
            // tsmiCustomers
            // 
            this.tsmiCustomers.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiCustomers.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiCustomers.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiCustomers.Name = "tsmiCustomers";
            this.tsmiCustomers.Size = new System.Drawing.Size(144, 29);
            this.tsmiCustomers.Text = "Клієнти";
            this.tsmiCustomers.Click += new System.EventHandler(this.tsmiCustomers_Click);
            // 
            // tsmiSales
            // 
            this.tsmiSales.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiSales.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiSales.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Size = new System.Drawing.Size(144, 29);
            this.tsmiSales.Text = "Продажі";
            this.tsmiSales.Click += new System.EventHandler(this.tsmiSales_Click);
            // 
            // tsmiReports
            // 
            this.tsmiReports.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiReports.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmiReports.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(144, 29);
            this.tsmiReports.Text = "Звіти";
            this.tsmiReports.Click += new System.EventHandler(this.tsmiReports_Click);
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Постачальник";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 125;
            // 
            // Company_name
            // 
            this.Company_name.HeaderText = "Назва компанії";
            this.Company_name.MinimumWidth = 6;
            this.Company_name.Name = "Company_name";
            this.Company_name.ReadOnly = true;
            this.Company_name.Width = 125;
            // 
            // Delivery_date
            // 
            this.Delivery_date.HeaderText = "Дата постачання";
            this.Delivery_date.MinimumWidth = 6;
            this.Delivery_date.Name = "Delivery_date";
            this.Delivery_date.ReadOnly = true;
            this.Delivery_date.Width = 125;
            // 
            // Total_cost
            // 
            this.Total_cost.HeaderText = "Загальна вартість";
            this.Total_cost.MinimumWidth = 6;
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.ReadOnly = true;
            this.Total_cost.Width = 125;
            // 
            // formDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 753);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.dgvDeliveries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pbLanguageUA);
            this.Controls.Add(this.pbLanguageUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formDeliveries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сторінка з поставками";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDeliveries_FormClosing);
            this.Load += new System.EventHandler(this.formDeliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMainMenu;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pbLanguageUA;
        private System.Windows.Forms.PictureBox pbLanguageUS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainPage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_cost;
    }
}