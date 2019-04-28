using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxN.Text))
            {
                MessageBox.Show("");
            }
            else
            {
                try
                {
                    int n;
                    n = Convert.ToInt32(textBoxN.Text);
                    dataArr.ColumnCount = n;
                    dataArr.RowCount = 1;
                    buttonFill.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
            }
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            double max = 100, min = -100;
            int n = dataArr.ColumnCount;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                dataArr[i, 0].Value = Math.Round(rand.NextDouble() * Math.Abs(max - min) + min, 1);
            }
            buttonSumNg.Visible = true; labelSumNg.Visible = true; SumNg.Visible = true;
            buttonMax.Visible = true; labelMax.Visible = true; Max.Visible = true;
            buttonMaxInd.Visible = true; labelMaxInd.Visible = true; MaxInd.Visible = true;
            buttonMaxAbs.Visible = true; labelMaxAbs.Visible = true; MaxAbs.Visible = true;
            buttonSumPosInd.Visible = true; labelSumPosInd.Visible = true; SumPosInd.Visible = true;
            buttonCountInt.Visible = true; labelCountInt.Visible = true; CountInt.Visible = true;
        }

        private void buttonSumNg_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double [n];
            double sumNg = 0;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    sumNg += arr[i];

                }
            }
            SumNg.Text = sumNg.ToString();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];

                }
            }
            Max.Text = max.ToString();
        }

        private void buttonMaxInd_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double max = double.MinValue;
            int maxInd=0;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxInd = i;

                }
            }
            MaxInd.Text = maxInd.ToString();
        }

        private void buttonMaxAbs_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double max = double.MinValue;
            double maxm = max;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(arr[i]) > maxm)
                {
                    maxm = Math.Abs(arr[i]);
                    max = arr[i];

                }
            }
            MaxAbs.Text = max.ToString();
        }

        private void buttonSumPosInd_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double sumPosInd = 0;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    sumPosInd += i;

                }
            }
            SumPosInd.Text = sumPosInd.ToString();
        }

        private void buttonCountInt_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            int countInt = 0;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if(Convert.ToInt32(arr[i])==arr[i])
                {
                    countInt++;
                }
            }
            CountInt.Text = countInt.ToString();
        }
    }
}
