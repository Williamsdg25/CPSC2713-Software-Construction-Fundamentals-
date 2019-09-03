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
    public partial class DormAndMealPlanForm : Form
    {
        public DormAndMealPlanForm()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //Variables
            int dormAmount = 0;
            int mealAmount = 0;
            int total = 0;

            //Create object of totalDisplayForm
            TotalChargeForm tdobj = new TotalChargeForm();

            //Check which type of Dormitory is selected by the user, then
            //set the dormAmount
            if (dormListBox.SelectedItem.ToString() == "Allen Hall")
            {
                //set the dormAmount
                dormAmount = 1500;
            }

            else if (dormListBox.SelectedItem.ToString() == "Pike Hall")
            {
                //set the dormAmount
                dormAmount = 1600;
            }

            else if (dormListBox.SelectedItem.ToString() == "Farthing Hall")
            {
                //set the dormAmount
                dormAmount = 1800;
            }

            else if (dormListBox.SelectedItem.ToString() == "University Suites")
            {
                //set the dormAmount
                dormAmount = 2500;
            }

            //Check which type of meal is selected by the user, then set the mealAmount
            if (mealsListBox.SelectedItem.ToString() == "7 meals per week")
            {
                //set the mealAmount
                mealAmount = 600;
            }

            else if (mealsListBox.SelectedItem.ToString() == "14 meals per week")
            {
                //set the mealAmount
                mealAmount = 1200;
            }

            else if (mealsListBox.SelectedItem.ToString() == "Unlimited meals")
            {
                //set the mealAmount
                mealAmount = 1700;
            }

            //add the cost of the dorm and meal charges at the displayTotalLabel
            tdobj.displayTotalLabel.Text = "Dorm Charges: " + dormAmount.ToString("c") + "\n";

            tdobj.displayTotalLabel.Text += "Meal Charges: " + mealAmount.ToString("c") + "\n";

            //Calculate the total price.
            total = dormAmount + mealAmount;

            //Access the displayTotalLabel from totalDisplayForm and set the text property.
            tdobj.displayTotalLabel.Text += "Total Charges: " + total.ToString("c");

            //Access the displayTotalLabel from totalDisplayForm and set the text property
            tdobj.ShowDialog();
        }

        //exitButton method to close the current application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
