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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGoods));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.name_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturing_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbSearching = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttGoods = new System.Windows.Forms.ToolTip(this.components);
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.pbLanguageUA = new System.Windows.Forms.PictureBox();
            this.pbLanguageUS = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLanguageUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGoods
            // 
            resources.ApplyResources(this.dgvGoods, "dgvGoods");
            this.dgvGoods.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_goods,
            this.manufacturing_country,
            this.category});
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGoods.RowTemplate.Height = 24;
            this.dgvGoods.ShowCellToolTips = false;
            this.ttGoods.SetToolTip(this.dgvGoods, resources.GetString("dgvGoods.ToolTip"));
            this.dgvGoods.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGoods_CellMouseMove);
            // 
            // name_goods
            // 
            this.name_goods.Frozen = true;
            resources.ApplyResources(this.name_goods, "name_goods");
            this.name_goods.Name = "name_goods";
            this.name_goods.ReadOnly = true;
            // 
            // manufacturing_country
            // 
            resources.ApplyResources(this.manufacturing_country, "manufacturing_country");
            this.manufacturing_country.Name = "manufacturing_country";
            this.manufacturing_country.ReadOnly = true;
            // 
            // category
            // 
            resources.ApplyResources(this.category, "category");
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Name = "label5";
            this.ttGoods.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            this.ttGoods.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnAddGoods
            // 
            resources.ApplyResources(this.btnAddGoods, "btnAddGoods");
            this.btnAddGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddGoods.Name = "btnAddGoods";
            this.ttGoods.SetToolTip(this.btnAddGoods, resources.GetString("btnAddGoods.ToolTip"));
            this.btnAddGoods.UseVisualStyleBackColor = false;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // btnEditGoods
            // 
            resources.ApplyResources(this.btnEditGoods, "btnEditGoods");
            this.btnEditGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditGoods.Name = "btnEditGoods";
            this.ttGoods.SetToolTip(this.btnEditGoods, resources.GetString("btnEditGoods.ToolTip"));
            this.btnEditGoods.UseVisualStyleBackColor = false;
            this.btnEditGoods.Click += new System.EventHandler(this.btnEditGoods_Click);
            // 
            // btnDeleteGoods
            // 
            resources.ApplyResources(this.btnDeleteGoods, "btnDeleteGoods");
            this.btnDeleteGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.ttGoods.SetToolTip(this.btnDeleteGoods, resources.GetString("btnDeleteGoods.ToolTip"));
            this.btnDeleteGoods.UseVisualStyleBackColor = false;
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // lvGoods
            // 
            resources.ApplyResources(this.lvGoods, "lvGoods");
            this.lvGoods.HideSelection = false;
            this.lvGoods.Name = "lvGoods";
            this.ttGoods.SetToolTip(this.lvGoods, resources.GetString("lvGoods.ToolTip"));
            this.lvGoods.UseCompatibleStateImageBehavior = false;
            this.lvGoods.DoubleClick += new System.EventHandler(this.lvGoods_DoubleClick);
            // 
            // btnFilterGoods
            // 
            resources.ApplyResources(this.btnFilterGoods, "btnFilterGoods");
            this.btnFilterGoods.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFilterGoods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterGoods.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFilterGoods.Name = "btnFilterGoods";
            this.ttGoods.SetToolTip(this.btnFilterGoods, resources.GetString("btnFilterGoods.ToolTip"));
            this.btnFilterGoods.UseVisualStyleBackColor = false;
            this.btnFilterGoods.Click += new System.EventHandler(this.btnFilterGoods_Click);
            // 
            // msMainMenu
            // 
            resources.ApplyResources(this.msMainMenu, "msMainMenu");
            this.msMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainPage,
            this.tsmiCustomers,
            this.tsmiSales,
            this.tsmiSupplies,
            this.tsmiReports});
            this.msMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMainMenu.Name = "msMainMenu";
            this.ttGoods.SetToolTip(this.msMainMenu, resources.GetString("msMainMenu.ToolTip"));
            // 
            // tsmiMainPage
            // 
            resources.ApplyResources(this.tsmiMainPage, "tsmiMainPage");
            this.tsmiMainPage.BackColor = System.Drawing.Color.PowderBlue;
            this.tsmiMainPage.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.tsmiMainPage.Name = "tsmiMainPage";
            this.tsmiMainPage.Click += new System.EventHandler(this.tsmiMainPage_Click);
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
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Name = "btnUpdate";
            this.ttGoods.SetToolTip(this.btnUpdate, resources.GetString("btnUpdate.ToolTip"));
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbSearching
            // 
            resources.ApplyResources(this.tbSearching, "tbSearching");
            this.tbSearching.Name = "tbSearching";
            this.ttGoods.SetToolTip(this.tbSearching, resources.GetString("tbSearching.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.ttGoods.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.ttGoods.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // ttGoods
            // 
            this.ttGoods.AutoPopDelay = 6000;
            this.ttGoods.InitialDelay = 500;
            this.ttGoods.ReshowDelay = 100;
            this.ttGoods.UseAnimation = false;
            this.ttGoods.UseFading = false;
            // 
            // pbCart
            // 
            resources.ApplyResources(this.pbCart, "pbCart");
            this.pbCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCart.Image = global::AppAccountingSalesOE.Properties.Resources.Cart;
            this.pbCart.Name = "pbCart";
            this.pbCart.TabStop = false;
            this.ttGoods.SetToolTip(this.pbCart, resources.GetString("pbCart.ToolTip"));
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            this.ttGoods.SetToolTip(this.pictureBox7, resources.GetString("pictureBox7.ToolTip"));
            // 
            // pbSearch
            // 
            resources.ApplyResources(this.pbSearch, "pbSearch");
            this.pbSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearch.Image = global::AppAccountingSalesOE.Properties.Resources.Searching__2_;
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.TabStop = false;
            this.ttGoods.SetToolTip(this.pbSearch, resources.GetString("pbSearch.ToolTip"));
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // pbMainMenu
            // 
            resources.ApplyResources(this.pbMainMenu, "pbMainMenu");
            this.pbMainMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pbMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMainMenu.Image = global::AppAccountingSalesOE.Properties.Resources.Menu;
            this.pbMainMenu.Name = "pbMainMenu";
            this.pbMainMenu.TabStop = false;
            this.ttGoods.SetToolTip(this.pbMainMenu, resources.GetString("pbMainMenu.ToolTip"));
            this.pbMainMenu.Click += new System.EventHandler(this.pbMainMenu_Click);
            // 
            // pbLanguageUA
            // 
            resources.ApplyResources(this.pbLanguageUA, "pbLanguageUA");
            this.pbLanguageUA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLanguageUA.Image = global::AppAccountingSalesOE.Properties.Resources.Flag_UA;
            this.pbLanguageUA.Name = "pbLanguageUA";
            this.pbLanguageUA.TabStop = false;
            this.ttGoods.SetToolTip(this.pbLanguageUA, resources.GetString("pbLanguageUA.ToolTip"));
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
            this.ttGoods.SetToolTip(this.pbLanguageUS, resources.GetString("pbLanguageUS.ToolTip"));
            this.pbLanguageUS.Click += new System.EventHandler(this.pbLanguageUS_Click);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Image = global::AppAccountingSalesOE.Properties.Resources.Phone;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.ttGoods.SetToolTip(this.pictureBox4, resources.GetString("pictureBox4.ToolTip"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.ttGoods.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // formGoods
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.tbSearching);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.btnFilterGoods);
            this.Controls.Add(this.lvGoods);
            this.Controls.Add(this.btnDeleteGoods);
            this.Controls.Add(this.btnEditGoods);
            this.Controls.Add(this.btnAddGoods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.pbLanguageUA);
            this.Controls.Add(this.pbLanguageUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvGoods);
            this.Name = "formGoods";
            this.ttGoods.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGoods_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMenu)).EndInit();
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox tbSearching;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ToolTip ttGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturing_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
    }
}

