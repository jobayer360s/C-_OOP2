using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Caltotal;
        double num1;
        double num2;
        String option;
        double result;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btnPoint.Text;
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn4.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
  
                option = "+";
                num1 = double.Parse(txtTotal.Text);
                label1.Text = num1.ToString(); 
                label2.Text = option;         
                txtTotal.Clear();
            


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            
                option = "-";
                num1 = double.Parse(txtTotal.Text);
                label1.Text = num1.ToString(); 
                label2.Text = option;         
                txtTotal.Clear();
            

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtTotal.Text);
            label1.Text = num1.ToString(); 
            label2.Text = option;         
            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtTotal.Text);
            label1.Text = num1.ToString(); 
            label2.Text = option;         
            txtTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtTotal.Text);
            label3.Text = num2.ToString(); 

          
            if (option == "+")
                result = num1 + num2;
            else if (option == "-")
                result = num1 - num2;
            else if (option == "*")
                result = num1 * num2;
            else if (option == "/")
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = 0;
                }
            }

            txtTotal.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            label1.Text = "";
            label2.Text = ""; 
            label3.Text = ""; 
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
            {
                txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1); 
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
