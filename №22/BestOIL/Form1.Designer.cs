
namespace BestOIL
{
    partial class BestOIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestOIL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.OilPrice = new System.Windows.Forms.TextBox();
            this.OilList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CAmount = new System.Windows.Forms.NumericUpDown();
            this.FAmount = new System.Windows.Forms.NumericUpDown();
            this.HAmount = new System.Windows.Forms.NumericUpDown();
            this.DAmount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPrice = new System.Windows.Forms.TextBox();
            this.FPrice = new System.Windows.Forms.TextBox();
            this.DPrice = new System.Windows.Forms.TextBox();
            this.HPrice = new System.Windows.Forms.TextBox();
            this.Cola = new System.Windows.Forms.CheckBox();
            this.Frie = new System.Windows.Forms.CheckBox();
            this.Hamburger = new System.Windows.Forms.CheckBox();
            this.Hot = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SumCafe = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GeneralSum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DAmount)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.OilPrice);
            this.groupBox1.Controls.Add(this.OilList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Amount";
            // 
            // Amount
            // 
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Amount.Enabled = false;
            this.Amount.Location = new System.Drawing.Point(65, 148);
            this.Amount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(106, 21);
            this.Amount.TabIndex = 10;
            this.Amount.ValueChanged += new System.EventHandler(this.Gallons_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Sum);
            this.groupBox3.Location = new System.Drawing.Point(6, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 94);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "$";
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sum.Location = new System.Drawing.Point(6, 26);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(110, 50);
            this.Sum.TabIndex = 1;
            this.Sum.Text = "00,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(6, 82);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(39, 17);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price:";
            // 
            // OilPrice
            // 
            this.OilPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OilPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OilPrice.Location = new System.Drawing.Point(51, 82);
            this.OilPrice.Name = "OilPrice";
            this.OilPrice.ReadOnly = true;
            this.OilPrice.Size = new System.Drawing.Size(120, 18);
            this.OilPrice.TabIndex = 1;
            // 
            // OilList
            // 
            this.OilList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OilList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OilList.FormattingEnabled = true;
            this.OilList.Location = new System.Drawing.Point(51, 29);
            this.OilList.Name = "OilList";
            this.OilList.Size = new System.Drawing.Size(140, 25);
            this.OilList.Sorted = true;
            this.OilList.TabIndex = 1;
            this.OilList.SelectedIndexChanged += new System.EventHandler(this.OilList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oil:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.CAmount);
            this.groupBox2.Controls.Add(this.FAmount);
            this.groupBox2.Controls.Add(this.HAmount);
            this.groupBox2.Controls.Add(this.DAmount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CPrice);
            this.groupBox2.Controls.Add(this.FPrice);
            this.groupBox2.Controls.Add(this.DPrice);
            this.groupBox2.Controls.Add(this.HPrice);
            this.groupBox2.Controls.Add(this.Cola);
            this.groupBox2.Controls.Add(this.Frie);
            this.groupBox2.Controls.Add(this.Hamburger);
            this.groupBox2.Controls.Add(this.Hot);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 289);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cafe";
            // 
            // CAmount
            // 
            this.CAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CAmount.Enabled = false;
            this.CAmount.Location = new System.Drawing.Point(145, 147);
            this.CAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CAmount.Name = "CAmount";
            this.CAmount.Size = new System.Drawing.Size(49, 21);
            this.CAmount.TabIndex = 19;
            this.CAmount.ValueChanged += new System.EventHandler(this.CAmount_ValueChanged);
            // 
            // FAmount
            // 
            this.FAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FAmount.Enabled = false;
            this.FAmount.Location = new System.Drawing.Point(145, 109);
            this.FAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.FAmount.Name = "FAmount";
            this.FAmount.Size = new System.Drawing.Size(49, 21);
            this.FAmount.TabIndex = 18;
            this.FAmount.ValueChanged += new System.EventHandler(this.FAmount_ValueChanged);
            // 
            // HAmount
            // 
            this.HAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HAmount.Enabled = false;
            this.HAmount.Location = new System.Drawing.Point(145, 71);
            this.HAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HAmount.Name = "HAmount";
            this.HAmount.Size = new System.Drawing.Size(49, 21);
            this.HAmount.TabIndex = 17;
            this.HAmount.ValueChanged += new System.EventHandler(this.HAmount_ValueChanged);
            // 
            // DAmount
            // 
            this.DAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DAmount.Enabled = false;
            this.DAmount.Location = new System.Drawing.Point(145, 33);
            this.DAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DAmount.Name = "DAmount";
            this.DAmount.Size = new System.Drawing.Size(49, 21);
            this.DAmount.TabIndex = 16;
            this.DAmount.ValueChanged += new System.EventHandler(this.DAmount_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // CPrice
            // 
            this.CPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPrice.Location = new System.Drawing.Point(96, 150);
            this.CPrice.Name = "CPrice";
            this.CPrice.ReadOnly = true;
            this.CPrice.Size = new System.Drawing.Size(44, 18);
            this.CPrice.TabIndex = 12;
            this.CPrice.Text = "8$";
            // 
            // FPrice
            // 
            this.FPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FPrice.Location = new System.Drawing.Point(95, 111);
            this.FPrice.Name = "FPrice";
            this.FPrice.ReadOnly = true;
            this.FPrice.Size = new System.Drawing.Size(44, 18);
            this.FPrice.TabIndex = 10;
            this.FPrice.Text = "7,20$";
            // 
            // DPrice
            // 
            this.DPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DPrice.Location = new System.Drawing.Point(95, 35);
            this.DPrice.Name = "DPrice";
            this.DPrice.ReadOnly = true;
            this.DPrice.Size = new System.Drawing.Size(44, 18);
            this.DPrice.TabIndex = 8;
            this.DPrice.Text = "4$";
            // 
            // HPrice
            // 
            this.HPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HPrice.Location = new System.Drawing.Point(95, 73);
            this.HPrice.Name = "HPrice";
            this.HPrice.ReadOnly = true;
            this.HPrice.Size = new System.Drawing.Size(44, 18);
            this.HPrice.TabIndex = 6;
            this.HPrice.Text = "5,40$";
            // 
            // Cola
            // 
            this.Cola.AutoSize = true;
            this.Cola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cola.Location = new System.Drawing.Point(6, 147);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(84, 21);
            this.Cola.TabIndex = 5;
            this.Cola.Text = "Coca-Cola";
            this.Cola.UseVisualStyleBackColor = true;
            this.Cola.CheckedChanged += new System.EventHandler(this.Cola_CheckedChanged);
            // 
            // Frie
            // 
            this.Frie.AutoSize = true;
            this.Frie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Frie.Location = new System.Drawing.Point(6, 110);
            this.Frie.Name = "Frie";
            this.Frie.Size = new System.Drawing.Size(88, 21);
            this.Frie.TabIndex = 4;
            this.Frie.Text = "Frie potato";
            this.Frie.UseVisualStyleBackColor = true;
            this.Frie.CheckedChanged += new System.EventHandler(this.Frie_CheckedChanged);
            // 
            // Hamburger
            // 
            this.Hamburger.AutoSize = true;
            this.Hamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hamburger.Location = new System.Drawing.Point(6, 70);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(91, 21);
            this.Hamburger.TabIndex = 3;
            this.Hamburger.Text = "Hamburger";
            this.Hamburger.UseVisualStyleBackColor = true;
            this.Hamburger.CheckedChanged += new System.EventHandler(this.Hamburger_CheckedChanged);
            // 
            // Hot
            // 
            this.Hot.AutoSize = true;
            this.Hot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hot.Location = new System.Drawing.Point(6, 33);
            this.Hot.Name = "Hot";
            this.Hot.Size = new System.Drawing.Size(74, 21);
            this.Hot.TabIndex = 2;
            this.Hot.Text = "Hot-dog";
            this.Hot.UseVisualStyleBackColor = true;
            this.Hot.CheckedChanged += new System.EventHandler(this.Hot_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.SumCafe);
            this.groupBox4.Location = new System.Drawing.Point(6, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 94);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "$";
            // 
            // SumCafe
            // 
            this.SumCafe.AutoSize = true;
            this.SumCafe.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumCafe.Location = new System.Drawing.Point(6, 26);
            this.SumCafe.Name = "SumCafe";
            this.SumCafe.Size = new System.Drawing.Size(110, 50);
            this.SumCafe.TabIndex = 1;
            this.SumCafe.Text = "00,00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.GeneralSum);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(12, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 111);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "General sum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "$";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(96, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GeneralSum
            // 
            this.GeneralSum.AutoSize = true;
            this.GeneralSum.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneralSum.Location = new System.Drawing.Point(242, 31);
            this.GeneralSum.Name = "GeneralSum";
            this.GeneralSum.Size = new System.Drawing.Size(110, 50);
            this.GeneralSum.TabIndex = 10;
            this.GeneralSum.Text = "00,00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestOIL.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(11, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BestOIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(455, 428);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BestOIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOIL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DAmount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox OilList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox OilPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Cola;
        private System.Windows.Forms.CheckBox Frie;
        private System.Windows.Forms.CheckBox Hamburger;
        private System.Windows.Forms.CheckBox Hot;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SumCafe;
        private System.Windows.Forms.TextBox HPrice;
        private System.Windows.Forms.TextBox CPrice;
        private System.Windows.Forms.TextBox FPrice;
        private System.Windows.Forms.TextBox DPrice;
        private System.Windows.Forms.NumericUpDown CAmount;
        private System.Windows.Forms.NumericUpDown FAmount;
        private System.Windows.Forms.NumericUpDown HAmount;
        private System.Windows.Forms.NumericUpDown DAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GeneralSum;
    }
}

