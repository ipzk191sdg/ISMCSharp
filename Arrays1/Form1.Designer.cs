namespace Arrays1
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
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonSumNg = new System.Windows.Forms.Button();
            this.labelSumNg = new System.Windows.Forms.Label();
            this.SumNg = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.buttonMax = new System.Windows.Forms.Button();
            this.MaxInd = new System.Windows.Forms.Label();
            this.labelMaxInd = new System.Windows.Forms.Label();
            this.buttonMaxInd = new System.Windows.Forms.Button();
            this.MaxAbs = new System.Windows.Forms.Label();
            this.labelMaxAbs = new System.Windows.Forms.Label();
            this.buttonMaxAbs = new System.Windows.Forms.Button();
            this.SumPosInd = new System.Windows.Forms.Label();
            this.labelSumPosInd = new System.Windows.Forms.Label();
            this.buttonSumPosInd = new System.Windows.Forms.Button();
            this.CountInt = new System.Windows.Forms.Label();
            this.labelCountInt = new System.Windows.Forms.Label();
            this.buttonCountInt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(344, 8);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(100, 36);
            this.buttonCount.TabIndex = 0;
            this.buttonCount.Text = "Додати";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // dataArr
            // 
            this.dataArr.AllowUserToAddRows = false;
            this.dataArr.AllowUserToDeleteRows = false;
            this.dataArr.AllowUserToOrderColumns = true;
            this.dataArr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArr.Location = new System.Drawing.Point(12, 57);
            this.dataArr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataArr.Name = "dataArr";
            this.dataArr.Size = new System.Drawing.Size(629, 230);
            this.dataArr.TabIndex = 1;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(12, 16);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(183, 20);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Введіть кількість елементів:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(205, 13);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(132, 26);
            this.textBoxN.TabIndex = 3;
            // 
            // buttonFill
            // 
            this.buttonFill.Enabled = false;
            this.buttonFill.Location = new System.Drawing.Point(451, 8);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(100, 36);
            this.buttonFill.TabIndex = 4;
            this.buttonFill.Text = "Заповнити";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonSumNg
            // 
            this.buttonSumNg.Location = new System.Drawing.Point(345, 295);
            this.buttonSumNg.Name = "buttonSumNg";
            this.buttonSumNg.Size = new System.Drawing.Size(99, 26);
            this.buttonSumNg.TabIndex = 5;
            this.buttonSumNg.Text = "Розрахувати";
            this.buttonSumNg.UseVisualStyleBackColor = true;
            this.buttonSumNg.Visible = false;
            this.buttonSumNg.Click += new System.EventHandler(this.buttonSumNg_Click);
            // 
            // labelSumNg
            // 
            this.labelSumNg.AutoSize = true;
            this.labelSumNg.Location = new System.Drawing.Point(12, 298);
            this.labelSumNg.Name = "labelSumNg";
            this.labelSumNg.Size = new System.Drawing.Size(218, 20);
            this.labelSumNg.TabIndex = 6;
            this.labelSumNg.Text = "Сума від’ємних елементів масиву";
            this.labelSumNg.Visible = false;
            // 
            // SumNg
            // 
            this.SumNg.AutoSize = true;
            this.SumNg.Location = new System.Drawing.Point(243, 298);
            this.SumNg.Name = "SumNg";
            this.SumNg.Size = new System.Drawing.Size(0, 20);
            this.SumNg.TabIndex = 7;
            this.SumNg.Visible = false;
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(243, 330);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(0, 20);
            this.Max.TabIndex = 10;
            this.Max.Visible = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(12, 330);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(156, 20);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Максимальний елемент";
            this.labelMax.Visible = false;
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(345, 326);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(99, 26);
            this.buttonMax.TabIndex = 8;
            this.buttonMax.Text = "Розрахувати";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Visible = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // MaxInd
            // 
            this.MaxInd.AutoSize = true;
            this.MaxInd.Location = new System.Drawing.Point(243, 361);
            this.MaxInd.Name = "MaxInd";
            this.MaxInd.Size = new System.Drawing.Size(0, 20);
            this.MaxInd.TabIndex = 13;
            this.MaxInd.Visible = false;
            // 
            // labelMaxInd
            // 
            this.labelMaxInd.AutoSize = true;
            this.labelMaxInd.Location = new System.Drawing.Point(12, 361);
            this.labelMaxInd.Name = "labelMaxInd";
            this.labelMaxInd.Size = new System.Drawing.Size(211, 20);
            this.labelMaxInd.TabIndex = 12;
            this.labelMaxInd.Text = "Індекс максимального елемента";
            this.labelMaxInd.Visible = false;
            // 
            // buttonMaxInd
            // 
            this.buttonMaxInd.Location = new System.Drawing.Point(345, 357);
            this.buttonMaxInd.Name = "buttonMaxInd";
            this.buttonMaxInd.Size = new System.Drawing.Size(99, 26);
            this.buttonMaxInd.TabIndex = 11;
            this.buttonMaxInd.Text = "Розрахувати";
            this.buttonMaxInd.UseVisualStyleBackColor = true;
            this.buttonMaxInd.Visible = false;
            this.buttonMaxInd.Click += new System.EventHandler(this.buttonMaxInd_Click);
            // 
            // MaxAbs
            // 
            this.MaxAbs.AutoSize = true;
            this.MaxAbs.Location = new System.Drawing.Point(272, 395);
            this.MaxAbs.Name = "MaxAbs";
            this.MaxAbs.Size = new System.Drawing.Size(0, 20);
            this.MaxAbs.TabIndex = 16;
            this.MaxAbs.Visible = false;
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.Location = new System.Drawing.Point(11, 395);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(234, 20);
            this.labelMaxAbs.TabIndex = 15;
            this.labelMaxAbs.Text = "Максимальний елемент за модулем";
            this.labelMaxAbs.Visible = false;
            // 
            // buttonMaxAbs
            // 
            this.buttonMaxAbs.Location = new System.Drawing.Point(345, 389);
            this.buttonMaxAbs.Name = "buttonMaxAbs";
            this.buttonMaxAbs.Size = new System.Drawing.Size(99, 26);
            this.buttonMaxAbs.TabIndex = 14;
            this.buttonMaxAbs.Text = "Розрахувати";
            this.buttonMaxAbs.UseVisualStyleBackColor = true;
            this.buttonMaxAbs.Visible = false;
            this.buttonMaxAbs.Click += new System.EventHandler(this.buttonMaxAbs_Click);
            // 
            // SumPosInd
            // 
            this.SumPosInd.AutoSize = true;
            this.SumPosInd.Location = new System.Drawing.Point(256, 423);
            this.SumPosInd.Name = "SumPosInd";
            this.SumPosInd.Size = new System.Drawing.Size(0, 20);
            this.SumPosInd.TabIndex = 19;
            this.SumPosInd.Visible = false;
            // 
            // labelSumPosInd
            // 
            this.labelSumPosInd.AutoSize = true;
            this.labelSumPosInd.Location = new System.Drawing.Point(11, 423);
            this.labelSumPosInd.Name = "labelSumPosInd";
            this.labelSumPosInd.Size = new System.Drawing.Size(222, 20);
            this.labelSumPosInd.TabIndex = 18;
            this.labelSumPosInd.Text = "Сума індексів додатних елементів";
            this.labelSumPosInd.Visible = false;
            // 
            // buttonSumPosInd
            // 
            this.buttonSumPosInd.Location = new System.Drawing.Point(345, 419);
            this.buttonSumPosInd.Name = "buttonSumPosInd";
            this.buttonSumPosInd.Size = new System.Drawing.Size(99, 26);
            this.buttonSumPosInd.TabIndex = 17;
            this.buttonSumPosInd.Text = "Розрахувати";
            this.buttonSumPosInd.UseVisualStyleBackColor = true;
            this.buttonSumPosInd.Visible = false;
            this.buttonSumPosInd.Click += new System.EventHandler(this.buttonSumPosInd_Click);
            // 
            // CountInt
            // 
            this.CountInt.AutoSize = true;
            this.CountInt.Location = new System.Drawing.Point(242, 454);
            this.CountInt.Name = "CountInt";
            this.CountInt.Size = new System.Drawing.Size(0, 20);
            this.CountInt.TabIndex = 22;
            this.CountInt.Visible = false;
            // 
            // labelCountInt
            // 
            this.labelCountInt.AutoSize = true;
            this.labelCountInt.Location = new System.Drawing.Point(11, 454);
            this.labelCountInt.Name = "labelCountInt";
            this.labelCountInt.Size = new System.Drawing.Size(196, 20);
            this.labelCountInt.TabIndex = 21;
            this.labelCountInt.Text = "Кількість цілих чисел у масиві";
            this.labelCountInt.Visible = false;
            // 
            // buttonCountInt
            // 
            this.buttonCountInt.Location = new System.Drawing.Point(344, 450);
            this.buttonCountInt.Name = "buttonCountInt";
            this.buttonCountInt.Size = new System.Drawing.Size(99, 26);
            this.buttonCountInt.TabIndex = 20;
            this.buttonCountInt.Text = "Розрахувати";
            this.buttonCountInt.UseVisualStyleBackColor = true;
            this.buttonCountInt.Visible = false;
            this.buttonCountInt.Click += new System.EventHandler(this.buttonCountInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 483);
            this.Controls.Add(this.CountInt);
            this.Controls.Add(this.labelCountInt);
            this.Controls.Add(this.buttonCountInt);
            this.Controls.Add(this.SumPosInd);
            this.Controls.Add(this.labelSumPosInd);
            this.Controls.Add(this.buttonSumPosInd);
            this.Controls.Add(this.MaxAbs);
            this.Controls.Add(this.labelMaxAbs);
            this.Controls.Add(this.buttonMaxAbs);
            this.Controls.Add(this.MaxInd);
            this.Controls.Add(this.labelMaxInd);
            this.Controls.Add(this.buttonMaxInd);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.SumNg);
            this.Controls.Add(this.labelSumNg);
            this.Controls.Add(this.buttonSumNg);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.dataArr);
            this.Controls.Add(this.buttonCount);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(668, 522);
            this.Name = "Form1";
            this.Text = "Завдання 1";
            ((System.ComponentModel.ISupportInitialize)(this.dataArr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DataGridView dataArr;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonSumNg;
        private System.Windows.Forms.Label labelSumNg;
        private System.Windows.Forms.Label SumNg;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Label MaxInd;
        private System.Windows.Forms.Label labelMaxInd;
        private System.Windows.Forms.Button buttonMaxInd;
        private System.Windows.Forms.Label MaxAbs;
        private System.Windows.Forms.Label labelMaxAbs;
        private System.Windows.Forms.Button buttonMaxAbs;
        private System.Windows.Forms.Label SumPosInd;
        private System.Windows.Forms.Label labelSumPosInd;
        private System.Windows.Forms.Button buttonSumPosInd;
        private System.Windows.Forms.Label CountInt;
        private System.Windows.Forms.Label labelCountInt;
        private System.Windows.Forms.Button buttonCountInt;
    }
}

