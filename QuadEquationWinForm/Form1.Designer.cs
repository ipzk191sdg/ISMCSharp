namespace QuadEquationWinForm
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(45, 38);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(25, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a = ";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(45, 64);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(25, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b = ";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(45, 90);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(25, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "c = ";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(46, 152);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(27, 13);
            this.labelD.TabIndex = 3;
            this.labelD.Text = "D = ";
            this.labelD.Visible = false;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(49, 178);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "x = ";
            this.labelX.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(43, 204);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(30, 13);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "x1 = ";
            this.labelX1.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(43, 230);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(30, 13);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "x2 = ";
            this.labelX2.Visible = false;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(76, 35);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 7;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(76, 61);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 8;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(76, 87);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 9;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(60, 113);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(79, 23);
            this.calculate.TabIndex = 10;
            this.calculate.Text = "Розрахувати";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // textBoxD
            // 
            this.textBoxD.Enabled = false;
            this.textBoxD.Location = new System.Drawing.Point(79, 149);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 20);
            this.textBoxD.TabIndex = 11;
            this.textBoxD.Visible = false;
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(79, 175);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 12;
            this.textBoxX.Visible = false;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Enabled = false;
            this.textBoxX1.Location = new System.Drawing.Point(79, 201);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 13;
            this.textBoxX1.Visible = false;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Enabled = false;
            this.textBoxX2.Location = new System.Drawing.Point(79, 227);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 14;
            this.textBoxX2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 270);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Завдання 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
    }
}

