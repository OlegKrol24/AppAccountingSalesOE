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
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(360, 202);
            this.tbEmail.MaxLength = 60;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(263, 22);
            this.tbEmail.TabIndex = 18;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(360, 132);
            this.tbPhoneNumber.MaxLength = 13;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(263, 22);
            this.tbPhoneNumber.TabIndex = 17;
            // 
            // tbFullNameCustomers
            // 
            this.tbFullNameCustomers.Location = new System.Drawing.Point(360, 71);
            this.tbFullNameCustomers.Name = "tbFullNameCustomers";
            this.tbFullNameCustomers.Size = new System.Drawing.Size(282, 22);
            this.tbFullNameCustomers.TabIndex = 16;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(172, 267);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(55, 16);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Адреса";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(172, 205);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(124, 16);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Елетронна пошта";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(172, 135);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(119, 16);
            this.lbPhoneNumber.TabIndex = 13;
            this.lbPhoneNumber.Text = "Номер телефону";
            // 
            // lbFullNameCustomer
            // 
            this.lbFullNameCustomer.AutoSize = true;
            this.lbFullNameCustomer.Location = new System.Drawing.Point(172, 74);
            this.lbFullNameCustomer.Name = "lbFullNameCustomer";
            this.lbFullNameCustomer.Size = new System.Drawing.Size(81, 16);
            this.lbFullNameCustomer.TabIndex = 12;
            this.lbFullNameCustomer.Text = "ПІБ клієнта";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(334, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(360, 264);
            this.tbAddress.MaxLength = 50;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(282, 22);
            this.tbAddress.TabIndex = 19;
            // 
            // formWorkingWithCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}