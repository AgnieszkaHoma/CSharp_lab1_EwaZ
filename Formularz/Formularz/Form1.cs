using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float x, y, z;
                x = Convert.ToByte(textBox4.Text);
                y = Convert.ToByte(textBox3.Text);
                z = Convert.ToByte(textBox2.Text);

                textBox1.Text = (x + y + z).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float x, y, z;
                x = Convert.ToByte(textBox4.Text);
                y = Convert.ToByte(textBox3.Text);
                z = Convert.ToByte(textBox2.Text);

                textBox1.Text = (x * y * z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
