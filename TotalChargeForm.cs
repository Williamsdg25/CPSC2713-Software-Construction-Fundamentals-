using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormMealPlanCalculator
{
    public partial class TotalChargeForm : Form
    {
        public TotalChargeForm()
        {
            InitializeComponent();
        }

        //closeButton_Click method to close the current form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
