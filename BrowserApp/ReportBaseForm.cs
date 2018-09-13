using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserApp
{
    public partial class ReportBaseForm : Form
    {
        public ReportBaseForm()
        {
            InitializeComponent();
        }

        private void reportBaseFormCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportBaseFormText_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl + A を実装
            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true; //beep解除
                reportBaseFormText.SelectAll();
            }
        }
    }
}
