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

        public void TabControl_Load(object sender, EventArgs e)
        {

        }

        public void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
        }

        public void toolStripTextBox1_Click(object sender, KeyPressEventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
        }

        public void goBttn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
            }
        }

        private void backbttn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardBttn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
    }
}
