using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_calculator_22
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            if ((textBox_Results.Text == "0") || (isOperationPerformed)) 
            textBox_Results.Clear();

            isOperationPerformed = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if(!textBox_Results.Text.Contains("."))
                    textBox_Results.Text = textBox_Results.Text + btn.Text;

            }else
            textBox_Results.Text = textBox_Results.Text + btn.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (resultValue != 0)
            {
                button14.PerformClick();
                operationPerformed = btn.Text;

                isOperationPerformed = true;
                lblOperator.Text = resultValue + "" + operationPerformed;
            }
            else
            {


                operationPerformed = btn.Text;
                resultValue = Double.Parse(textBox_Results.Text);
                isOperationPerformed = true;
                lblOperator.Text = resultValue + "" + operationPerformed;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Results.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Results.Text = "0";
            resultValue = 0;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Results.Text =(resultValue + Double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "-":
                    textBox_Results.Text = (resultValue - Double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "*":
                    textBox_Results.Text = (resultValue * Double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "/":
                    textBox_Results.Text = (resultValue / Double.Parse(textBox_Results.Text)).ToString();
                    break;
                   
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Results.Text);
            lblOperator.Text = "";


        }
    }
}
