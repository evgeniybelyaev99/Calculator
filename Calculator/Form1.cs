using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e) // цифры
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text=="0")
                textBox1.Text = B.Text;
            
            else
                 textBox1.Text = textBox1.Text + B.Text;
        }

        

        private void button2_Click_1(object sender, EventArgs e) // + - * /
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button1_Click(object sender, EventArgs e) // корень из х
        {
            try
            { 
            double dn, res = 0;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
            }
            catch
            {
                textBox1.Text = "0";
            }

        }
        private void equally(object sender, EventArgs e)
        {
            double dn1, dn2, res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "×")
            {
                res = dn1 * dn2;
            }
            if (D == "÷")
            {
                res = dn1 / dn2;
            }
            if (D == "%")
            {
                res = dn2*(dn1/100);
            }
            if (D == "x^y")
            {
                res = Math.Pow(dn1,dn2);
            }
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();


        }

        private void button21_Click(object sender, EventArgs e) // x^y
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true; 
       
           
        }

        

        private void button17_Click(object sender, EventArgs e)    // знак
        {
            double dn, res = 0;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e) // очистка
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "" || textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)  // 1/x
        {
            try
            {
                double dn, res = 0;
                dn = Convert.ToDouble(textBox1.Text);
                res = 1 / dn;
                textBox1.Text = res.ToString();
            }
            catch
            {
                textBox1.Text="0";
            }
        }

        private void button23_Click(object sender, EventArgs e)   // %
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button24_Click(object sender, EventArgs e) // факториал
        {
            double dn= Convert.ToDouble(textBox1.Text); ;
            int res = 1;
            
            for (int i = 1; i <= Convert.ToInt32(dn); i++) res *= i;
            textBox1.Text = res.ToString();
        }

        private void cleaning(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

       private void comma(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
    }
}
