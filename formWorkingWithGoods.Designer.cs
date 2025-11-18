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
            this.pbImageGoods = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbImageGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(335, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbImageGoods
            // 
            this.pbImageGoods.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbImageGoods.Location = new System.Drawing.Point(39, 26);
            this.pbImageGoods.Name = "pbImageGoods";
            this.pbImageGoods.Size = new System.Drawing.Size(217, 270);
            this.pbImageGoods.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageGoods.TabIndex = 1;
            this.pbImageGoods.TabStop = false;
            // 
            // lbNameGoods
            // 
            this.lbNameGoods.AutoSize = true;
            this.lbNameGoods.Location = new System.Drawing.Point(316, 39);
            this.lbNameGoods.Name = "lbNameGoods";
            this.lbNameGoods.Size = new System.Drawing.Size(99, 16);
            this.lbNameGoods.TabIndex = 2;
            this.lbNameGoods.Text = "Назва товару";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(316, 92);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(70, 16);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "Категорія";
            // 
            // lbManufacturingCountry
            // 
            this.lbManufacturingCountry.AutoSize = true;
            this.lbManufacturingCountry.Location = new System.Drawing.Point(316, 147);
            this.lbManufacturingCountry.Name = "lbManufacturingCountry";
            this.lbManufacturingCountry.Size = new System.Drawing.Size(116, 16);
            this.lbManufacturingCountry.TabIndex = 4;
            this.lbManufacturingCountry.Text = "Країна виробник";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(316, 201);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(35, 16);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Ціна";
            // 
            // lbWarrantyMonths
            // 
            this.lbWarrantyMonths.AutoSize = true;
            this.lbWarrantyMonths.Location = new System.Drawing.Point(316, 255);
            this.lbWarrantyMonths.Name = "lbWarrantyMonths";
            this.lbWarrantyMonths.Size = new System.Drawing.Size(96, 16);
            this.lbWarrantyMonths.TabIndex = 6;
            this.lbWarrantyMonths.Text = "Гарантія (міс.)";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(316, 309);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(40, 16);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Опис";
            // 
            // tbNameGoods
            // 
            this.tbNameGoods.Location = new System.Drawing.Point(465, 36);
            this.tbNameGoods.Name = "tbNameGoods";
            this.tbNameGoods.Size = new System.Drawing.Size(282, 22);
            this.tbNameGoods.TabIndex = 8;
            // 
            // tbManufacturingCountry
            // 
            this.tbManufacturingCountry.Location = new System.Drawing.Point(465, 144);
            this.tbManufacturingCountry.Name = "tbManufacturingCountry";
            this.tbManufacturingCountry.Size = new System.Drawing.Size(282, 22);
            this.tbManufacturingCountry.TabIndex = 9;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(465, 198);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(131, 22);
            this.tbPrice.TabIndex = 10;
            // 
            // cbCategory
            // 
            this.cbCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(465, 84);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(282, 24);
            this.cbCategory.TabIndex = 11;
            // 
            // cbWarrantyMonths
            // 
            this.cbWarrantyMonths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbWarrantyMonths.FormattingEnabled = true;
            this.cbWarrantyMonths.Location = new System.Drawing.Point(465, 252);
            this.cbWarrantyMonths.Name = "cbWarrantyMonths";
            this.cbWarrantyMonths.Size = new System.Drawing.Size(112, 24);
            this.cbWarrantyMonths.TabIndex = 12;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(385, 309);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(385, 95);
            this.rtbDescription.TabIndex = 13;
            this.rtbDescription.Text = "";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseImage.Location = new System.Drawing.Point(85, 323);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(125, 43);
            this.btnChooseImage.TabIndex = 14;
            this.btnChooseImage.Text = "Обрати фото";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "Image";
            // 
            // formWorkingWithGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 491);
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
    }
}