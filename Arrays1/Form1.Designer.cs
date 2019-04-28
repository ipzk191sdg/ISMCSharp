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
            this.buttonCount.Location = new System.Drawing.Point(387, 9);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(112, 41);
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
            this.dataArr.Location = new System.Drawing.Point(13, 66);
            this.dataArr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataArr.Name = "dataArr";
            this.dataArr.Size = new System.Drawing.Size(708, 265);
            this.dataArr.TabIndex = 1;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(13, 18);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(210, 23);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Введіть кількість елементів:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(231, 15);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(148, 29);
            this.textBoxN.TabIndex = 3;
            // 
            // buttonFill
            // 
            this.buttonFill.Enabled = false;
            this.buttonFill.Location = new System.Drawing.Point(507, 9);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(112, 41);
            this.buttonFill.TabIndex = 4;
            this.buttonFill.Text = "Заповнити";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonSumNg
            // 
            this.buttonSumNg.Location = new System.Drawing.Point(388, 339);
            this.buttonSumNg.Name = "buttonSumNg";
            this.buttonSumNg.Size = new System.Drawing.Size(111, 30);
            this.buttonSumNg.TabIndex = 5;
            this.buttonSumNg.Text = "Розрахувати";
            this.buttonSumNg.UseVisualStyleBackColor = true;
            this.buttonSumNg.Visible = false;
            this.buttonSumNg.Click += new System.EventHandler(this.buttonSumNg_Click);
            // 
            // labelSumNg
            // 
            this.labelSumNg.AutoSize = true;
            this.labelSumNg.Location = new System.Drawing.Point(13, 343);
            this.labelSumNg.Name = "labelSumNg";
            this.labelSumNg.Size = new System.Drawing.Size(254, 23);
            this.labelSumNg.TabIndex = 6;
            this.labelSumNg.Text = "Сума від’ємних елементів масиву";
            this.labelSumNg.Visible = false;
            // 
            // SumNg
            // 
            this.SumNg.AutoSize = true;
            this.SumNg.Location = new System.Drawing.Point(273, 343);
            this.SumNg.Name = "SumNg";
            this.SumNg.Size = new System.Drawing.Size(0, 23);
            this.SumNg.TabIndex = 7;
            this.SumNg.Visible = false;
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(273, 379);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(0, 23);
            this.Max.TabIndex = 10;
            this.Max.Visible = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(13, 379);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(187, 23);
            this.labelMax.TabIndex = 9;
            this.labelMax.Text = "Максимальний елемент";
            this.labelMax.Visible = false;
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(388, 375);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(111, 30);
            this.buttonMax.TabIndex = 8;
            this.buttonMax.Text = "Розрахувати";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Visible = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // MaxInd
            // 
            this.MaxInd.AutoSize = true;
            this.MaxInd.Location = new System.Drawing.Point(273, 415);
            this.MaxInd.Name = "MaxInd";
            this.MaxInd.Size = new System.Drawing.Size(0, 23);
            this.MaxInd.TabIndex = 13;
            this.MaxInd.Visible = false;
            // 
            // labelMaxInd
            // 
            this.labelMaxInd.AutoSize = true;
            this.labelMaxInd.Location = new System.Drawing.Point(13, 415);
            this.labelMaxInd.Name = "labelMaxInd";
            this.labelMaxInd.Size = new System.Drawing.Size(249, 23);
            this.labelMaxInd.TabIndex = 12;
            this.labelMaxInd.Text = "Індекс максимального елемента";
            this.labelMaxInd.Visible = false;
            // 
            // buttonMaxInd
            // 
            this.buttonMaxInd.Location = new System.Drawing.Point(388, 411);
            this.buttonMaxInd.Name = "buttonMaxInd";
            this.buttonMaxInd.Size = new System.Drawing.Size(111, 30);
            this.buttonMaxInd.TabIndex = 11;
            this.buttonMaxInd.Text = "Розрахувати";
            this.buttonMaxInd.UseVisualStyleBackColor = true;
            this.buttonMaxInd.Visible = false;
            this.buttonMaxInd.Click += new System.EventHandler(this.buttonMaxInd_Click);
            // 
            // MaxAbs
            // 
            this.MaxAbs.AutoSize = true;
            this.MaxAbs.Location = new System.Drawing.Point(306, 454);
            this.MaxAbs.Name = "MaxAbs";
            this.MaxAbs.Size = new System.Drawing.Size(0, 23);
            this.MaxAbs.TabIndex = 16;
            this.MaxAbs.Visible = false;
            // 
            // labelMaxAbs
            // 
            this.labelMaxAbs.AutoSize = true;
            this.labelMaxAbs.Location = new System.Drawing.Point(12, 454);
            this.labelMaxAbs.Name = "labelMaxAbs";
            this.labelMaxAbs.Size = new System.Drawing.Size(276, 23);
            this.labelMaxAbs.TabIndex = 15;
            this.labelMaxAbs.Text = "Максимальний елемент за модулем";
            this.labelMaxAbs.Visible = false;
            // 
            // buttonMaxAbs
            // 
            this.buttonMaxAbs.Location = new System.Drawing.Point(388, 447);
            this.buttonMaxAbs.Name = "buttonMaxAbs";
            this.buttonMaxAbs.Size = new System.Drawing.Size(111, 30);
            this.buttonMaxAbs.TabIndex = 14;
            this.buttonMaxAbs.Text = "Розрахувати";
            this.buttonMaxAbs.UseVisualStyleBackColor = true;
            this.buttonMaxAbs.Visible = false;
            this.buttonMaxAbs.Click += new System.EventHandler(this.buttonMaxAbs_Click);
            // 
            // SumPosInd
            // 
            this.SumPosInd.AutoSize = true;
            this.SumPosInd.Location = new System.Drawing.Point(288, 486);
            this.SumPosInd.Name = "SumPosInd";
            this.SumPosInd.Size = new System.Drawing.Size(0, 23);
            this.SumPosInd.TabIndex = 19;
            this.SumPosInd.Visible = false;
            // 
            // labelSumPosInd
            // 
            this.labelSumPosInd.AutoSize = true;
            this.labelSumPosInd.Location = new System.Drawing.Point(12, 486);
            this.labelSumPosInd.Name = "labelSumPosInd";
            this.labelSumPosInd.Size = new System.Drawing.Size(259, 23);
            this.labelSumPosInd.TabIndex = 18;
            this.labelSumPosInd.Text = "Сума індексів додатних елементів";
            this.labelSumPosInd.Visible = false;
            // 
            // buttonSumPosInd
            // 
            this.buttonSumPosInd.Location = new System.Drawing.Point(388, 482);
            this.buttonSumPosInd.Name = "buttonSumPosInd";
            this.buttonSumPosInd.Size = new System.Drawing.Size(111, 30);
            this.buttonSumPosInd.TabIndex = 17;
            this.buttonSumPosInd.Text = "Розрахувати";
            this.buttonSumPosInd.UseVisualStyleBackColor = true;
            this.buttonSumPosInd.Visible = false;
            this.buttonSumPosInd.Click += new System.EventHandler(this.buttonSumPosInd_Click);
            // 
            // CountInt
            // 
            this.CountInt.AutoSize = true;
            this.CountInt.Location = new System.Drawing.Point(272, 522);
            this.CountInt.Name = "CountInt";
            this.CountInt.Size = new System.Drawing.Size(0, 23);
            this.CountInt.TabIndex = 22;
            this.CountInt.Visible = false;
            // 
            // labelCountInt
            // 
            this.labelCountInt.AutoSize = true;
            this.labelCountInt.Location = new System.Drawing.Point(12, 522);
            this.labelCountInt.Name = "labelCountInt";
            this.labelCountInt.Size = new System.Drawing.Size(224, 23);
            this.labelCountInt.TabIndex = 21;
            this.labelCountInt.Text = "Кількість цілих чисел у масиві";
            this.labelCountInt.Visible = false;
            // 
            // buttonCountInt
            // 
            this.buttonCountInt.Location = new System.Drawing.Point(387, 518);
            this.buttonCountInt.Name = "buttonCountInt";
            this.buttonCountInt.Size = new System.Drawing.Size(111, 30);
            this.buttonCountInt.TabIndex = 20;
            this.buttonCountInt.Text = "Розрахувати";
            this.buttonCountInt.UseVisualStyleBackColor = true;
            this.buttonCountInt.Visible = false;
            this.buttonCountInt.Click += new System.EventHandler(this.buttonCountInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 556);
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
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(750, 595);
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

