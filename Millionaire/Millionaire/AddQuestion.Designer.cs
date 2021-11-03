
namespace Millionaire
{
    partial class AddQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.AddQuestionBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddRightAnswerBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddAnswer1 = new System.Windows.Forms.TextBox();
            this.AddAnswer2 = new System.Windows.Forms.TextBox();
            this.AddAnswer3 = new System.Windows.Forms.TextBox();
            this.AddAnswer4 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вопрос:";
            // 
            // AddQuestionBox
            // 
            this.AddQuestionBox.Location = new System.Drawing.Point(12, 27);
            this.AddQuestionBox.Name = "AddQuestionBox";
            this.AddQuestionBox.Size = new System.Drawing.Size(312, 23);
            this.AddQuestionBox.TabIndex = 1;
            this.AddQuestionBox.TextChanged += new System.EventHandler(this.AddQuestionBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите правильный варриант ответа:";
            // 
            // AddRightAnswerBox
            // 
            this.AddRightAnswerBox.Location = new System.Drawing.Point(12, 71);
            this.AddRightAnswerBox.Name = "AddRightAnswerBox";
            this.AddRightAnswerBox.Size = new System.Drawing.Size(312, 23);
            this.AddRightAnswerBox.TabIndex = 3;
            this.AddRightAnswerBox.TextChanged += new System.EventHandler(this.AddQuestionBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите первый ответ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите второй ответ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите третий ответ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Введите четвёртый ответ:";
            // 
            // AddAnswer1
            // 
            this.AddAnswer1.Location = new System.Drawing.Point(12, 115);
            this.AddAnswer1.Name = "AddAnswer1";
            this.AddAnswer1.Size = new System.Drawing.Size(312, 23);
            this.AddAnswer1.TabIndex = 8;
            this.AddAnswer1.TextChanged += new System.EventHandler(this.AddQuestionBox_TextChanged);
            // 
            // AddAnswer2
            // 
            this.AddAnswer2.Location = new System.Drawing.Point(12, 159);
            this.AddAnswer2.Name = "AddAnswer2";
            this.AddAnswer2.Size = new System.Drawing.Size(312, 23);
            this.AddAnswer2.TabIndex = 9;
            this.AddAnswer2.TextChanged += new System.EventHandler(this.AddQuestionBox_TextChanged);
            // 
            // AddAnswer3
            // 
            this.AddAnswer3.Location = new System.Drawing.Point(12, 203);
            this.AddAnswer3.Name = "AddAnswer3";
            this.AddAnswer3.Size = new System.Drawing.Size(312, 23);
            this.AddAnswer3.TabIndex = 10;
            this.AddAnswer3.TextChanged += new System.EventHandler(this.AddQuestionBox_TextChanged);
            // 
            // AddAnswer4
            // 
            this.AddAnswer4.Location = new System.Drawing.Point(12, 247);
            this.AddAnswer4.Name = "AddAnswer4";
            this.AddAnswer4.Size = new System.Drawing.Size(312, 23);
            this.AddAnswer4.TabIndex = 11;
            this.AddAnswer4.TextChanged += new System.EventHandler(this.AddQuestionBox_TextChanged);
            // 
            // Add
            // 
            this.Add.Enabled = false;
            this.Add.Location = new System.Drawing.Point(12, 276);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(249, 276);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 305);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddAnswer4);
            this.Controls.Add(this.AddAnswer3);
            this.Controls.Add(this.AddAnswer2);
            this.Controls.Add(this.AddAnswer1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddRightAnswerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddQuestionBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddQuestionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddRightAnswerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddAnswer1;
        private System.Windows.Forms.TextBox AddAnswer2;
        private System.Windows.Forms.TextBox AddAnswer3;
        private System.Windows.Forms.TextBox AddAnswer4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}