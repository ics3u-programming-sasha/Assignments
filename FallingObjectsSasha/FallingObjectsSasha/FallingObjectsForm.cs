/*
 * Created by: Sasha Malko
 * Created on: 12-Sep-2019
 * Created for: ICS3U Programming
 * Major Assignment – #2 - Falling Objects
 * This program calculates how high an object is when the user enters the time since they have thrown the object off the cliff   
 * that is 100m high.
*/
using System;
using System.Windows.Forms;

namespace FallingObjectsSasha
{
    public partial class frmFallingObjects : Form
    {
        const double g = 9.8;
        const double a = 4.519;
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        //this allows for the calculation to be made but only for a valid input
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //this only allows numbers to be entered
            double t;
            if (double.TryParse(txtTime.Text, out t))
            {
                double d = FallingObjects(t);
                lblHeight.Text = d.ToString("n") + "m";

                //this only allows times in which the object is above the ground to be entered
                if (Convert.ToDouble(txtTime.Text) > 4.5176)
                {
                    lblHeight.Text = "Already hit the ground";
                }
                //this only allows positive numbers to be entered
                if (Convert.ToDouble(txtTime.Text) < 0)
                {
                    lblHeight.Text = "Invalid Input";

                }
            }
            else
            {
                lblHeight.Text = "Invalid Input";
            }
        }

        //this declares the equation that is going to be used in the calculation
        private double FallingObjects(double t)
        {
            double d = 100 - (0.5 * g * Math.Pow(t, 2));
            return d;
        }
    }
}