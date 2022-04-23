using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Best_V
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        int sum = 0;
        char[] TextBoxResultPlus;
        string[] ParsingString;
        int indexx;
        int resultt;
        private void button12_Click(object sender, EventArgs e)
        {
            if (sum == 1)
            {
                TextBoxResultPlus = textBox1.Text.ToCharArray();
                ParsingString = textBox1.Text.Split('+');
                indexx = 1;
                resultt = Convert.ToInt32(ParsingString[0]);
                for (int i = 0; i < TextBoxResultPlus.Length; i++)
                {
                    if (TextBoxResultPlus[i] == '+')
                    {
                        resultt += Convert.ToInt32(ParsingString[indexx]);
                        indexx++;
                    }
                }
               textBox1.Text = Convert.ToString(resultt);
                sum = 0;
            }
            textBox1.Text += "+";
            sum += 1;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                char[] TextBoxResult = textBox1.Text.ToCharArray();
                string[] rez = textBox1.Text.Split('+', '-', ' ', '/', '*');
                int index = 1;
                int result = Convert.ToInt32(rez[0]);
                for (int i = 0; i < TextBoxResult.Length; i++)
                {
                    if (TextBoxResult[i] == '+')
                    {
                        result += Convert.ToInt32(rez[index]);
                        index++;
                    }
                    if (TextBoxResult[i] == '-')
                    {
                        result -= Convert.ToInt32(rez[index]);
                        index++;
                    }
                    if (TextBoxResult[i] == '/')
                    {
                        result /= Convert.ToInt32(rez[index]);
                        index++;
                    }
                    if (TextBoxResult[i] == '*')
                    {
                        result *= Convert.ToInt32(rez[index]);
                        index++;
                    }
                    textBox1.Text = Convert.ToString(result);
                }
            }
            catch
            {
                textBox1.Text = "Не верный формат";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
