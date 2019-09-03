using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductionWorker obj = new ProductionWorker();

            obj.name = textBox1.Text;
            obj.number = textBox2.Text;
            obj.shiftNumber = Convert.ToInt16(textBox3.Text);
            obj.payRate = Convert.ToDouble(textBox4.Text);

            MessageBox.Show("Employee Name: " + obj.name + "\n" + "Employee Number: " + obj.number + "\n" 
                + "Employee Shift: " + obj.shiftNumber + "\n" + "Employee Pay Rate: $" + obj.payRate);
        }
    }

    public class Employee
        {
            public string name;
            public string number;
        }

        public class ProductionWorker : Employee 
        {
            public int shiftNumber;
            public double payRate;
        }

    
}
