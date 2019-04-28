using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("");
            }
            else
            {
                try
                {
                    int n;
                    n = Convert.ToInt32(textBoxCount.Text);
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
            labelProduct.Visible = true; buttonProduct.Visible = true; labelProduct.Text = "Добуток елементів масиву, що розташовані після мінімального елемента";
            labelSumNgPos.Visible = true; buttonSumNgPos.Visible = true; labelSumNgPos.Text = "Сума елементів, що розташовані між першим від'ємним та другим додатним елементами";
            labelSumNulls.Visible = true; buttonSumNulls.Visible = true; labelSumNulls.Text = "Cуму елементів, які розташовані між першим і останнім нульовими елементами";
            labelProductMinMax.Visible = true; buttonProductMinMax.Visible = true; labelProductMinMax.Text = "Добуток елементів, що розташовані між максимальним за модулем і мінімальним за модулем елементами";
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double min = double.MaxValue;
            int minInd=0;
            double product = 1;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minInd = i;

                }
            }
            for (int i = minInd+1; i< n; i++)
            {
                product *= arr[i];
            }
            labelProduct.Text += "= " + Math.Round(product,1).ToString();
        }

        private void buttonSumNgPos_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double sumNgPos = 0;
            int ngInd = 0, posInd = 0, k = 0;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    ngInd = i + 1;
                    break;
                } }
            for (int i = 0; i < n; i++) {
                if (arr[i] > 0) {
                   k++;
                   posInd = i+1;
                    if (k == 2) break;
                }
                
            }
            if (ngInd > posInd)
            {
                for (int i = posInd; i < ngInd; i++)
                    sumNgPos += arr[i];
            }
            else
            {
                for (int i = ngInd; i < posInd; i++)
                    sumNgPos += arr[i];
            }
            labelSumNgPos.Text += "= " + Math.Round(sumNgPos, 1).ToString();
        }

        private void buttonSumNulls_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double sumNulls = 0;
            int nll1Ind = 0, nll2Ind = 0;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    nll1Ind = i + 1;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    nll2Ind = i + 1;
                }

            }
            for (int i = nll1Ind; i < nll2Ind; i++)
                    sumNulls += arr[i];
            
            labelSumNulls.Text += "= " + Math.Round(sumNulls, 1).ToString();
        }

        private void buttonProductMinMax_Click(object sender, EventArgs e)
        {
            int n = dataArr.ColumnCount;
            double[] arr = new double[n];
            double productMinMax = 1;
            int minInd = 0, maxInd = 0;
            double min = double.MaxValue, max = double.MinValue;
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToDouble(dataArr[i, 0].Value.ToString());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min) minInd = i + 1;
                if (arr[i] > max) maxInd = i + 1;
            }
            if (minInd > maxInd)
            {
                for (int i = maxInd; i < minInd; i++)
                    productMinMax *= arr[i];
            }
            else
            {
                for (int i = minInd; i < maxInd; i++)
                    productMinMax += arr[i];
            }
            labelProductMinMax.Text += "= " + Math.Round(productMinMax, 1).ToString();
        }
    }
}
