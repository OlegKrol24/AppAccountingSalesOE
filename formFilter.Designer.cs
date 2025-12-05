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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFilter));
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
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbManufCountries
            // 
            resources.ApplyResources(this.cbManufCountries, "cbManufCountries");
            this.cbManufCountries.DropDownHeight = 50;
            this.cbManufCountries.FormattingEnabled = true;
            this.cbManufCountries.Name = "cbManufCountries";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
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
            // tbPriceFrom
            // 
            resources.ApplyResources(this.tbPriceFrom, "tbPriceFrom");
            this.tbPriceFrom.Name = "tbPriceFrom";
            // 
            // tbPriceTo
            // 
            resources.ApplyResources(this.tbPriceTo, "tbPriceTo");
            this.tbPriceTo.Name = "tbPriceTo";
            // 
            // clbCategories
            // 
            resources.ApplyResources(this.clbCategories, "clbCategories");
            this.clbCategories.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCategories.FormattingEnabled = true;
            this.clbCategories.Name = "clbCategories";
            // 
            // clbWarranties
            // 
            resources.ApplyResources(this.clbWarranties, "clbWarranties");
            this.clbWarranties.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clbWarranties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbWarranties.FormattingEnabled = true;
            this.clbWarranties.Name = "clbWarranties";
            // 
            // formFilter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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