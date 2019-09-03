using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SearchProgram
{
    public partial class txtSearchApp : Form
    {   //Create an open file dialog object for getting the file name
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //Variable to store file name
        public string fileName;

        public txtSearchApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Browse button for getting file name
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Get file name
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Reader get file path
            StreamReader sr = new StreamReader(path: fileName);
            //Read until end
            while (!sr.EndOfStream)
            {
                //Each line
                var line = sr.ReadLine();
                //if line is not empty
                if (String.IsNullOrEmpty(line)) continue;
                //Serch for key word
                if (line.IndexOf(txtWord.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    lstResult.Items.Add(line);
                }
            }
        }
    }
}
