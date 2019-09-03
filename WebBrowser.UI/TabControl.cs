using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class TabControl : UserControl
    {
        public TabControl()
        {
            InitializeComponent();
        }

        private void TabControl_Load(object sender, EventArgs e)
        {

        }

        private void backbttn_Click(object sender, EventArgs e)
        {

        }

        private void forwardBttn_Click(object sender, EventArgs e)
        {

        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {

        }

        private void homeBttn_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
        }

        private void goBttn_Click(object sender, EventArgs e)
        {

        }

        private void bookmarkBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
