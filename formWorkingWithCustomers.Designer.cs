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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formWorkingWithCustomers));
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
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.Name = "tbEmail";
            // 
            // tbPhoneNumber
            // 
            resources.ApplyResources(this.tbPhoneNumber, "tbPhoneNumber");
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            // 
            // tbFullNameCustomers
            // 
            resources.ApplyResources(this.tbFullNameCustomers, "tbFullNameCustomers");
            this.tbFullNameCustomers.Name = "tbFullNameCustomers";
            // 
            // lbAddress
            // 
            resources.ApplyResources(this.lbAddress, "lbAddress");
            this.lbAddress.Name = "lbAddress";
            // 
            // lbEmail
            // 
            resources.ApplyResources(this.lbEmail, "lbEmail");
            this.lbEmail.Name = "lbEmail";
            // 
            // lbPhoneNumber
            // 
            resources.ApplyResources(this.lbPhoneNumber, "lbPhoneNumber");
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            // 
            // lbFullNameCustomer
            // 
            resources.ApplyResources(this.lbFullNameCustomer, "lbFullNameCustomer");
            this.lbFullNameCustomer.Name = "lbFullNameCustomer";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAddress
            // 
            resources.ApplyResources(this.tbAddress, "tbAddress");
            this.tbAddress.Name = "tbAddress";
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
            // formWorkingWithCustomers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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