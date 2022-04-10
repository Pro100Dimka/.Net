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
        int Firstnum;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
                double Firstnum; double SecondNum;
                Firstnum = Convert.ToDouble(textBox1.Text);
                SecondNum = Convert.ToDouble(textBox2.Text);   
                switch (comboBox1.Text)
            {
                case "+":
                    label3.Text += " " + Convert.ToString(Firstnum + SecondNum);
                    break;
                case "-":
                    label3.Text += " " + Convert.ToString(Firstnum - SecondNum);
                    break;
                case "*":
                    label3.Text += " " + Convert.ToString(Firstnum * SecondNum);
                    break;
                case "/":
                    label3.Text += " " + Convert.ToString(Firstnum / SecondNum);
                    break;


            }
            }
            catch
            {
                label3.Text = "Не правильный формат";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            label3.Text = "Ваш Результат:";
            comboBox1.Text = " ";

        }
    }
}
