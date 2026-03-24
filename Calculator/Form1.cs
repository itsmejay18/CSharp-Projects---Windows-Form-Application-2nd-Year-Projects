using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double numbers;
        string operators;
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Clicked(object sender, EventArgs e)
        {
            var clickedButton_Numbers = sender as Button;
            if (numbers_txt.Text == "0")
            {
                numbers_txt.Text = clickedButton_Numbers.Text;
            }
            else
            {
                numbers_txt.Text += clickedButton_Numbers.Text;
            }
        }

        private void operators_Clicked(object sender, EventArgs e)
        {
            var clickedButton_Operators = sender as Button;
            var new_numbers = double.Parse(numbers_txt.Text); 
            switch (clickedButton_Operators.Text)
            {
                case "+":
                case "-":
                case "/":
                case "x":
                    numbers = new_numbers;
                    operators = clickedButton_Operators.Text;
                    numbers_txt.Text = "0";
                    numbers_lbl.Text = operators + " " + numbers.ToString(); 
                    break;
                case "=":
                    double result;
                    switch (operators)
                    {    
                        case "+":
                            result = new_numbers + numbers;
                            numbers_txt.Text = result.ToString();
                            numbers_lbl.Text = " ";
                            break;
                        case "-":
                            result = new_numbers - numbers;
                            numbers_txt.Text = result.ToString();
                            numbers_lbl.Text = " ";
                            break;
                        case "/":
                            result = new_numbers / numbers;
                            numbers_txt.Text = result.ToString();
                            numbers_lbl.Text = " ";
                            break;
                        case "x":
                            result = new_numbers * numbers;
                            numbers_txt.Text = result.ToString();
                            numbers_lbl.Text = " ";
                            break;
                    }
                    break;

                case "AC":
                    operators = "";
                    numbers = 0;
                    new_numbers = 0;
                    numbers_txt.Text = "0";
                    numbers_lbl.Text = " ";
                    break;
                default:
                    MessageBox.Show("Operator Unavailable");
                    break;

            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
