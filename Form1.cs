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

        private void ExitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ken Scanlon's WebBrowser; Student Number: 904025969");
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabControl2_Load(object sender, EventArgs e)
        {

        }

        private void TabControl2_Load_1(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TabPage newPage = new TabPage("New Page");
            tabControl1.TabPages.Add(newPage);
#pragma warning disable IDE0017 // Simplify object initialization
            TabControl tc = new TabControl();
#pragma warning restore IDE0017 // Simplify object initialization
            tc.Dock = DockStyle.Fill;
            newPage.Controls.Add(tc);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void TabControl2_Load_1(object sender)
        {

        }

        private void ManageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryManagerForm();
            historyForm.ShowDialog();
        }

        private void ManageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkForm = new BookmarkManagerForm();
            bookmarkForm.ShowDialog();
        }
    }
}
