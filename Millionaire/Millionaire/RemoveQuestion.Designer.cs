
namespace Millionaire
{
    partial class RemoveQuestion
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
            this.NumberOfQuestion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfQuestion
            // 
            this.NumberOfQuestion.Location = new System.Drawing.Point(170, 12);
            this.NumberOfQuestion.Name = "NumberOfQuestion";
            this.NumberOfQuestion.Size = new System.Drawing.Size(96, 23);
            this.NumberOfQuestion.TabIndex = 0;
            this.NumberOfQuestion.ValueChanged += new System.EventHandler(this.NumberOfQuestion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите номер вопроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вопрос:";
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(12, 74);
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Size = new System.Drawing.Size(254, 23);
            this.Question.TabIndex = 3;
            // 
            // Remove
            // 
            this.Remove.Enabled = false;
            this.Remove.Location = new System.Drawing.Point(12, 103);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(191, 103);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // RemoveQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 133);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove question";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumberOfQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Cancel;
    }
}