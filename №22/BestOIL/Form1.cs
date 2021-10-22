using BestOIL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOIL
{
    public partial class BestOIL : Form
    {
        private double sumInOilBase;
        private double sumInCafe = 0;
        private Oil oil = new Oil();
        private MiniCafe miniCafe = new MiniCafe();

        public BestOIL()
        {
            InitializeComponent();

            OilList.Items.AddRange(oil.OilName);
        }

        private void OilList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OilPrice.Text = oil.Prices[OilList.SelectedIndex].ToString();
            Amount.Enabled = true;
        }

        private void Gallons_ValueChanged(object sender, EventArgs e)
        {
            decimal value = Amount.Value;
            double price = oil.Prices[OilList.SelectedIndex];
            double result = price * Convert.ToDouble(value);
            result = Math.Round(result, 2);
            sumInOilBase = result;
            Sum.Text = sumInOilBase.ToString();
        }

        private void Hot_CheckedChanged(object sender, EventArgs e)
        {
            if (Hot.Checked)
                DAmount.Enabled = true;
            else
                DAmount.Enabled = false;
        }

        private void Hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (Hamburger.Checked)
                HAmount.Enabled = true;
            else
                HAmount.Enabled = false;
        }

        private void Frie_CheckedChanged(object sender, EventArgs e)
        {

            if (Frie.Checked)
                FAmount.Enabled = true;
            else
                FAmount.Enabled = false;
        }

        private void Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (Cola.Checked)
                CAmount.Enabled = true;
            else
                CAmount.Enabled = false;
        }

        private void DAmount_ValueChanged(object sender, EventArgs e)
        {
            decimal value = DAmount.Value;
            double result = miniCafe.Prices[0] * Convert.ToDouble(value);
            result = Math.Round(result, 2);
            sumInCafe += result;
            SumCafe.Text = sumInCafe.ToString();
        }

        private void HAmount_ValueChanged(object sender, EventArgs e)
        {
            decimal value = HAmount.Value;
            double result = miniCafe.Prices[1] * Convert.ToDouble(value);
            result = Math.Round(result, 2);
            sumInCafe += result;
            SumCafe.Text = sumInCafe.ToString();
        }

        private void FAmount_ValueChanged(object sender, EventArgs e)
        {
            decimal value = FAmount.Value;
            double result = miniCafe.Prices[2] * Convert.ToDouble(value);
            result = Math.Round(result, 2);
            sumInCafe += result;
            SumCafe.Text = sumInCafe.ToString();
        }

        private void CAmount_ValueChanged(object sender, EventArgs e)
        {
            decimal value = CAmount.Value;
            double result = miniCafe.Prices[3] * Convert.ToDouble(value);
            result = Math.Round(result, 2);
            sumInCafe += result;
            SumCafe.Text = sumInCafe.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = sumInCafe + sumInOilBase;
            result = Math.Round(result, 2);
            GeneralSum.Text = result.ToString();
        }
    }
}
