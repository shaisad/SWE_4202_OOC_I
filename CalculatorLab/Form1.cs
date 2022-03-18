using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_sum(object sender, EventArgs e)
        {
            if (FirstNoTextbox.Text == "" || SecondNoTextbox.Text == "")

            {
                MessageBox.Show("Please enter the numbers!");
            }

            else

            {
                double num1 = Convert.ToDouble(FirstNoTextbox.Text);
                double num2 = Convert.ToDouble(SecondNoTextbox.Text);
                string sum = Convert.ToString(num1 + num2);
                
                MessageBox.Show("The sum of two numbers is " + sum);
            }

        }

        private void show_difference(object sender, EventArgs e)
        {
            if (FirstNoTextbox.Text == "" || SecondNoTextbox.Text == "")

            {
                MessageBox.Show("Please enter the numbers!");
            }

            else

            {
                double num1 = Convert.ToDouble(FirstNoTextbox.Text);
                double num2 = Convert.ToDouble(SecondNoTextbox.Text);
                string difference = Convert.ToString(num1 - num2);

                MessageBox.Show("The difference of two numbers is " + difference);
            }
        }
    }
}
