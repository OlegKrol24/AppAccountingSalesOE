namespace AppAccountingSalesOE
{
    partial class formFilter
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbManufCountries = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.tbPriceFrom = new System.Windows.Forms.TextBox();
            this.tbPriceTo = new System.Windows.Forms.TextBox();
            this.clbCategories = new System.Windows.Forms.CheckedListBox();
            this.clbWarranties = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(53, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Категорія";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(53, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(225, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Від";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(491, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Країна виробник";
            // 
            // cbManufCountries
            // 
            this.cbManufCountries.DropDownHeight = 50;
            this.cbManufCountries.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbManufCountries.FormattingEnabled = true;
            this.cbManufCountries.IntegralHeight = false;
            this.cbManufCountries.Location = new System.Drawing.Point(495, 108);
            this.cbManufCountries.Name = "cbManufCountries";
            this.cbManufCountries.Size = new System.Drawing.Size(195, 27);
            this.cbManufCountries.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(491, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Гарантія (міс.)";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyFilter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnApplyFilter.Location = new System.Drawing.Point(535, 486);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(155, 56);
            this.btnApplyFilter.TabIndex = 58;
            this.btnApplyFilter.Text = "Застосувати";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // tbPriceFrom
            // 
            this.tbPriceFrom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbPriceFrom.Location = new System.Drawing.Point(104, 110);
            this.tbPriceFrom.Name = "tbPriceFrom";
            this.tbPriceFrom.Size = new System.Drawing.Size(98, 27);
            this.tbPriceFrom.TabIndex = 60;
            // 
            // tbPriceTo
            // 
            this.tbPriceTo.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbPriceTo.Location = new System.Drawing.Point(279, 110);
            this.tbPriceTo.Name = "tbPriceTo";
            this.tbPriceTo.Size = new System.Drawing.Size(98, 27);
            this.tbPriceTo.TabIndex = 61;
            // 
            // clbCategories
            // 
            this.clbCategories.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCategories.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Location = new System.Drawing.Point(57, 263);
            this.clbCategories.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.clbCategories.Name = "clbCategories";
            this.clbCategories.Size = new System.Drawing.Size(374, 264);
            this.clbCategories.TabIndex = 62;
            // 
            // clbWarranties
            // 
            this.clbWarranties.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbWarranties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbWarranties.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.clbWarranties.FormattingEnabled = true;
            this.clbWarranties.Location = new System.Drawing.Point(495, 263);
            this.clbWarranties.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.clbWarranties.Name = "clbWarranties";
            this.clbWarranties.Size = new System.Drawing.Size(195, 110);
            this.clbWarranties.TabIndex = 63;
            // 
            // formFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 569);
            this.Controls.Add(this.clbWarranties);
            this.Controls.Add(this.clbCategories);
            this.Controls.Add(this.tbPriceTo);
            this.Controls.Add(this.tbPriceFrom);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbManufCountries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "formFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фільтрація";
            this.Load += new System.EventHandler(this.formFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbManufCountries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.TextBox tbPriceFrom;
        private System.Windows.Forms.TextBox tbPriceTo;
        private System.Windows.Forms.CheckedListBox clbCategories;
        private System.Windows.Forms.CheckedListBox clbWarranties;
    }
}