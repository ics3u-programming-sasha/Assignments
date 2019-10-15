/*
 * Created by: Sasha Malko
 * Created on: 8-Oct-2019
 * Created for: ICS3U Programming
 * Assignment #4b - Pizza Order
 * This program calculates the cost of a user's pizza order once they click on calculate. 
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

namespace PizzaOrderSasha
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();

            // hide the selections label
            lblSelections.Hide(); 
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // show the selections label
            lblSelections.Show();

            // declare constants 
            const double MEDIUM = 6.99;
            const double LARGE = 9.99;
            const double EXTRA_LARGE = 12.99;
            const double ONE_TOPPING = 0.75;
            const double TWO_TOPPING = 1.35;
            const double THREE_TOPPING = 2.15;
            const double FOUR_TOPPING = 2.75;
            const double YES_SOFT_DRINK = 1.50;
            const double NO_SOFT_DRINK = 0;
            const double YES_DELIVERY = 5;
            const double NO_DELIVERY = 0;
            const double NO_TIP = 0;
            const double ONE_TIP = 1;
            const double TWO_TIP = 2;
            const double THREE_TIP = 3;
            const double ALBERTA = 0.05;
            const double SASKATCHEWAN = 0.11;
            const double BRITISH_COLUMBIA = 0.12;
            const double ONTARIO = 0.13;
            const double QUEBEC = 0.15;

            // declare local variables
            double uSize, size, uToppings, toppings, uSoftDrink, softDrink, uDelivery, 
            delivery, uTip, tip, uProvince, province, subtotal, subD, tax, subT, total;

            // get the user's size selection from the number up-down box
            uSize = Convert.ToDouble(this.nudSize.Value);

            if (uSize == 1)
            {
                // make the size equal to medium
                size = MEDIUM;

                // display the user's size selecion and price
                lblFinalSize.Text = "Medium size: $6.99";
            }

            else if (uSize == 2)
            {
                // make the size equal to large
                size = LARGE;

                // display the user's size selecion and price
                lblFinalSize.Text = "Large size: $9.99";
            }

            else
            {
                // make the size equal to extra large
                size = EXTRA_LARGE;

                // display the user's size selecion and price
                lblFinalSize.Text = "Extra Large size: $12.99";
            }

            // get the user's toppings selection from the number up-down box
            uToppings = Convert.ToDouble(this.nudToppings.Value);

            if (uToppings == 1)
            {
                // make the toppings equal to one topping
                toppings = ONE_TOPPING;

                // display the user's toppings selecion and price
                lblFinalToppings.Text = "1 Topping: $0.75";
            }

            else if (uToppings == 2)
            {
                // make the toppings equal to two toppings
                toppings = TWO_TOPPING;

                // display the user's toppings selecion and price
                lblFinalToppings.Text = "2 Toppings: $1.35";
            }

            else if (uToppings == 3)
            {
                // make the toppings equal to three toppings
                toppings = THREE_TOPPING;

                // display the user's toppings selecion and price
                lblFinalToppings.Text = "3 Toppings: $2.15";
            }

            else
            {
                // make the toppings equal to four toppings
                toppings = FOUR_TOPPING;

                // display the user's toppings selecion and price
                lblFinalToppings.Text = "4 Toppings: $2.75";
            }

            // get the user's soft drink selection from the number up-down box
            uSoftDrink = Convert.ToDouble(this.nudSoftDrink.Value);

            if (uSoftDrink == 1)
            {
                // make the soft drink equal to yes
                softDrink = YES_SOFT_DRINK;

                // display the user's soft drink selecion and price
                lblFinalDrink.Text = "Soft Drink: $1.50";
            }

            else
            {
                // make the soft drink equal to no
                softDrink = NO_SOFT_DRINK;

                // display the user's soft drink selecion and price
                lblFinalDrink.Text = "No Soft Drink: $0";
            }

            // get the user's delivery selection from the number up-down box
            uDelivery = Convert.ToDouble(this.nudDelivery.Value);

            if (uDelivery == 1)
            {
                // make the delivery equal to yes
                delivery = YES_DELIVERY;

                // display the user's delivery selecion and price
                lblFinalDelivery.Text = "Delivery: $5";
            }

            else
            {
                // make the delivery equal to no
                delivery = NO_DELIVERY;

                // display the user's delivery selecion and price
                lblFinalDelivery.Text = "No Delivery: $0";
            }

            // get the user's tip selection from the number up-down box
            uTip = Convert.ToDouble(this.nudTip.Value);

            if (uTip == 0)
            {
                // make the tip equal to $0
                tip = NO_TIP;

                // display the user's tip selecion and amount
                lblFinalTip.Text = "No tip: $0";
            }

            else if (uTip == 1)
            {
                // make the tip equal to $1
                tip = ONE_TIP;

                // display the user's tip selecion and amount
                lblFinalTip.Text = "Tip: $1";
            }

            else if (uTip == 2)
            {
                // make the tip equal to $2
                tip = TWO_TIP;

                // display the user's tip selecion and amount
                lblFinalTip.Text = "Tip: $2";
            }

            else
            {
                // make the tip equal to $3
                tip = THREE_TIP;

                // display the user's tip selecion and amount
                lblFinalTip.Text = "Tip: $3";
            }

            // get the user's province selection from the number up-down box
            uProvince = Convert.ToDouble(this.nudProvince.Value);

            if (uProvince == 1)
            {
                // make the province equal to the tax rate of Alberta
                province = ALBERTA;

                // display the user's province selecion and tax rate
                lblFinalProvince1.Text = "Alberta, Northwest Territories, Yukon,";
                lblFinalProvince2.Text = "Nunavut: 5% tax rate";
                lblFinalProvince2.Show();
                lblFinalProvince3.Hide();
            }

            else if (uProvince == 2)
            {
                // make the province equal to the tax rate of Saskatchewan
                province = SASKATCHEWAN;

                // display the user's province selecion and tax rate
                lblFinalProvince1.Text = "Saskatchewan: 11% tax rate";
                lblFinalProvince2.Hide();
                lblFinalProvince3.Hide();
            }

            else if (uProvince == 3)
            {
                // make the province equal to the tax rate of British Columbia
                province = BRITISH_COLUMBIA;

                // display the user's province selecion and tax rate
                lblFinalProvince1.Text = "British Columbia: 12% tax rate";
                lblFinalProvince2.Hide();
                lblFinalProvince3.Hide();
            }

            else if (uProvince == 4)
            {
                // make the province equal to the tax rate of Ontario
                province = ONTARIO;

                // display the user's province selecion and tax rate
                lblFinalProvince1.Text = "Ontario, Manitoba: 13% tax rate";
                lblFinalProvince2.Hide();
                lblFinalProvince3.Hide();
            }

            else
            {
                // make the province equal to the tax rate of Quebec
                province = QUEBEC;

                // display the user's province selecion and tax rate
                lblFinalProvince1.Text = "Quebec, New Brunswick, Prince Edward";
                lblFinalProvince2.Text = "Island, Nova Scotia, Newfoundland";
                lblFinalProvince3.Text = "and Labrador: 15% tax rate";
                lblFinalProvince2.Show();
                lblFinalProvince3.Show();
            }

            // calculate the subtotal
            subtotal = size + toppings + softDrink;

            // insert the subtotal into its respective label
            this.lblSubtotal.Text = String.Format("Subtotal ($): ${0:0.00}", subtotal);

            if (subtotal > 15)
            {
                // subtract $5 from the subtotal as a discount
                subD = subtotal - 5;

                // display the user's discount amount
                lblFinalDiscount.Text = "Discount: $5";
            }

            else
            {
                // subtract $0 from the subtotal 
                subD = subtotal - 0;

                // display the user's discount amount
                lblFinalDiscount.Text = "No Discount: $0";
            }

            // insert the subtotal with discount into its respective label
            this.lblSubD.Text = String.Format("Subtotal with discount ($): ${0:0.00}", subD);

            // calculate the tax amount
            tax = subD * province;

            // insert the tax amount into its respective label
            this.lblTax.Text = String.Format("Tax amount ($): ${0:0.00}", tax);

            // calculate the subtotal with tax
            subT = subD * (province + 1);

            // insert the subtotal with tax into its respective label
            this.lblSubT.Text = String.Format("Subtotal with tax ($): ${0:0.00}", subT);

            // calculate the total
            total = subT + delivery + tip;

            // insert the total into its respective label
            this.lblTotal.Text = String.Format("Total ($): ${0:0.00}", total);
        }
    }
}