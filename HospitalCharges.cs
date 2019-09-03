using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double total = CalculateTotalCharges();
            totalChargesTextBox.Text = total.ToString();
        }

        private double CalculateStayCharges(int days)
        {
            return 350 * days;
        }

        private double CalculateMiscCharges(double medCharge, double surgCharge, double labCharge, double phyRehabiCharge)
        {
            return (medCharge + surgCharge + labCharge + phyRehabiCharge);
        }

        private double CalculateTotalCharges()
        {
            int days = int.Parse(daysSpentTextBox.Text);
            double medCharge = double.Parse(medChargesTextBox.Text);
            double surgCharge = double.Parse(surgicalChargesTextBox.Text);
            double labCharge = double.Parse(labFeesTextBox.Text);
            double phyRehabiCharge = double.Parse(rehabChargesTextBox.Text);
            double tot = CalculateStayCharges(days) + CalculateMiscCharges(medCharge, surgCharge, labCharge, phyRehabiCharge);
            return tot;
        }

        private void Clear()
        {
            daysSpentTextBox.Text = "";
            medChargesTextBox.Text = "";
            surgicalChargesTextBox.Text = "";
            labFeesTextBox.Text = "";
            rehabChargesTextBox.Text = "";
            totalChargesTextBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear(); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totalChargesTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
