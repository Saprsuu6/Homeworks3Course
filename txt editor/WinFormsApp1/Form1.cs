using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool changed;

        public Form1()
        {
            InitializeComponent();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
                TextBox.BackColor = ColorDialog.Color;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
                TextBox.ForeColor = ColorDialog.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
                TextBox.Font = FontDialog.Font;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
            incertToolStripMenuItem.Enabled = true;
            toolStripIncert.Enabled = true;
            incertToolStripMenuItem1.Enabled = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
            incertToolStripMenuItem.Enabled = true;
            toolStripIncert.Enabled = true;
            incertToolStripMenuItem1.Enabled = true;
        }

        private void incertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 0)
                TextBox.SelectAll();
            else
                MessageBox.Show("Text are not exists", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text.Remove(TextBox.SelectionStart, TextBox.SelectionLength);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_FormClosing(sender, e as FormClosingEventArgs);

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = OpenFile.FileName;

                using (StreamReader reader = new StreamReader(filePath))
                    TextBox.Text = reader.ReadToEnd();

                Text = "*" + filePath;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("New document.txt"))
                writer.Write(TextBox.Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = SaveFile.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                    writer.Write(TextBox.Text);
            }
        }

        private void newDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                saveAsToolStripMenuItem_Click(sender, e);

            TextBox.Text = "";
        }

        private void TextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (TextBox.SelectionLength > 0)
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                removeToolStripMenuItem.Enabled = true;

                toolStripCopy.Enabled = true;
                toolStripCut.Enabled = true;
                toolStripRemove.Enabled = true;

                copyToolStripMenuItem1.Enabled = true;
                cutToolStripMenuItem1.Enabled = true;
                removeToolStripMenuItem1.Enabled = true;
            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                removeToolStripMenuItem.Enabled = false;

                toolStripCopy.Enabled = false;
                toolStripCut.Enabled = false;
                toolStripRemove.Enabled = false;

                copyToolStripMenuItem1.Enabled = false;
                cutToolStripMenuItem1.Enabled = false;
                removeToolStripMenuItem1.Enabled = false;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusAmoutLetters.Text = "Amount simbols: " + TextBox.Text.Length;

            if (TextBox.Text.Length > 0)
                sellectAllToolStripMenuItem.Enabled = true;
            else
                sellectAllToolStripMenuItem.Enabled = false;

            changed = true;
            if (!Text.Contains("*"))
                Text = Text.Insert(0, "*");
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.TextAlign = HorizontalAlignment.Left;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.TextAlign = HorizontalAlignment.Right;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.TextAlign = HorizontalAlignment.Center;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                DialogResult result = MessageBox.Show("Do you want to save", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    saveAsToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
