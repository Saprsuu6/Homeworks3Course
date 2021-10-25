namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Line = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearOne = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Diverce = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Is = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Line.Location = new System.Drawing.Point(5, 6);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(254, 22);
            this.Line.TabIndex = 0;
            this.Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(135, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "+/-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // ClearOne
            // 
            this.ClearOne.FlatAppearance.BorderSize = 0;
            this.ClearOne.Location = new System.Drawing.Point(70, 34);
            this.ClearOne.Name = "ClearOne";
            this.ClearOne.Size = new System.Drawing.Size(59, 34);
            this.ClearOne.TabIndex = 2;
            this.ClearOne.Text = "<--";
            this.ClearOne.UseVisualStyleBackColor = true;
            this.ClearOne.Click += new System.EventHandler(this.ClearOne_Click);
            // 
            // Clear
            // 
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.Location = new System.Drawing.Point(4, 34);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(59, 34);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "С";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Plus
            // 
            this.Plus.FlatAppearance.BorderSize = 0;
            this.Plus.Location = new System.Drawing.Point(199, 34);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(60, 34);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(5, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 34);
            this.button5.TabIndex = 5;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(70, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(135, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 34);
            this.button7.TabIndex = 7;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Minus
            // 
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.Location = new System.Drawing.Point(200, 74);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(59, 34);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.Location = new System.Drawing.Point(5, 114);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 34);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Location = new System.Drawing.Point(70, 114);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 34);
            this.button10.TabIndex = 10;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Location = new System.Drawing.Point(135, 114);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 34);
            this.button11.TabIndex = 11;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.FlatAppearance.BorderSize = 0;
            this.Multiplication.Location = new System.Drawing.Point(200, 114);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(59, 34);
            this.Multiplication.TabIndex = 12;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.Location = new System.Drawing.Point(5, 154);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 34);
            this.button13.TabIndex = 13;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.Location = new System.Drawing.Point(70, 154);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(59, 34);
            this.button14.TabIndex = 14;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.Location = new System.Drawing.Point(135, 154);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 34);
            this.button15.TabIndex = 15;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Diverce
            // 
            this.Diverce.FlatAppearance.BorderSize = 0;
            this.Diverce.Location = new System.Drawing.Point(199, 154);
            this.Diverce.Name = "Diverce";
            this.Diverce.Size = new System.Drawing.Size(60, 34);
            this.Diverce.TabIndex = 16;
            this.Diverce.Text = "/";
            this.Diverce.UseVisualStyleBackColor = true;
            this.Diverce.Click += new System.EventHandler(this.Diverce_Click);
            // 
            // button17
            // 
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.Location = new System.Drawing.Point(5, 194);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(59, 34);
            this.button17.TabIndex = 17;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Dot
            // 
            this.Dot.FlatAppearance.BorderSize = 0;
            this.Dot.Location = new System.Drawing.Point(70, 194);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(59, 34);
            this.Dot.TabIndex = 18;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Is
            // 
            this.Is.FlatAppearance.BorderSize = 0;
            this.Is.Location = new System.Drawing.Point(134, 194);
            this.Is.Name = "Is";
            this.Is.Size = new System.Drawing.Size(125, 34);
            this.Is.TabIndex = 19;
            this.Is.Text = "=";
            this.Is.UseVisualStyleBackColor = true;
            this.Is.Click += new System.EventHandler(this.Is_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(264, 233);
            this.Controls.Add(this.Is);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.Diverce);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Line);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Line;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearOne;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Diverce;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Is;
    }
}

