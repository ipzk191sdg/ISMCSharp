using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxA.Text) || String.IsNullOrEmpty(textBoxB.Text) || String.IsNullOrEmpty(textBoxX.Text))
            {
                MessageBox.Show("Помилка. Введiть значення.");
            }
            else
            {
                double a, b, x;
                if (!Double.TryParse(textBoxA.Text, out a))
                {
                    MessageBox.Show("Помилка. Введiть значення a.");
                }
                else { a = Convert.ToDouble(textBoxA.Text); }
                if (!Double.TryParse(textBoxB.Text, out b))
                {
                    MessageBox.Show("Помилка. Введiть значення b.");
                }
                else { b = Convert.ToDouble(textBoxB.Text); }
                if (!Double.TryParse(textBoxX.Text, out x))
                {
                    MessageBox.Show("Помилка. Введiть значення x.");
                }
                else { x = Convert.ToDouble(textBoxX.Text); }
                double y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
                labelY.Text = "y = " + y.ToString();
            }
        }
    }
}
