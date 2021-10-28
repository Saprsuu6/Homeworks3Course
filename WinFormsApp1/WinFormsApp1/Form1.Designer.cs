
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Question = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayerFIO = new System.Windows.Forms.TextBox();
            this.Answer = new System.Windows.Forms.Button();
            this.CheckAnswers = new System.Windows.Forms.CheckedListBox();
            this.ComboQuestions = new System.Windows.Forms.ComboBox();
            this.AddQueestion = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.RightAnswers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Answers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextQuestion = new System.Windows.Forms.TextBox();
            this.AddQuestion = new System.Windows.Forms.TabControl();
            this.Result = new System.Windows.Forms.TabPage();
            this.ResultResult = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ResultPersonAnswers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultRightAnswers = new System.Windows.Forms.TextBox();
            this.ResultQuestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ResultFio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.Question.SuspendLayout();
            this.AddQueestion.SuspendLayout();
            this.AddQuestion.SuspendLayout();
            this.Result.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Controls.Add(this.label5);
            this.Question.Controls.Add(this.PlayerFIO);
            this.Question.Controls.Add(this.Answer);
            this.Question.Controls.Add(this.CheckAnswers);
            this.Question.Controls.Add(this.ComboQuestions);
            this.Question.Location = new System.Drawing.Point(4, 24);
            this.Question.Name = "Question";
            this.Question.Padding = new System.Windows.Forms.Padding(3);
            this.Question.Size = new System.Drawing.Size(376, 150);
            this.Question.TabIndex = 1;
            this.Question.Text = "Question";
            this.Question.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "FIO:";
            // 
            // PlayerFIO
            // 
            this.PlayerFIO.Location = new System.Drawing.Point(40, 6);
            this.PlayerFIO.Name = "PlayerFIO";
            this.PlayerFIO.Size = new System.Drawing.Size(328, 23);
            this.PlayerFIO.TabIndex = 9;
            // 
            // Answer
            // 
            this.Answer.Enabled = false;
            this.Answer.Location = new System.Drawing.Point(8, 110);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(360, 34);
            this.Answer.TabIndex = 2;
            this.Answer.Text = "Answer";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // CheckAnswers
            // 
            this.CheckAnswers.FormattingEnabled = true;
            this.CheckAnswers.Location = new System.Drawing.Point(8, 64);
            this.CheckAnswers.Name = "CheckAnswers";
            this.CheckAnswers.Size = new System.Drawing.Size(360, 40);
            this.CheckAnswers.TabIndex = 1;
            this.CheckAnswers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckAnswers_ItemCheck);
            // 
            // ComboQuestions
            // 
            this.ComboQuestions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboQuestions.FormattingEnabled = true;
            this.ComboQuestions.Location = new System.Drawing.Point(8, 35);
            this.ComboQuestions.Name = "ComboQuestions";
            this.ComboQuestions.Size = new System.Drawing.Size(360, 23);
            this.ComboQuestions.TabIndex = 0;
            this.ComboQuestions.SelectedIndexChanged += new System.EventHandler(this.ComboQuestions_SelectedIndexChanged);
            // 
            // AddQueestion
            // 
            this.AddQueestion.Controls.Add(this.label4);
            this.AddQueestion.Controls.Add(this.FIO);
            this.AddQueestion.Controls.Add(this.AddQuestionButton);
            this.AddQueestion.Controls.Add(this.RightAnswers);
            this.AddQueestion.Controls.Add(this.label3);
            this.AddQueestion.Controls.Add(this.Answers);
            this.AddQueestion.Controls.Add(this.label2);
            this.AddQueestion.Controls.Add(this.label1);
            this.AddQueestion.Controls.Add(this.TextQuestion);
            this.AddQueestion.Location = new System.Drawing.Point(4, 24);
            this.AddQueestion.Name = "AddQueestion";
            this.AddQueestion.Padding = new System.Windows.Forms.Padding(3);
            this.AddQueestion.Size = new System.Drawing.Size(376, 150);
            this.AddQueestion.TabIndex = 0;
            this.AddQueestion.Text = "Add question";
            this.AddQueestion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "FIO:";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(40, 6);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(328, 23);
            this.FIO.TabIndex = 7;
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Enabled = false;
            this.AddQuestionButton.Location = new System.Drawing.Point(6, 122);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(362, 23);
            this.AddQuestionButton.TabIndex = 6;
            this.AddQuestionButton.Text = "Add ";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // RightAnswers
            // 
            this.RightAnswers.Location = new System.Drawing.Point(95, 93);
            this.RightAnswers.Name = "RightAnswers";
            this.RightAnswers.Size = new System.Drawing.Size(273, 23);
            this.RightAnswers.TabIndex = 5;
            this.RightAnswers.TextChanged += new System.EventHandler(this.TextQuestion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Right answers:";
            // 
            // Answers
            // 
            this.Answers.Location = new System.Drawing.Point(70, 64);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(298, 23);
            this.Answers.TabIndex = 3;
            this.Answers.TextChanged += new System.EventHandler(this.TextQuestion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // TextQuestion
            // 
            this.TextQuestion.Location = new System.Drawing.Point(70, 35);
            this.TextQuestion.Name = "TextQuestion";
            this.TextQuestion.Size = new System.Drawing.Size(298, 23);
            this.TextQuestion.TabIndex = 0;
            this.TextQuestion.TextChanged += new System.EventHandler(this.TextQuestion_TextChanged);
            // 
            // AddQuestion
            // 
            this.AddQuestion.Controls.Add(this.AddQueestion);
            this.AddQuestion.Controls.Add(this.Question);
            this.AddQuestion.Controls.Add(this.Result);
            this.AddQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddQuestion.Location = new System.Drawing.Point(0, 0);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.SelectedIndex = 0;
            this.AddQuestion.Size = new System.Drawing.Size(384, 178);
            this.AddQuestion.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Controls.Add(this.ResultResult);
            this.Result.Controls.Add(this.label10);
            this.Result.Controls.Add(this.Save);
            this.Result.Controls.Add(this.label9);
            this.Result.Controls.Add(this.ResultPersonAnswers);
            this.Result.Controls.Add(this.label8);
            this.Result.Controls.Add(this.ResultRightAnswers);
            this.Result.Controls.Add(this.ResultQuestion);
            this.Result.Controls.Add(this.label7);
            this.Result.Controls.Add(this.ResultFio);
            this.Result.Controls.Add(this.label6);
            this.Result.Location = new System.Drawing.Point(4, 24);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(376, 150);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            // 
            // ResultResult
            // 
            this.ResultResult.Location = new System.Drawing.Point(56, 124);
            this.ResultResult.Name = "ResultResult";
            this.ResultResult.ReadOnly = true;
            this.ResultResult.Size = new System.Drawing.Size(139, 23);
            this.ResultResult.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Result:";
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(201, 124);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(167, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Your answer(s):";
            // 
            // ResultPersonAnswers
            // 
            this.ResultPersonAnswers.Location = new System.Drawing.Point(101, 95);
            this.ResultPersonAnswers.Name = "ResultPersonAnswers";
            this.ResultPersonAnswers.ReadOnly = true;
            this.ResultPersonAnswers.Size = new System.Drawing.Size(267, 23);
            this.ResultPersonAnswers.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Right answer(s):";
            // 
            // ResultRightAnswers
            // 
            this.ResultRightAnswers.Location = new System.Drawing.Point(105, 66);
            this.ResultRightAnswers.Name = "ResultRightAnswers";
            this.ResultRightAnswers.ReadOnly = true;
            this.ResultRightAnswers.Size = new System.Drawing.Size(263, 23);
            this.ResultRightAnswers.TabIndex = 4;
            // 
            // ResultQuestion
            // 
            this.ResultQuestion.Location = new System.Drawing.Point(72, 37);
            this.ResultQuestion.Name = "ResultQuestion";
            this.ResultQuestion.ReadOnly = true;
            this.ResultQuestion.Size = new System.Drawing.Size(296, 23);
            this.ResultQuestion.TabIndex = 3;
            this.ResultQuestion.TextChanged += new System.EventHandler(this.ResultQuestion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Question:";
            // 
            // ResultFio
            // 
            this.ResultFio.Location = new System.Drawing.Point(42, 8);
            this.ResultFio.Name = "ResultFio";
            this.ResultFio.ReadOnly = true;
            this.ResultFio.Size = new System.Drawing.Size(326, 23);
            this.ResultFio.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "FIO:";
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "txt";
            this.SaveFile.FileName = "Your last question";
            this.SaveFile.Filter = "Text files(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 178);
            this.Controls.Add(this.AddQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizz";
            this.Question.ResumeLayout(false);
            this.Question.PerformLayout();
            this.AddQueestion.ResumeLayout(false);
            this.AddQueestion.PerformLayout();
            this.AddQuestion.ResumeLayout(false);
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Question;
        private System.Windows.Forms.TabPage AddQueestion;
        private System.Windows.Forms.TabControl AddQuestion;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.TextBox RightAnswers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Answers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextQuestion;
        private System.Windows.Forms.ComboBox ComboQuestions;
        private System.Windows.Forms.CheckedListBox CheckAnswers;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlayerFIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResultFio;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ResultPersonAnswers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ResultRightAnswers;
        private System.Windows.Forms.TextBox ResultQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ResultResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}

