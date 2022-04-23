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
        int sum = 0;
        char[] TextBoxResult;
        string[] ParsingString;
        int indexx;
        int resultt;
        int ClearResult = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // Назначения кнопок
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "1";
            
            if (ClearResult == 1)
            {
                textBox1.Text = "1";
                ClearResult = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
           
            if (ClearResult == 1)
            {
                textBox1.Text = "2";
                ClearResult = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            if (ClearResult == 1)
            {
                textBox1.Text = "3";
                ClearResult = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            if (ClearResult == 1)
            {
                textBox1.Text = "4";
                ClearResult = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            if (ClearResult == 1)
            {
                textBox1.Text = "5";
                ClearResult = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            if (ClearResult == 1)
            {
                textBox1.Text = "6";
                ClearResult = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            if (ClearResult == 1)
            {
                textBox1.Text = "7";
                ClearResult = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            if (ClearResult == 1)
            {
                textBox1.Text = "8";
                ClearResult = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            if (ClearResult == 1)
            {
                textBox1.Text = "9";
                ClearResult = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        // Кнопка прибавления
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                ClearResult = 0;
                if (sum == 1)
                {
                    TextBoxResult = textBox1.Text.ToCharArray();
                    ParsingString = textBox1.Text.Split('+', '-', ' ', '/', '*');
                    indexx = 1;
                    resultt = Convert.ToInt32(ParsingString[0]);
                    for (int i = 0; i < TextBoxResult.Length; i++)
                    {
                        if (TextBoxResult[i] == '+')
                        {
                            resultt += Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '-')
                        {
                            resultt -= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '/')
                        {
                            resultt /= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '*')
                        {
                            resultt *= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                    }
                    textBox1.Text = Convert.ToString(resultt);
                    sum = 0;
                }
                textBox1.Text += "+";
                sum += 1;
            }
            catch
            {
                textBox1.Text = "Не верный формат";
            }
        }
        // Кнопка разницы
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                ClearResult = 0;
                if (sum == 1)
                {
                    TextBoxResult = textBox1.Text.ToCharArray();
                    ParsingString = textBox1.Text.Split('+', '-', ' ', '/', '*');
                    indexx = 1;
                    resultt = Convert.ToInt32(ParsingString[0]);
                    for (int i = 0; i < TextBoxResult.Length; i++)
                    {
                        if (TextBoxResult[i] == '+')
                        {
                            resultt += Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '-')
                        {
                            resultt -= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '/')
                        {
                            resultt /= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '*')
                        {
                            resultt *= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                    }
                    textBox1.Text = Convert.ToString(resultt);
                    sum = 0;
                }
                textBox1.Text += "-";
                sum += 1;
            }
            catch
            {
                textBox1.Text = "Не верный формат";
            }

        }
        // Кнопка умножения
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClearResult = 0;
                if (sum == 1)
                {
                    TextBoxResult = textBox1.Text.ToCharArray();
                    ParsingString = textBox1.Text.Split('+', '-', ' ', '/', '*');
                    indexx = 1;
                    resultt = Convert.ToInt32(ParsingString[0]);
                    for (int i = 0; i < TextBoxResult.Length; i++)
                    {
                        if (TextBoxResult[i] == '+')
                        {
                            resultt += Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '-')
                        {
                            resultt -= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '/')
                        {
                            resultt /= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '*')
                        {
                            resultt *= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                    }
                    textBox1.Text = Convert.ToString(resultt);
                    sum = 0;
                }
                textBox1.Text += "*";
                sum += 1;
            }
            catch
            {
                textBox1.Text = "Не верный формат";
            }
        }
        // Кнопка деления
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                ClearResult = 0;
                if (sum == 1)
                {
                    TextBoxResult = textBox1.Text.ToCharArray();
                    ParsingString = textBox1.Text.Split('+', '-', ' ', '/', '*');
                    indexx = 1;
                    resultt = Convert.ToInt32(ParsingString[0]);
                    for (int i = 0; i < TextBoxResult.Length; i++)
                    {
                        if (TextBoxResult[i] == '+')
                        {
                            resultt += Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '-')
                        {
                            resultt -= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '/')
                        {
                            resultt /= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                        else if (TextBoxResult[i] == '*')
                        {
                            resultt *= Convert.ToInt32(ParsingString[indexx]);
                            indexx++;
                        }
                    }
                    textBox1.Text = Convert.ToString(resultt);
                    sum = 0;
                }
                textBox1.Text += "/";
                sum += 1;
            }
            catch
            {
                textBox1.Text = "Не верный формат";
            }
        }
        // Кнопка очистки
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sum = 0;
            ClearResult = 0;
        }
        // Кнопка результат
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxResult = textBox1.Text.ToCharArray();
                ParsingString = textBox1.Text.Split('+', '-', ' ', '/', '*');
                indexx = 1;
                resultt = Convert.ToInt32(ParsingString[0]);
                for (int i = 0; i < TextBoxResult.Length; i++)
                {
                    if (TextBoxResult[i] == '+')
                    {
                        resultt += Convert.ToInt32(ParsingString[indexx]);
                        indexx++;
                    }
                    else if (TextBoxResult[i] == '-')
                    {
                        resultt -= Convert.ToInt32(ParsingString[indexx]);
                        indexx++;
                    }
                    else if (TextBoxResult[i] == '/')
                    {
                        resultt /= Convert.ToInt32(ParsingString[indexx]);
                        indexx++;
                    }
                    else if (TextBoxResult[i] == '*')
                    {
                        resultt *= Convert.ToInt32(ParsingString[indexx]);
                        indexx++;
                    }
                }
                textBox1.Text = Convert.ToString(resultt);
                ClearResult += 1;
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
