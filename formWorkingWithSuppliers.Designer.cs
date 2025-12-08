namespace AppAccountingSalesOE
{
    partial class formWorkingWithSuppliers
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbFullNameSupplier = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbFullNameCustomer = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbEmail.Location = new System.Drawing.Point(343, 255);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(263, 27);
            this.tbEmail.TabIndex = 28;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(343, 193);
            this.tbPhoneNumber.MaxLength = 13;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(263, 27);
            this.tbPhoneNumber.TabIndex = 27;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbCompanyName.Location = new System.Drawing.Point(343, 123);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(340, 27);
            this.tbCompanyName.TabIndex = 26;
            // 
            // tbFullNameSupplier
            // 
            this.tbFullNameSupplier.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbFullNameSupplier.Location = new System.Drawing.Point(343, 62);
            this.tbFullNameSupplier.Name = "tbFullNameSupplier";
            this.tbFullNameSupplier.Size = new System.Drawing.Size(340, 27);
            this.tbFullNameSupplier.TabIndex = 25;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbAddress.Location = new System.Drawing.Point(155, 258);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(138, 19);
            this.lbAddress.TabIndex = 24;
            this.lbAddress.Text = "Електронна пошта";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbEmail.Location = new System.Drawing.Point(155, 196);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(128, 19);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "Номер телефону";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbPhoneNumber.Location = new System.Drawing.Point(155, 126);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(114, 19);
            this.lbPhoneNumber.TabIndex = 22;
            this.lbPhoneNumber.Text = "Назва компанії";
            // 
            // lbFullNameCustomer
            // 
            this.lbFullNameCustomer.AutoSize = true;
            this.lbFullNameCustomer.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbFullNameCustomer.Location = new System.Drawing.Point(155, 65);
            this.lbFullNameCustomer.Name = "lbFullNameCustomer";
            this.lbFullNameCustomer.Size = new System.Drawing.Size(141, 19);
            this.lbFullNameCustomer.TabIndex = 21;
            this.lbFullNameCustomer.Text = "ПІБ постачальника";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Location = new System.Drawing.Point(236, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Location = new System.Drawing.Point(439, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 43);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Скинути";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // formWorkingWithSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.tbFullNameSupplier);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbFullNameCustomer);
            this.Controls.Add(this.btnSave);
            this.Name = "formWorkingWithSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання/редагування постачальника";
            this.Load += new System.EventHandler(this.formWorkingWithSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbPhoneNumber;
        public System.Windows.Forms.TextBox tbCompanyName;
        public System.Windows.Forms.TextBox tbFullNameSupplier;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbFullNameCustomer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}