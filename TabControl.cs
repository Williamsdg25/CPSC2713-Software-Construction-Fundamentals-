using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebBrowser.Logic;

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

        public void ToolStripTextBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
            var item = new HistoryItem
            {
                URL = toolStripTextBox1.Text.ToString(),
                Title = toolStripTextBox1.Text.ToString(),
                Date = DateTime.Now
            };

            HistoryManager.AddItem(item);

        }

        public void ToolStripTextBox1_Click(object sender, KeyPressEventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
            var item = new HistoryItem
            {
                URL = toolStripTextBox1.Text.ToString(),
                Title = toolStripTextBox1.Text.ToString(),
                Date = DateTime.Now
            };

            HistoryManager.AddItem(item);
        }

        public void GoBttn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
            var item = new HistoryItem
            {
                URL = toolStripTextBox1.Text.ToString(),
                Title = toolStripTextBox1.Text.ToString(),
                Date = DateTime.Now
            };

            HistoryManager.AddItem(item);
        }

        private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
                var item = new HistoryItem
                {
                    URL = toolStripTextBox1.Text.ToString(),
                    Title = toolStripTextBox1.Text.ToString(),
                    Date = DateTime.Now
                };

                HistoryManager.AddItem(item);
            }
        }

        private void Backbttn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardBttn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void RefreshBttn_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }

        private void BookmarkBttn_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem
            {
                URL = toolStripTextBox1.Text.ToString(),
                Title = toolStripTextBox1.Text.ToString()
            };

            BookmarkManager.AddItem(item);
        }
    }
}
