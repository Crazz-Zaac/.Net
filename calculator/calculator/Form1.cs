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
    public partial class Form1 : Form {

        double FirstNum;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void btnEquals(object sender, EventArgs e)
        {
            double SecondNum;
            double Result;
            SecondNum = int.Parse(label3.Text);

            if (Operation == "+") {
                Result = (FirstNum + SecondNum);
                label3.Text = Convert.ToString(Result);
                //label1.Text = label2.Text;
                FirstNum = int.Parse(label4.Text);
            }
            if (Operation == "-") {
                Result = (FirstNum - SecondNum);
                label2.Text = Convert.ToString(Result);
                label1.Text = label2.Text;
                FirstNum = int.Parse(label1.Text);
            }
            if (Operation == "*") {
                Result = (FirstNum * SecondNum);
                label2.Text = Convert.ToString(Result);
                label1.Text = label2.Text;
                FirstNum = int.Parse(label1.Text);
            }
            if (Operation == "/") {
                if(SecondNum == 0){
                    System.Environment.Exit(1);
                }
                else{
                    Result = (FirstNum / SecondNum);
                    label2.Text = Convert.ToString(Result);
                    label1.Text = label2.Text;
                    FirstNum = int.Parse(label1.Text);
                }
            }
        }            

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            FirstNum = int.Parse(label1.Text);
            label1.Text = "0";
            Operation = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "1";
                label4.Text = "1";
            }
            else {
                label1.Text = label1.Text + "1";
                label4.Text = label4.Text + "1";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            FirstNum = int.Parse(label1.Text); //converting the string to int
            label1.Text = label1.Text + "+";
            label3.Text = "0";
            Operation = "+";            
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            FirstNum = int.Parse(label1.Text);
            label1.Text = "0";
            Operation = "-";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            FirstNum = int.Parse(label1.Text);
            label1.Text = "0";
            Operation = "*";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0"; 
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
