using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ken Scanlon's WebBrowser; Student Number: 904025969");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_Load(object sender, EventArgs e)
        {

        }

        private void tabControl2_Load_1(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage newPage = new TabPage("New Page");
            tabControl1.TabPages.Add(newPage);
            TabControl tc = new TabControl();
            tc.Dock = DockStyle.Fill;
            newPage.Controls.Add(tc);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }
    }
}
