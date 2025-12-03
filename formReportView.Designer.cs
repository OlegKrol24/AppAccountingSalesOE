namespace AppAccountingSalesOE
{
    partial class formReportView
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
            this.pnlReportPreview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlReportPreview
            // 
            this.pnlReportPreview.Location = new System.Drawing.Point(13, 11);
            this.pnlReportPreview.Name = "pnlReportPreview";
            this.pnlReportPreview.Size = new System.Drawing.Size(754, 737);
            this.pnlReportPreview.TabIndex = 0;
            // 
            // formReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 755);
            this.Controls.Add(this.pnlReportPreview);
            this.Name = "formReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд звіту";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlReportPreview;
    }
}