namespace Arrays2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCount = new System.Windows.Forms.Button();
            this.dataArr = new System.Windows.Forms.DataGridView();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonSumNgPos = new System.Windows.Forms.Button();
            this.labelSumNgPos = new System.Windows.Forms.Label();
            this.buttonSumNulls = new System.Windows.Forms.Button();
            this.labelSumNulls = new System.Windows.Forms.Label();
            this.buttonProductMinMax = new System.Windows.Forms.Button();
            this.labelProductMinMax = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(340, 9);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(100, 26);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Добавити";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // dataArr
            // 
            this.dataArr.AllowUserToAddRows = false;
            this.dataArr.AllowUserToDeleteRows = false;
            this.dataArr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArr.Location = new System.Drawing.Point(17, 45);
            this.dataArr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataArr.Name = "dataArr";
            this.dataArr.Size = new System.Drawing.Size(824, 231);
            this.dataArr.TabIndex = 1;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(13, 9);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(179, 20);
            this.labelCount.TabIndex = 2;
            this.labelCount.Text = "Введіть кількість елементів";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(200, 9);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(132, 26);
            this.textBoxCount.TabIndex = 3;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(17, 285);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(468, 20);
            this.labelProduct.TabIndex = 4;
            this.labelProduct.Text = "Добуток елементів масиву, що розташовані після мінімального елемента";
            this.labelProduct.Visible = false;
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(739, 280);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(102, 31);
            this.buttonProduct.TabIndex = 5;
            this.buttonProduct.Text = "Розрахувати";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Visible = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Enabled = false;
            this.buttonFill.Location = new System.Drawing.Point(448, 9);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(100, 26);
            this.buttonFill.TabIndex = 6;
            this.buttonFill.Text = "Заповнити";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonSumNgPos
            // 
            this.buttonSumNgPos.Location = new System.Drawing.Point(739, 317);
            this.buttonSumNgPos.Name = "buttonSumNgPos";
            this.buttonSumNgPos.Size = new System.Drawing.Size(102, 31);
            this.buttonSumNgPos.TabIndex = 8;
            this.buttonSumNgPos.Text = "Розрахувати";
            this.buttonSumNgPos.UseVisualStyleBackColor = true;
            this.buttonSumNgPos.Visible = false;
            this.buttonSumNgPos.Click += new System.EventHandler(this.buttonSumNgPos_Click);
            // 
            // labelSumNgPos
            // 
            this.labelSumNgPos.AutoSize = true;
            this.labelSumNgPos.Location = new System.Drawing.Point(17, 322);
            this.labelSumNgPos.Name = "labelSumNgPos";
            this.labelSumNgPos.Size = new System.Drawing.Size(566, 20);
            this.labelSumNgPos.TabIndex = 7;
            this.labelSumNgPos.Text = "Сума елементів, що розташовані між першим від\'ємним та другим додатним елементами" +
    "";
            this.labelSumNgPos.Visible = false;
            // 
            // buttonSumNulls
            // 
            this.buttonSumNulls.Location = new System.Drawing.Point(739, 354);
            this.buttonSumNulls.Name = "buttonSumNulls";
            this.buttonSumNulls.Size = new System.Drawing.Size(102, 31);
            this.buttonSumNulls.TabIndex = 10;
            this.buttonSumNulls.Text = "Розрахувати";
            this.buttonSumNulls.UseVisualStyleBackColor = true;
            this.buttonSumNulls.Visible = false;
            this.buttonSumNulls.Click += new System.EventHandler(this.buttonSumNulls_Click);
            // 
            // labelSumNulls
            // 
            this.labelSumNulls.AutoSize = true;
            this.labelSumNulls.Location = new System.Drawing.Point(17, 359);
            this.labelSumNulls.Name = "labelSumNulls";
            this.labelSumNulls.Size = new System.Drawing.Size(507, 20);
            this.labelSumNulls.TabIndex = 9;
            this.labelSumNulls.Text = "Cума елементів, які розташовані між першим і останнім нульовими елементами";
            this.labelSumNulls.Visible = false;
            // 
            // buttonProductMinMax
            // 
            this.buttonProductMinMax.Location = new System.Drawing.Point(739, 393);
            this.buttonProductMinMax.Name = "buttonProductMinMax";
            this.buttonProductMinMax.Size = new System.Drawing.Size(102, 31);
            this.buttonProductMinMax.TabIndex = 12;
            this.buttonProductMinMax.Text = "Розрахувати";
            this.buttonProductMinMax.UseVisualStyleBackColor = true;
            this.buttonProductMinMax.Visible = false;
            this.buttonProductMinMax.Click += new System.EventHandler(this.buttonProductMinMax_Click);
            // 
            // labelProductMinMax
            // 
            this.labelProductMinMax.AutoSize = true;
            this.labelProductMinMax.Location = new System.Drawing.Point(17, 398);
            this.labelProductMinMax.Name = "labelProductMinMax";
            this.labelProductMinMax.Size = new System.Drawing.Size(677, 20);
            this.labelProductMinMax.TabIndex = 11;
            this.labelProductMinMax.Text = "Добуток елементів, що розташовані між максимальним за модулем і мінімальним за мо" +
    "дулем елементами";
            this.labelProductMinMax.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 692);
            this.Controls.Add(this.buttonProductMinMax);
            this.Controls.Add(this.labelProductMinMax);
            this.Controls.Add(this.buttonSumNulls);
            this.Controls.Add(this.labelSumNulls);
            this.Controls.Add(this.buttonSumNgPos);
            this.Controls.Add(this.labelSumNgPos);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.dataArr);
            this.Controls.Add(this.buttonCount);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(697, 39);
            this.Name = "Form1";
            this.Text = "Завдання 2";
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DataGridView dataArr;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonSumNgPos;
        private System.Windows.Forms.Label labelSumNgPos;
        private System.Windows.Forms.Button buttonSumNulls;
        private System.Windows.Forms.Label labelSumNulls;
        private System.Windows.Forms.Button buttonProductMinMax;
        private System.Windows.Forms.Label labelProductMinMax;
    }
}

