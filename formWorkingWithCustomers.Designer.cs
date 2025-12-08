namespace AppAccountingSalesOE
{
    partial class formWorkingWithCustomers
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
            this.tbFullNameCustomers = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbFullNameCustomer = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbEmail.Location = new System.Drawing.Point(339, 194);
            this.tbEmail.MaxLength = 60;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(263, 27);
            this.tbEmail.TabIndex = 18;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(339, 124);
            this.tbPhoneNumber.MaxLength = 13;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(263, 27);
            this.tbPhoneNumber.TabIndex = 17;
            // 
            // tbFullNameCustomers
            // 
            this.tbFullNameCustomers.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbFullNameCustomers.Location = new System.Drawing.Point(339, 63);
            this.tbFullNameCustomers.Name = "tbFullNameCustomers";
            this.tbFullNameCustomers.Size = new System.Drawing.Size(340, 27);
            this.tbFullNameCustomers.TabIndex = 16;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbAddress.Location = new System.Drawing.Point(151, 259);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 19);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Адреса";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbEmail.Location = new System.Drawing.Point(151, 197);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(130, 19);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Елетронна пошта";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbPhoneNumber.Location = new System.Drawing.Point(151, 127);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(128, 19);
            this.lbPhoneNumber.TabIndex = 13;
            this.lbPhoneNumber.Text = "Номер телефону";
            // 
            // lbFullNameCustomer
            // 
            this.lbFullNameCustomer.AutoSize = true;
            this.lbFullNameCustomer.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.lbFullNameCustomer.Location = new System.Drawing.Point(151, 66);
            this.lbFullNameCustomer.Name = "lbFullNameCustomer";
            this.lbFullNameCustomer.Size = new System.Drawing.Size(91, 19);
            this.lbFullNameCustomer.TabIndex = 12;
            this.lbFullNameCustomer.Text = "ПІБ клієнта";
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
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.tbAddress.Location = new System.Drawing.Point(339, 256);
            this.tbAddress.MaxLength = 50;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(340, 27);
            this.tbAddress.TabIndex = 19;
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
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Скинути";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // formWorkingWithCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbFullNameCustomers);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbFullNameCustomer);
            this.Controls.Add(this.btnSave);
            this.Name = "formWorkingWithCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання/редагування клієнта";
            this.Load += new System.EventHandler(this.formWorkingWithCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbPhoneNumber;
        public System.Windows.Forms.TextBox tbFullNameCustomers;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbFullNameCustomer;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnClear;
    }
}