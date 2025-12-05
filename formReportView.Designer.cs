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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReportView));
            this.pnlReportPreview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlReportPreview
            // 
            resources.ApplyResources(this.pnlReportPreview, "pnlReportPreview");
            this.pnlReportPreview.Name = "pnlReportPreview";
            // 
            // formReportView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlReportPreview);
            this.Name = "formReportView";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlReportPreview;
    }
}