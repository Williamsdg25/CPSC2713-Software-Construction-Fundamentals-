using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebBrowser.Logic;


namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        public void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();

            foreach(var item in items)
            {
                listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void buttonHistorySearch_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();

            foreach (var item in items)
            {
                if (item.Title.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void buttonDeleteItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            var items = HistoryManager.GetItems();

            foreach (var item in items)
            {
                if (item.Title.Contains(textBox1.Text))
                {
                    listBox1.Items.Remove(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        public void buttonClearHistory_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            
            listBox1.Items.Clear();
        }

        public void ClearHistory()
        {
            var items = HistoryManager.GetItems();

            foreach (var item in items)
            {   
                 listBox1.Items.Remove(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL)); 
            }
        }
    }
}
