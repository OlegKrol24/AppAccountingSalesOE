namespace AppAccountingSalesOE
{
    partial class formReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSupplies = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReportExcel = new System.Windows.Forms.Button();
            this.btnReportWord = new System.Windows.Forms.Button();
            this.lbTotalAmountCart = new System.Windows.Forms.Label();
            this.lbQuantityCart = new System.Windows.Forms.Label();
            this.rbGoods = new System.Windows.Forms.RadioButton();
            this.rbCustomers = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbSupplies = new System.Windows.Forms.RadioButton();
            this.mcReportDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbMainMenu = new System.Windows.Forms.PictureBox();
            this.pbLanguageUA = new System.Windows.Forms.PictureBox();
            this.pbLanguageUS = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
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
            // dgvReport
            // 
            resources.ApplyResources(this.dgvReport, "dgvReport");
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.RowTemplate.Height = 24;
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
            this.tsmiSupplies});
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
            // btnReportExcel
            // 
            resources.ApplyResources(this.btnReportExcel, "btnReportExcel");
            this.btnReportExcel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportExcel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReportExcel.Name = "btnReportExcel";
            this.btnReportExcel.UseVisualStyleBackColor = false;
            this.btnReportExcel.Click += new System.EventHandler(this.btnReportExcel_Click);
            // 
            // btnReportWord
            // 
            resources.ApplyResources(this.btnReportWord, "btnReportWord");
            this.btnReportWord.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReportWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportWord.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReportWord.Name = "btnReportWord";
            this.btnReportWord.UseVisualStyleBackColor = false;
            this.btnReportWord.Click += new System.EventHandler(this.btnReportWord_Click);
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
            // rbGoods
            // 
            resources.ApplyResources(this.rbGoods, "rbGoods");
            this.rbGoods.Checked = true;
            this.rbGoods.Name = "rbGoods";
            this.rbGoods.TabStop = true;
            this.rbGoods.UseVisualStyleBackColor = true;
            // 
            // rbCustomers
            // 
            resources.ApplyResources(this.rbCustomers, "rbCustomers");
            this.rbCustomers.Name = "rbCustomers";
            this.rbCustomers.TabStop = true;
            this.rbCustomers.UseVisualStyleBackColor = true;
            // 
            // rbSales
            // 
            resources.ApplyResources(this.rbSales, "rbSales");
            this.rbSales.Name = "rbSales";
            this.rbSales.TabStop = true;
            this.rbSales.UseVisualStyleBackColor = true;
            // 
            // rbSupplies
            // 
            resources.ApplyResources(this.rbSupplies, "rbSupplies");
            this.rbSupplies.Name = "rbSupplies";
            this.rbSupplies.TabStop = true;
            this.rbSupplies.UseVisualStyleBackColor = true;
            // 
            // mcReportDate
            // 
            resources.ApplyResources(this.mcReportDate, "mcReportDate");
            this.mcReportDate.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.mcReportDate.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.mcReportDate.Name = "mcReportDate";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnGenerateReport
            // 
            resources.ApplyResources(this.btnGenerateReport, "btnGenerateReport");
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // formReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mcReportDate);
            this.Controls.Add(this.rbSupplies);
            this.Controls.Add(this.rbSales);
            this.Controls.Add(this.rbCustomers);
            this.Controls.Add(this.rbGoods);
            this.Controls.Add(this.lbTotalAmountCart);
            this.Controls.Add(this.lbQuantityCart);
            this.Controls.Add(this.pbCart);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnReportWord);
            this.Controls.Add(this.btnReportExcel);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMainMenu);
            this.Controls.Add(this.pbLanguageUA);
            this.Controls.Add(this.pbLanguageUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formReport_FormClosing);
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainPage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoods;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiSupplies;
        private System.Windows.Forms.ToolStripMenuItem tsmiCustomers;
        private System.Windows.Forms.Button btnReportExcel;
        private System.Windows.Forms.Button btnReportWord;
        private System.Windows.Forms.Label lbTotalAmountCart;
        private System.Windows.Forms.Label lbQuantityCart;
        private System.Windows.Forms.PictureBox pbCart;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.RadioButton rbGoods;
        private System.Windows.Forms.RadioButton rbCustomers;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbSupplies;
        private System.Windows.Forms.MonthCalendar mcReportDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnUpdate;
    }
}