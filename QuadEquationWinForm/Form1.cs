using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxA.Text) || String.IsNullOrEmpty(textBoxB.Text) || String.IsNullOrEmpty(textBoxC.Text))
            {
                MessageBox.Show("Помилка. Введiть значення.");
            }
            else
            {
                double a, b, c;
                if (!Double.TryParse(textBoxA.Text, out a))
                {
                    MessageBox.Show("Помилка. Введiть значення a.");
                }
                a = Convert.ToDouble(textBoxA.Text);
                if (!Double.TryParse(textBoxB.Text, out b))
                {
                    MessageBox.Show("Помилка. Введiть значення b.");
                }
                b = Convert.ToDouble(textBoxB.Text);
                if (!Double.TryParse(textBoxC.Text, out c))
                {
                    MessageBox.Show("Помилка. Введiть значення x.");
                }
                c = Convert.ToDouble(textBoxC.Text);
                double d = b * b - 4 * a * c;
                if (d == 0)
                {
                    double x = -1 * (b / (2 * a));
                    labelD.Visible = true; textBoxD.Visible = true;
                    labelX.Visible = true; textBoxX.Visible = true;
                    labelX1.Visible = false; textBoxX1.Visible = false;
                    labelX2.Visible = false; textBoxX2.Visible = false;
                    textBoxD.Text = d.ToString();
                    textBoxX.Text = x.ToString();
                }
                else if (d > 0)
                {
                    double x1 = -1 * ((b + Math.Sqrt(d)) / (2 * a));
                    double x2 = -1 * ((b - Math.Sqrt(d)) / (2 * a));
                    labelD.Visible = true; textBoxD.Visible = true;
                    labelX.Visible = false; textBoxX.Visible = false;
                    labelX1.Visible = true; textBoxX1.Visible = true;
                    labelX2.Visible = true; textBoxX2.Visible = true;
                    textBoxD.Text = d.ToString();
                    textBoxX1.Text = x1.ToString();
                    textBoxX2.Text = x2.ToString();
                }
                else
                {
                    labelD.Visible = false; textBoxD.Visible = false;
                    labelX.Visible = false; textBoxX.Visible = false;
                    labelX1.Visible = false; textBoxX1.Visible = false;
                    labelX2.Visible = false; textBoxX2.Visible = false;
                    MessageBox.Show("Розв'язкiв немає.");
                }
            }
        }
    }
}
