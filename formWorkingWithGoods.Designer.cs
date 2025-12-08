namespace AppAccountingSalesOE
{
    partial class formWorkingWithGoods
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lbNameGoods = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbManufacturingCountry = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbWarrantyMonths = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbNameGoods = new System.Windows.Forms.TextBox();
            this.tbManufacturingCountry = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbWarrantyMonths = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbImageGoods = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(247, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbNameGoods
            // 
            this.lbNameGoods.AutoSize = true;
            this.lbNameGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbNameGoods.Location = new System.Drawing.Point(288, 38);
            this.lbNameGoods.Name = "lbNameGoods";
            this.lbNameGoods.Size = new System.Drawing.Size(101, 19);
            this.lbNameGoods.TabIndex = 2;
            this.lbNameGoods.Text = "Назва товару";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbCategory.Location = new System.Drawing.Point(288, 90);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(79, 19);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "Категорія";
            // 
            // lbManufacturingCountry
            // 
            this.lbManufacturingCountry.AutoSize = true;
            this.lbManufacturingCountry.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbManufacturingCountry.Location = new System.Drawing.Point(288, 145);
            this.lbManufacturingCountry.Name = "lbManufacturingCountry";
            this.lbManufacturingCountry.Size = new System.Drawing.Size(125, 19);
            this.lbManufacturingCountry.TabIndex = 4;
            this.lbManufacturingCountry.Text = "Країна виробник";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbPrice.Location = new System.Drawing.Point(288, 199);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 19);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Ціна";
            // 
            // lbWarrantyMonths
            // 
            this.lbWarrantyMonths.AutoSize = true;
            this.lbWarrantyMonths.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbWarrantyMonths.Location = new System.Drawing.Point(288, 253);
            this.lbWarrantyMonths.Name = "lbWarrantyMonths";
            this.lbWarrantyMonths.Size = new System.Drawing.Size(113, 19);
            this.lbWarrantyMonths.TabIndex = 6;
            this.lbWarrantyMonths.Text = "Гарантія (міс.)";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbDescription.Location = new System.Drawing.Point(288, 307);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(45, 19);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Опис";
            // 
            // tbNameGoods
            // 
            this.tbNameGoods.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbNameGoods.Location = new System.Drawing.Point(427, 34);
            this.tbNameGoods.Name = "tbNameGoods";
            this.tbNameGoods.Size = new System.Drawing.Size(361, 27);
            this.tbNameGoods.TabIndex = 8;
            // 
            // tbManufacturingCountry
            // 
            this.tbManufacturingCountry.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbManufacturingCountry.Location = new System.Drawing.Point(427, 141);
            this.tbManufacturingCountry.Name = "tbManufacturingCountry";
            this.tbManufacturingCountry.Size = new System.Drawing.Size(291, 27);
            this.tbManufacturingCountry.TabIndex = 9;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbPrice.Location = new System.Drawing.Point(427, 195);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(131, 27);
            this.tbPrice.TabIndex = 10;
            // 
            // cbCategory
            // 
            this.cbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategory.DropDownHeight = 50;
            this.cbCategory.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.IntegralHeight = false;
            this.cbCategory.Location = new System.Drawing.Point(427, 86);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(361, 27);
            this.cbCategory.TabIndex = 11;
            // 
            // cbWarrantyMonths
            // 
            this.cbWarrantyMonths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbWarrantyMonths.DropDownHeight = 50;
            this.cbWarrantyMonths.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbWarrantyMonths.FormattingEnabled = true;
            this.cbWarrantyMonths.IntegralHeight = false;
            this.cbWarrantyMonths.Location = new System.Drawing.Point(427, 249);
            this.cbWarrantyMonths.Name = "cbWarrantyMonths";
            this.cbWarrantyMonths.Size = new System.Drawing.Size(112, 27);
            this.cbWarrantyMonths.TabIndex = 12;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.rtbDescription.Location = new System.Drawing.Point(363, 307);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(425, 100);
            this.rtbDescription.TabIndex = 13;
            this.rtbDescription.Text = "";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.btnChooseImage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChooseImage.Location = new System.Drawing.Point(75, 311);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(125, 43);
            this.btnChooseImage.TabIndex = 14;
            this.btnChooseImage.Text = "Обрати фото";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "Image";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Location = new System.Drawing.Point(431, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 43);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Скинути";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pbImageGoods
            // 
            this.pbImageGoods.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbImageGoods.Location = new System.Drawing.Point(29, 42);
            this.pbImageGoods.Name = "pbImageGoods";
            this.pbImageGoods.Size = new System.Drawing.Size(217, 240);
            this.pbImageGoods.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageGoods.TabIndex = 1;
            this.pbImageGoods.TabStop = false;
            // 
            // formWorkingWithGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cbWarrantyMonths);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbManufacturingCountry);
            this.Controls.Add(this.tbNameGoods);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbWarrantyMonths);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturingCountry);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbNameGoods);
            this.Controls.Add(this.pbImageGoods);
            this.Controls.Add(this.btnSave);
            this.Name = "formWorkingWithGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання/редагування товару";
            this.Load += new System.EventHandler(this.formWorkingWithGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbNameGoods;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbManufacturingCountry;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbWarrantyMonths;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        public System.Windows.Forms.TextBox tbNameGoods;
        public System.Windows.Forms.TextBox tbManufacturingCountry;
        public System.Windows.Forms.TextBox tbPrice;
        public System.Windows.Forms.ComboBox cbCategory;
        public System.Windows.Forms.ComboBox cbWarrantyMonths;
        public System.Windows.Forms.RichTextBox rtbDescription;
        public System.Windows.Forms.PictureBox pbImageGoods;
        private System.Windows.Forms.Button btnClear;
    }
}