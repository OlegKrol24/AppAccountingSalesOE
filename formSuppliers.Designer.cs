namespace AppAccountingSalesOE
{
    partial class formSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.btnDeleteSuppliers = new System.Windows.Forms.Button();
            this.btnEditSuppliers = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Full_name,
            this.Company_name,
            this.Phone_number,
            this.Email});
            this.dgvSuppliers.Location = new System.Drawing.Point(33, 100);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSuppliers.RowHeadersWidth = 51;
            this.dgvSuppliers.RowTemplate.Height = 24;
            this.dgvSuppliers.Size = new System.Drawing.Size(839, 434);
            this.dgvSuppliers.TabIndex = 0;
            // 
            // btnDeleteSuppliers
            // 
            this.btnDeleteSuppliers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSuppliers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteSuppliers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteSuppliers.Location = new System.Drawing.Point(539, 28);
            this.btnDeleteSuppliers.Name = "btnDeleteSuppliers";
            this.btnDeleteSuppliers.Size = new System.Drawing.Size(130, 43);
            this.btnDeleteSuppliers.TabIndex = 45;
            this.btnDeleteSuppliers.Text = "Видалити";
            this.btnDeleteSuppliers.UseVisualStyleBackColor = false;
            this.btnDeleteSuppliers.Click += new System.EventHandler(this.btnDeleteSuppliers_Click);
            // 
            // btnEditSuppliers
            // 
            this.btnEditSuppliers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSuppliers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditSuppliers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditSuppliers.Location = new System.Drawing.Point(379, 28);
            this.btnEditSuppliers.Name = "btnEditSuppliers";
            this.btnEditSuppliers.Size = new System.Drawing.Size(130, 43);
            this.btnEditSuppliers.TabIndex = 44;
            this.btnEditSuppliers.Text = "Редагувати";
            this.btnEditSuppliers.UseVisualStyleBackColor = false;
            this.btnEditSuppliers.Click += new System.EventHandler(this.btnEditSuppliers_Click);
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSuppliers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSuppliers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddSuppliers.Location = new System.Drawing.Point(219, 28);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(130, 43);
            this.btnAddSuppliers.TabIndex = 43;
            this.btnAddSuppliers.Text = "Додати";
            this.btnAddSuppliers.UseVisualStyleBackColor = false;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // Full_name
            // 
            this.Full_name.HeaderText = "Постачальник";
            this.Full_name.MinimumWidth = 6;
            this.Full_name.Name = "Full_name";
            this.Full_name.ReadOnly = true;
            this.Full_name.Width = 140;
            // 
            // Company_name
            // 
            this.Company_name.HeaderText = "Назва компанії";
            this.Company_name.MinimumWidth = 6;
            this.Company_name.Name = "Company_name";
            this.Company_name.ReadOnly = true;
            this.Company_name.Width = 155;
            // 
            // Phone_number
            // 
            this.Phone_number.HeaderText = "Номер телефону";
            this.Phone_number.MinimumWidth = 6;
            this.Phone_number.Name = "Phone_number";
            this.Phone_number.ReadOnly = true;
            this.Phone_number.Width = 135;
            // 
            // Email
            // 
            this.Email.HeaderText = "Електронна пошта";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 145;
            // 
            // formSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 560);
            this.Controls.Add(this.btnDeleteSuppliers);
            this.Controls.Add(this.btnEditSuppliers);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.dgvSuppliers);
            this.Name = "formSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Постачальники";
            this.Load += new System.EventHandler(this.formSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Button btnDeleteSuppliers;
        private System.Windows.Forms.Button btnEditSuppliers;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}