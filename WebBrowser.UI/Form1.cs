using System;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ken Scanlon's WebBrowser; Student Number: 904025969");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
        }

        private void toolStripTextBox1_Click(object sender, KeyPressEventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
        }

        private void goBttn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
        }

        private void tabControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
