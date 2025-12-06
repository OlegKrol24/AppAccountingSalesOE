using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAccountingSalesOE
{
    public partial class formReportView : Form
    {
        public formReportView()
        {
            InitializeComponent();
        }

        private void formReportView_Load(object sender, EventArgs e)
        {
            LocalizationHelper.ApplyLocalization(this, LanguageManager.CurrentCulture);
        }
    }
}
