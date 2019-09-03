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
            webBrowser1.Navigate("www.google.com");
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
                e.Handled = true;
                e.SuppressKeyPress = true;

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
            webBrowser1.Navigate(toolStripTextBox1.Text.ToString());
            var item = new BookmarkItem
            {
                URL = toolStripTextBox1.Text.ToString(),
                Title = toolStripTextBox1.Text.ToString()
            };

            BookmarkManager.AddItem(item);
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void WebBrowser1_ProgressChanged(Object sender,
                                         WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                ProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
                ProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {

            }
            if (ProgressBar1.Value < e.MaximumProgress)
            {
                StatusLabel1.Text = "Loading";
            }
            
            else if (ProgressBar1.Value == e.MaximumProgress)
            {
                StatusLabel1.Text = "Done";
            }

            
        }

#pragma warning disable IDE1006 // Naming Styles
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            TabPage tab = new TabPage
            {
                Text = webBrowser1.Url.ToString()
            };
        }

        private void HomeBttn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        public void Print()
        {
            webBrowser1.Print();
        }
    }
}
