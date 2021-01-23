using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class CalculatorOS : Form
    {
        public CalculatorOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result=(firstnumber+secondnumber);
            resultTextBox.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = (firstnumber - secondnumber);
            resultTextBox.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            double firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = (firstnumber * secondnumber);
            resultTextBox.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = (firstnumber / secondnumber);
            resultTextBox.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            double result = Math.Sqrt(firstnumber); ;
            resultTextBox.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            double firstnumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondnumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = Math.Pow(firstnumber, secondnumber);
            resultTextBox.Text = result.ToString();  
        }

        private void secondNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
