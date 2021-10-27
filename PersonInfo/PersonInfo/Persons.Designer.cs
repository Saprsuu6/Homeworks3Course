
namespace PersonInfo
{
    partial class Persons
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persons));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.PersonName = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Женщина = new System.Windows.Forms.RadioButton();
            this.Мужчина = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ЕстьСемья = new System.Windows.Forms.RadioButton();
            this.БезСемьи = new System.Windows.Forms.RadioButton();
            this.Patronimic = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Семейный статус:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Доп. информация:";
            // 
            // Info
            // 
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.Location = new System.Drawing.Point(116, 181);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(176, 74);
            this.Info.TabIndex = 7;
            // 
            // Surname
            // 
            this.Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Surname.Location = new System.Drawing.Point(116, 10);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(176, 16);
            this.Surname.TabIndex = 8;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // PersonName
            // 
            this.PersonName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonName.Location = new System.Drawing.Point(116, 35);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(176, 16);
            this.PersonName.TabIndex = 9;
            this.PersonName.TextChanged += new System.EventHandler(this.PersonName_TextChanged);
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(116, 113);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(176, 23);
            this.Birthday.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Женщина);
            this.groupBox1.Controls.Add(this.Мужчина);
            this.groupBox1.Location = new System.Drawing.Point(116, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 35);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Женщина
            // 
            this.Женщина.AutoSize = true;
            this.Женщина.Location = new System.Drawing.Point(90, 11);
            this.Женщина.Name = "Женщина";
            this.Женщина.Size = new System.Drawing.Size(80, 19);
            this.Женщина.TabIndex = 1;
            this.Женщина.TabStop = true;
            this.Женщина.Text = "Женщина";
            this.Женщина.UseVisualStyleBackColor = true;
            // 
            // Мужчина
            // 
            this.Мужчина.AutoSize = true;
            this.Мужчина.Location = new System.Drawing.Point(6, 11);
            this.Мужчина.Name = "Мужчина";
            this.Мужчина.Size = new System.Drawing.Size(78, 19);
            this.Мужчина.TabIndex = 0;
            this.Мужчина.TabStop = true;
            this.Мужчина.Text = "Мужчина";
            this.Мужчина.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ЕстьСемья);
            this.groupBox2.Controls.Add(this.БезСемьи);
            this.groupBox2.Location = new System.Drawing.Point(116, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 35);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // ЕстьСемья
            // 
            this.ЕстьСемья.AutoSize = true;
            this.ЕстьСемья.Location = new System.Drawing.Point(91, 12);
            this.ЕстьСемья.Name = "ЕстьСемья";
            this.ЕстьСемья.Size = new System.Drawing.Size(84, 19);
            this.ЕстьСемья.TabIndex = 1;
            this.ЕстьСемья.TabStop = true;
            this.ЕстьСемья.Text = "Есть семья";
            this.ЕстьСемья.UseVisualStyleBackColor = true;
            // 
            // БезСемьи
            // 
            this.БезСемьи.AutoSize = true;
            this.БезСемьи.Location = new System.Drawing.Point(6, 12);
            this.БезСемьи.Name = "БезСемьи";
            this.БезСемьи.Size = new System.Drawing.Size(80, 19);
            this.БезСемьи.TabIndex = 0;
            this.БезСемьи.TabStop = true;
            this.БезСемьи.Text = "Без семьи";
            this.БезСемьи.UseVisualStyleBackColor = true;
            // 
            // Patronimic
            // 
            this.Patronimic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Patronimic.Location = new System.Drawing.Point(116, 59);
            this.Patronimic.Name = "Patronimic";
            this.Patronimic.Size = new System.Drawing.Size(176, 16);
            this.Patronimic.TabIndex = 18;
            this.Patronimic.TextChanged += new System.EventHandler(this.Patronimic_TextChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.GreenYellow;
            this.Save.Enabled = false;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(7, 261);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(285, 23);
            this.Save.TabIndex = 19;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // List
            // 
            this.List.ContextMenuStrip = this.contextMenuStrip1;
            this.List.FormattingEnabled = true;
            this.List.HorizontalScrollbar = true;
            this.List.ItemHeight = 15;
            this.List.Location = new System.Drawing.Point(298, 10);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(167, 274);
            this.List.TabIndex = 20;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem1,
            this.fontColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.fontToolStripMenuItem1.Text = "Font";
            this.fontToolStripMenuItem1.Click += new System.EventHandler(this.fontToolStripMenuItem1_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fontColorToolStripMenuItem.Text = "Font color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem1
            // 
            this.backgroundColorToolStripMenuItem1.Name = "backgroundColorToolStripMenuItem1";
            this.backgroundColorToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.backgroundColorToolStripMenuItem1.Text = "Background color";
            this.backgroundColorToolStripMenuItem1.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem1_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Red;
            this.Remove.Enabled = false;
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Location = new System.Drawing.Point(7, 319);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(458, 23);
            this.Remove.TabIndex = 21;
            this.Remove.Text = "Удалить";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Cyan;
            this.Edit.Enabled = false;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Location = new System.Drawing.Point(7, 290);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(458, 23);
            this.Edit.TabIndex = 22;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Tools
            // 
            this.Tools.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSplitButton1});
            this.Tools.Location = new System.Drawing.Point(471, 0);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(33, 349);
            this.Tools.TabIndex = 23;
            this.Tools.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = global::PersonInfo.Properties.Resources.Save_37110;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(30, 6);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::PersonInfo.Properties.Resources.settings_78352__1_;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(30, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.colourToolStripMenuItem.Text = "Font color";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click_1);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(504, 349);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.List);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Persons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox PersonName;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Женщина;
        private System.Windows.Forms.RadioButton Мужчина;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ЕстьСемья;
        private System.Windows.Forms.RadioButton БезСемьи;
        private System.Windows.Forms.TextBox Patronimic;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem1;
        private System.Windows.Forms.ListBox List;
    }
}

