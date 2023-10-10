/*
 * Menu
 * Burmeister
 * 10/10/23
 * DDA
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Burmeister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            decimal  total = 0;

            if (regularRadioButton.Checked)
            {
                total += 4.19M;
            }
            else if (cheeseRadioButton.Checked)
            {
                total += 4.79M;
            }
            else if (baconRadioButton.Checked)
            {
                total += 4.79M;
            }
            else if (bothRadioButton.Checked)
            {
                total += 5.39M;
            }

            if (smallRadioButton.Checked)
            {
                total += 2.39M;
            }
            if (mediumRadioButton.Checked)
            {
                total += 3.09M;
            }
            if (largeRadioButton.Checked)
            {
                total += 4.99M;
            }

            if (sodaRadioButton.Checked)
            {
                total += 1.69M;
            }
            else if (waterRadioButton.Checked)
            {
                total += 1.49M;
            }
            costLabel.Text = "$" + Convert.ToString(total);
        }

        private void burgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            burgerLabel.Visible = true;
            burgerGroupBox.Visible = true;
        }

        private void fryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            friesLabel.Visible = true;
            friesGroupBox.Visible = true;
        }

        private void drinksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drinkLabel.Visible = true;
            drinkGroupBox.Visible = true;
        }
    }
}
