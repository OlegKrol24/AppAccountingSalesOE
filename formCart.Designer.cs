namespace AppAccountingSalesOE
{
    partial class formCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSupplies = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.pbLanguageUA = new System.Windows.Forms.PictureBox();
            this.pbLanguageUS = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deletion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
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
            // dgvCart
            // 
            resources.ApplyResources(this.dgvCart, "dgvCart");
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Goods,
            this.Price,
            this.Quantity,
            this.Total_price,
            this.Deletion});
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            this.dgvCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // lbTotalAmount
            // 
            resources.ApplyResources(this.lbTotalAmount, "lbTotalAmount");
            this.lbTotalAmount.Name = "lbTotalAmount";
            // 
            // btnContinueShopping
            // 
            resources.ApplyResources(this.btnContinueShopping, "btnContinueShopping");
            this.btnContinueShopping.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnContinueShopping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueShopping.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.UseVisualStyleBackColor = false;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnBuy
            // 
            resources.ApplyResources(this.btnBuy, "btnBuy");
            this.btnBuy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            // tsmiSales
            // 
            resources.ApplyResources(this.tsmiSales, "tsmiSales");
            this.tsmiSales.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiSales.Margin = new System.Windows.Forms.Padding(0, 15, 5, 0);
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Click += new System.EventHandler(this.tsmiSales_Click);
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
            // pbAdd
            // 
            resources.ApplyResources(this.pbAdd, "pbAdd");
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::AppAccountingSalesOE.Properties.Resources.Add;
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDelete
            // 
            resources.ApplyResources(this.pbDelete, "pbDelete");
            this.pbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDelete.Image = global::AppAccountingSalesOE.Properties.Resources.Minus;
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // pbCart
            // 
            resources.ApplyResources(this.pbCart, "pbCart");
            this.pbCart.Image = global::AppAccountingSalesOE.Properties.Resources.Cart;
            this.pbCart.Name = "pbCart";
            this.pbCart.TabStop = false;
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
            // Goods
            // 
            resources.ApplyResources(this.Goods, "Goods");
            this.Goods.Name = "Goods";
            this.Goods.ReadOnly = true;
            // 
            // Price
            // 
            resources.ApplyResources(this.Price, "Price");
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            resources.ApplyResources(this.Quantity, "Quantity");
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Total_price
            // 
            resources.ApplyResources(this.Total_price, "Total_price");
            this.Total_price.Name = "Total_price";
            this.Total_price.ReadOnly = true;
            // 
            // Deletion
            // 
            resources.ApplyResources(this.Deletion, "Deletion");
            this.Deletion.Name = "Deletion";
            this.Deletion.ReadOnly = true;
            this.Deletion.Text = "Видалити";
            // 
            // formCart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnContinueShopping);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.pbLanguageUA);
            this.Controls.Add(this.pbLanguageUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formCart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCart_FormClosing);
            this.Load += new System.EventHandler(this.formCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainPage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiSupplies;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
        private System.Windows.Forms.DataGridViewButtonColumn Deletion;
    }
}