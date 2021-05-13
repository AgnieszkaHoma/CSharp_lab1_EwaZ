using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2_kalkulator
{
    public partial class Form1 : Form
    {
        string into = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        double buforliczb = 0;
        char operation;
        double result = 0.0;

        public Form1()
        { 
            InitializeComponent();
        }

        private void jeden_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "1";
        }

        private void dwa_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "2";
        }

        private void trzy_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "3";
        }

        private void cztery_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "4";
        }

        private void piec_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "5";
        }

        private void szesc_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "6";
        }

        private void siedem_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "7";
        }

        private void osiem_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "8";
        }

        private void dziewiec_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + "0";
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            this.textBox1wynik.Text = "";
            this.into = string.Empty;
            this.num1 = string.Empty;
            this.num2 = string.Empty;
        }

        private void przecinek_Click(object sender, EventArgs e)
        {
            textBox1wynik.Text = textBox1wynik.Text + ".";
        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            into = textBox1wynik.Text;
            if(num1 != string.Empty)
            {
                num2 = into;
            }
            else
            {
                num1 = into;
            }
            operation = '+';
            into = string.Empty;
            textBox1wynik.Text = string.Empty;
            if(num1 != string.Empty && num2 != string.Empty)
            {
                buforliczb = double.Parse(num1) + double.Parse(num2);
                num1 = string.Empty;
                num2 = string.Empty;
            }
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            into = textBox1wynik.Text;
            if (num1 != string.Empty)
            {
                num2 = into;
            }
            else
            {
                num1 = into;
            }
            operation = '*';
            into = string.Empty;
            textBox1wynik.Text = string.Empty;
            if (num1 != string.Empty && num2 != string.Empty)
            {
                buforliczb = double.Parse(num1) * double.Parse(num2);
                num1 = string.Empty;
                num2 = string.Empty;
            }
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            into = textBox1wynik.Text;
            if (num1 != string.Empty)
            {
                num2 = into;
            }
            else
            {
                num1 = into;
            }
            operation = '-';
            into = string.Empty;
            textBox1wynik.Text = string.Empty;
            if (num1 != string.Empty && num2 != string.Empty)
            {
                buforliczb = double.Parse(num1) - double.Parse(num2);
                num1 = string.Empty;
                num2 = string.Empty;
            }
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            into = textBox1wynik.Text;
            if (num1 != string.Empty)
            {
                num2 = into;
            }
            else
            {
                num1 = into;
            }
            operation = '/';
            into = string.Empty;
            textBox1wynik.Text = string.Empty;
            if (num1 != string.Empty && num2 != string.Empty)
            {
                buforliczb = double.Parse(num1) / double.Parse(num2);
                num1 = string.Empty;
                num2 = string.Empty;
            }
        }

        private void wynik_Click(object sender, EventArgs e)
        {
            into = textBox1wynik.Text;
            num2 = into;
            double num3, num4;
            double.TryParse(num1, out num3);
            double.TryParse(num2, out num4);

            if (operation == '+')
            {
                if(buforliczb == 0)
                {
                    result = num3 + num4;
                }
                else
                {
                    result = buforliczb + num4;
                }
                textBox1wynik.Text = result.ToString();
            }
            else if (operation == '-')
            {
                if (buforliczb == 0)
                {
                    result = num3 - num4;
                }
                else
                {
                    result = buforliczb - num4;
                }
                textBox1wynik.Text = result.ToString();
            }
            else if (operation == '*')
            {
                if (buforliczb == 0)
                {
                    result = num3 * num4;
                }
                else
                {
                    result = buforliczb * num4;
                }
                textBox1wynik.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num4 == 0)
                {
                    textBox1wynik.Text = "Nie dziel przez 0!";
                }
                if (buforliczb == 0)
                {
                    result = num3 / num4;
                }
                else
                {
                    result = buforliczb / num4;
                }
                textBox1wynik.Text = result.ToString();
            }
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Num1 :" + num1 + " Num2: " + num2 + " into : " + into + " bufor : " + buforliczb);
        }
    }
    
}

