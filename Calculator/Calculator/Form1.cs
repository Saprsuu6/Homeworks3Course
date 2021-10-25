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
        double a;
        double b;
        int count;
        bool digit = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 0;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 2;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Line.Text = Line.Text + 9;
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (digit)
            {
                Line.Text = "-" + Line.Text;
                digit = false;
            }
            else if (!digit)
            {
                Line.Text = Line.Text.Replace("-", "");
                digit = true;
            }
            
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + Convert.ToDouble(Line.Text);
                    Line.Text = b.ToString();
                    break;

                case 2:
                    b = a - Convert.ToDouble(Line.Text);
                    Line.Text = b.ToString();
                    break;
                case 3:
                    b = b * Convert.ToDouble(Line.Text);
                    Line.Text = b.ToString();
                    break;
                case 4:
                    b = b / Convert.ToDouble(Line.Text);
                    Line.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Line.Text);
            Line.Clear();
            count = 1;
            digit = true;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Line.Text);
            Line.Clear();
            count = 2;
            digit = true;
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Line.Text);
            Line.Clear();
            count = 3;
            digit = true;
        }

        private void Diverce_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Line.Text);
            Line.Clear();
            count = 4;
            digit = true;
        }

        private void Is_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Line.Text = "";
            Line.Text = "";

            a = 0;
            b = 0;
        }

        private void ClearOne_Click(object sender, EventArgs e)
        {
            int lenght = Line.Text.Length - 1;
            string text = Line.Text;
            Line.Clear();
            for (int i = 0; i < lenght; i++)
            {
                Line.Text = Line.Text + text[i];
            }
        }
    }
}
