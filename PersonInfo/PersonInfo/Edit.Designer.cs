
namespace PersonInfo
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.Save = new System.Windows.Forms.Button();
            this.Patronimic = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WithFamily = new System.Windows.Forms.RadioButton();
            this.WithoutFamily = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.Man = new System.Windows.Forms.RadioButton();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.PersonName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.GreenYellow;
            this.Save.Enabled = false;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(7, 260);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(285, 23);
            this.Save.TabIndex = 36;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Patronimic
            // 
            this.Patronimic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Patronimic.Location = new System.Drawing.Point(116, 58);
            this.Patronimic.Name = "Patronimic";
            this.Patronimic.Size = new System.Drawing.Size(176, 16);
            this.Patronimic.TabIndex = 35;
            this.Patronimic.TextChanged += new System.EventHandler(this.Patronimic_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WithFamily);
            this.groupBox2.Controls.Add(this.WithoutFamily);
            this.groupBox2.Location = new System.Drawing.Point(116, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 35);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // WithFamily
            // 
            this.WithFamily.AutoSize = true;
            this.WithFamily.Location = new System.Drawing.Point(91, 12);
            this.WithFamily.Name = "WithFamily";
            this.WithFamily.Size = new System.Drawing.Size(84, 19);
            this.WithFamily.TabIndex = 1;
            this.WithFamily.TabStop = true;
            this.WithFamily.Text = "Есть семья";
            this.WithFamily.UseVisualStyleBackColor = true;
            // 
            // WithoutFamily
            // 
            this.WithoutFamily.AutoSize = true;
            this.WithoutFamily.Location = new System.Drawing.Point(6, 12);
            this.WithoutFamily.Name = "WithoutFamily";
            this.WithoutFamily.Size = new System.Drawing.Size(80, 19);
            this.WithoutFamily.TabIndex = 0;
            this.WithoutFamily.TabStop = true;
            this.WithoutFamily.Text = "Без семьи";
            this.WithoutFamily.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Woman);
            this.groupBox1.Controls.Add(this.Man);
            this.groupBox1.Location = new System.Drawing.Point(116, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 35);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.Location = new System.Drawing.Point(90, 11);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(80, 19);
            this.Woman.TabIndex = 1;
            this.Woman.TabStop = true;
            this.Woman.Text = "Женщина";
            this.Woman.UseVisualStyleBackColor = true;
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Location = new System.Drawing.Point(6, 11);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(78, 19);
            this.Man.TabIndex = 0;
            this.Man.TabStop = true;
            this.Man.Text = "Мужчина";
            this.Man.UseVisualStyleBackColor = true;
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(116, 112);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(176, 23);
            this.Birthday.TabIndex = 32;
            // 
            // PersonName
            // 
            this.PersonName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonName.Location = new System.Drawing.Point(116, 34);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(176, 16);
            this.PersonName.TabIndex = 31;
            this.PersonName.TextChanged += new System.EventHandler(this.PersonName_TextChanged);
            // 
            // Surname
            // 
            this.Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Surname.Location = new System.Drawing.Point(116, 9);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(176, 16);
            this.Surname.TabIndex = 30;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // Info
            // 
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.Location = new System.Drawing.Point(116, 180);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(176, 74);
            this.Info.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Доп. информация:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Семейный статус:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Пол:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Отчество: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Имя: *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Фамилия: *";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(299, 292);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Patronimic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.PersonName);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Patronimic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton WithFamily;
        private System.Windows.Forms.RadioButton WithoutFamily;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.TextBox PersonName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}