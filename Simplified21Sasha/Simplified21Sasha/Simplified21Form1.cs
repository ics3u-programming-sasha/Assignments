using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21Sasha
{
    public partial class Simplified21Form1 : Form
    {
        // declare constants
        const int MIN_NUM = 1;
        const int MAX_NUM = 10;
        const int CMIN_NUM = 1;
        const int CMAX_NUM = 4;

        // declare variables
        int uRandom;
        int uRandomCard;
        int uRandom2;
        int uRandomCard2;
        int uRandom3;
        int uRandomCard3;
        int uRandom4;
        int uRandomCard4;
        int cRandom;
        int cRandomCard;
        int cRandom2;
        int cRandomCard2;
        int cRandom3;
        int cRandomCard3;
        int cRandom4;
        int cRandomCard4;
        double bet;
        Random rnd = new Random();
        int uPoint;
        int uPoint2;
        int uPoint3;
        int uPoint4;
        int cPoint;
        int cPoint2;
        int cPoint3;
        int cPoint4;
        int uTotal;
        int cTotal;
        double payoff;

        WMPLib.WindowsMediaPlayer player;

        public Simplified21Form1()
        {
            InitializeComponent();

            // hide everything that is not yet needed on the starting screen
            this.picCard.Hide();
            this.picCard2.Hide();
            this.picCard3.Hide();
            this.picCard4.Hide();
            this.picCCard.Hide();
            this.picCCard2.Hide();
            this.picCCard3.Hide();
            this.picCCard4.Hide();
            this.lblDealer.Hide();
            this.lblUser.Hide();
            this.lblHitOrStay.Hide();
            this.btnDeal.Enabled = false;
            this.btnDeal.Visible = false;
            this.btnHit.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Visible = false;
            this.btnStay.Enabled = false;
            this.btnHit2.Visible = false;
            this.btnStay2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnHit2.Enabled = false;
            this.lblUTotal.Hide();
            this.lblCTotal.Hide();
        }

        public Simplified21Form1(ref WMPLib.WindowsMediaPlayer soundPlayer)
        {
            InitializeComponent();

            player = soundPlayer;

            // hide everything that is not yet needed on the starting screen
            this.picCard.Hide();
            this.picCard2.Hide();
            this.picCard3.Hide();
            this.picCard4.Hide();
            this.picCCard.Hide();
            this.picCCard2.Hide();
            this.picCCard3.Hide();
            this.picCCard4.Hide();
            this.lblDealer.Hide();
            this.lblUser.Hide();
            this.lblHitOrStay.Hide();
            this.btnDeal.Enabled = false;
            this.btnDeal.Visible = false;
            this.btnHit.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Visible = false;
            this.btnStay.Enabled = false;
            this.btnHit2.Visible = false;
            this.btnStay2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnHit2.Enabled = false;
            this.lblUTotal.Hide();
            this.lblCTotal.Hide();
        }


        private void BtnBet_Click(object sender, EventArgs e)
        {
            // convert the string in the text box to an integer
            bet = Convert.ToInt32(this.nudBet.Value);

            // display the deal button and disable the betting objects
            this.btnBet.Enabled = false;
            this.btnBet.Visible = false;
            this.lblBet.Visible = false;
            this.nudBet.Visible = false;
            this.btnDeal.Enabled = true;
            this.btnDeal.Visible = true;
        }

        private void BtnDeal_Click(object sender, EventArgs e)
        {
            // display the cards on the cards on the screen and the hit or stay options while disabling the deal button
            this.btnDeal.Enabled = false;
            this.btnDeal.Visible = false;
            this.btnHit.Visible = true;
            this.btnStay.Visible = true;
            this.btnHit.Enabled = true;
            this.btnStay.Enabled = true;
            this.lblDealer.Show();
            this.lblUser.Show();
            this.picCard.Show();
            this.picCard2.Show();
            this.picCCard.Show();
            this.picCCard2.Show();
            this.lblHitOrStay.Show();

            // generate a random number and set it to the variable
            uRandom = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            uRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard = rnd.Next(CMIN_NUM, CMAX_NUM + 1);


            // display the card that corresponds to the random value for the first user card and the points
            if (uRandom == 1)
            {
                this.picCard.Image = Properties.Resources.Ace;
                uPoint = 1;
            }
            else if (uRandom == 2)
            {
                this.picCard.Image = Properties.Resources.Two;
                uPoint = 2;
            }
            else if (uRandom == 3)
            {
                this.picCard.Image = Properties.Resources.Three;
                uPoint = 3;
            }
            else if (uRandom == 4)
            {
                this.picCard.Image = Properties.Resources.Four;
                uPoint = 4;
            }
            else if (uRandom == 5)
            {
                this.picCard.Image = Properties.Resources.Five;
                uPoint = 5;
            }
            else if (uRandom == 6)
            {
                this.picCard.Image = Properties.Resources.Six;
                uPoint = 6;
            }
            else if (uRandom == 7)
            {
                this.picCard.Image = Properties.Resources.Seven;
                uPoint = 7;
            }
            else if (uRandom == 8)
            {
                this.picCard.Image = Properties.Resources.Eight;
                uPoint = 8;
            }
            else if (uRandom == 9)
            {
                this.picCard.Image = Properties.Resources.Nine;
                uPoint = 9;
            }
            else if (uRandom == 10)
            {
                uPoint = 10;

                if (uRandomCard == 1)
                {
                    this.picCard.Image = Properties.Resources.Ten;
                }
                else if (uRandomCard == 2)
                {
                    this.picCard.Image = Properties.Resources.Jack;
                }
                else if (uRandomCard == 3)
                {
                    this.picCard.Image = Properties.Resources.Queen;
                }
                else if (uRandomCard == 4)
                {
                    this.picCard.Image = Properties.Resources.King;
                }
            }

            // display the card that corresponds to the random value for the second user card and the points
            if (uRandom2 == 1)
            {
                this.picCard2.Image = Properties.Resources.Ace;
                uPoint2 = 1;
            }

            else if (uRandom2 == 2)
            {
                this.picCard2.Image = Properties.Resources.Two;
                uPoint2 = 2;
            }

            else if (uRandom2 == 3)
            {
                this.picCard2.Image = Properties.Resources.Three;
                uPoint2 = 3;
            }

            else if (uRandom2 == 4)
            {
                this.picCard2.Image = Properties.Resources.Four;
                uPoint2 = 4;
            }

            else if (uRandom2 == 5)
            {
                this.picCard2.Image = Properties.Resources.Five;
                uPoint2 = 5;
            }

            else if (uRandom2 == 6)
            {
                this.picCard2.Image = Properties.Resources.Six;
                uPoint2 = 6;
            }

            else if (uRandom2 == 7)
            {
                this.picCard2.Image = Properties.Resources.Seven;
                uPoint2 = 7;
            }

            else if (uRandom2 == 8)
            {
                this.picCard2.Image = Properties.Resources.Eight;
                uPoint2 = 8;
            }

            else if (uRandom2 == 9)
            {
                this.picCard2.Image = Properties.Resources.Nine;
                uPoint2 = 9;
            }

            else if (uRandom2 == 10)
            {
                uPoint2 = 10;

                if (uRandomCard2 == 1)
                {
                    this.picCard2.Image = Properties.Resources.Ten;
                }

                else if (uRandomCard2 == 2)
                {
                    this.picCard2.Image = Properties.Resources.Jack;
                }

                else if (uRandomCard2 == 3)
                {
                    this.picCard2.Image = Properties.Resources.Queen;
                }

                else if (uRandomCard2 == 4)
                {
                    this.picCard2.Image = Properties.Resources.King;
                }
            }

            // calculate the user's total points and display it
            uTotal = uPoint + uPoint2;
            lblUTotal.Text = "Your total: " + Convert.ToString(uTotal);
            this.lblUTotal.Show();

            // display the card that corresponds to the random value for the first dealer's card and the points
            if (cRandom == 1)
            {
                this.picCCard.Image = Properties.Resources.Ace;
                cPoint = 1;
            }

            else if (cRandom == 2)
            {
                this.picCCard.Image = Properties.Resources.Two;
                cPoint = 2;
            }

            else if (cRandom == 3)
            {
                this.picCCard.Image = Properties.Resources.Three;
                cPoint = 3;
            }

            else if (cRandom == 4)
            {
                this.picCCard.Image = Properties.Resources.Four;
                cPoint = 4;
            }

            else if (cRandom == 5)
            {
                this.picCCard.Image = Properties.Resources.Five;
                cPoint = 5;
            }

            else if (cRandom == 6)
            {
                this.picCCard.Image = Properties.Resources.Six;
                cPoint = 6;
            }

            else if (cRandom == 7)
            {
                this.picCCard.Image = Properties.Resources.Seven;
                cPoint = 7;
            }

            else if (cRandom == 8)
            {
                this.picCCard.Image = Properties.Resources.Eight;
                cPoint = 8;
            }

            else if (cRandom == 9)
            {
                this.picCCard.Image = Properties.Resources.Nine;
                cPoint = 9;
            }

            else if (cRandom == 10)
            {
                cPoint = 10;

                if (cRandom == 1)
                {
                    this.picCCard.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard == 2)
                {
                    this.picCCard.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard == 3)
                {
                    this.picCCard.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard == 4)
                {
                    this.picCCard.Image = Properties.Resources.King;
                }
            }

            // display the back of a card for the dealer's second card
            this.picCCard2.Image = Properties.Resources.Back;

            // calculate the dealer's total points and display it
            cTotal = cPoint;
            lblCTotal.Text = "Dealer's total: " + Convert.ToString(cTotal);
            this.lblCTotal.Show();
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            // disable the current hit and stay buttons and display the next hit and stay buttons
            this.btnHit.Visible = false;
            this.btnStay.Visible = false;
            this.btnHit.Enabled = false;
            this.btnHit.Enabled = false;
            this.btnHit2.Visible = true;
            this.btnStay2.Visible = true;
            this.btnHit2.Enabled = true;
            this.btnHit2.Enabled = true;
            this.lblHitOrStay.Show();

            // generate a random number and set it to the variable
            uRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            //display the third user card
            this.picCard3.Show();

            // display the card that corresponds to the random value for the third user card and the points
            if (uRandom3 == 1)
            {
                this.picCard3.Image = Properties.Resources.Ace;
                uPoint3 = 1;
            }
            else if (uRandom3 == 2)
            {
                this.picCard3.Image = Properties.Resources.Two;
                uPoint3 = 2;
            }
            else if (uRandom3 == 3)
            {
                this.picCard3.Image = Properties.Resources.Three;
                uPoint3 = 3;
            }
            else if (uRandom3 == 4)
            {
                this.picCard3.Image = Properties.Resources.Four;
                uPoint3 = 4;
            }
            else if (uRandom3 == 5)
            {
                this.picCard3.Image = Properties.Resources.Five;
                uPoint3 = 5;
            }
            else if (uRandom3 == 6)
            {
                this.picCard3.Image = Properties.Resources.Six;
                uPoint3 = 6;
            }
            else if (uRandom3 == 7)
            {
                this.picCard3.Image = Properties.Resources.Seven;
                uPoint3 = 7;
            }
            else if (uRandom3 == 8)
            {
                this.picCard3.Image = Properties.Resources.Eight;
                uPoint3 = 8;
            }
            else if (uRandom3 == 9)
            {
                this.picCard3.Image = Properties.Resources.Nine;
                uPoint3 = 9;
            }
            else if (uRandom3 == 10)
            {
                uPoint3 = 10;

                if (uRandomCard3 == 1)
                {
                    this.picCard3.Image = Properties.Resources.Ten;
                }
                else if (uRandomCard3 == 2)
                {
                    this.picCard3.Image = Properties.Resources.Jack;
                }
                else if (uRandomCard3 == 3)
                {
                    this.picCard3.Image = Properties.Resources.Queen;
                }
                else if (uRandomCard3 == 4)
                {
                    this.picCard3.Image = Properties.Resources.King;
                }
            }

            // calculate the user's total points and display it
            uTotal = uPoint + uPoint2 + uPoint3;
            lblUTotal.Text = "Your total: " + Convert.ToString(uTotal);
            this.lblUTotal.Show();

            // check if the user busted, and if they did, display so, and end the game
            if (uTotal > 21)
            {
                payoff = 0 - 2;
                MessageBox.Show("Bust! You lose!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
                this.btnHit.Visible = false;
                this.btnStay.Visible = false;
                this.btnHit.Enabled = false;
                this.btnHit.Enabled = false;
                this.btnHit2.Visible = false;
                this.btnStay2.Visible = false;
                this.btnHit2.Enabled = false;
                this.btnHit2.Enabled = false;
                this.lblHitOrStay.Hide();
            }
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            // disable the hit and stay buttons
            this.btnHit.Visible = false;
            this.btnStay.Visible = false;
            this.btnHit.Enabled = false;
            this.btnHit.Enabled = false;
            this.lblHitOrStay.Hide();

            // generate a random number and set it to the variable
            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            // display the dealer's cards
            this.picCCard2.Show();
            this.picCCard3.Show();
            this.picCCard4.Show();

            // display the card that corresponds to the random value for the second dealer's card and the points
            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                cPoint2 = 1;
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                cPoint2 = 2;
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                cPoint2 = 3;
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                cPoint2 = 4;
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                cPoint2 = 5;
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                cPoint2 = 6;
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                cPoint2 = 7;
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                cPoint2 = 8;
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                cPoint2 = 9;
            }

            else if (cRandom2 == 10)
            {
                cPoint2 = 10;

                if (cRandom2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                }
            }

            // display the card that corresponds to the random value for the third dealer's card and the points
            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                cPoint3 = 1;
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                cPoint3 = 2;
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                cPoint3 = 3;
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                cPoint3 = 4;
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                cPoint3 = 5;
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                cPoint3 = 6;
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                cPoint3 = 7;
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                cPoint3 = 8;
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                cPoint3 = 9;
            }

            else if (cRandom3 == 10)
            {
                cPoint3 = 10;

                if (cRandom3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                }
            }

            // display the card that corresponds to the random value for the third dealer's card and the points
            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                cPoint4 = 1;
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                cPoint4 = 2;
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                cPoint4 = 3;
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                cPoint4 = 4;
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                cPoint4 = 5;
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                cPoint4 = 6;
            }

            else if (cRandom4 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                cPoint4 = 7;
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                cPoint4 = 8;
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                cPoint4 = 9;
            }

            else if (cRandom4 == 10)
            {
                cPoint4 = 10;

                if (cRandom4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                }
            }

            // calculate the dealer's total points and display it
            cTotal = cPoint + cPoint2 + cPoint3 + cPoint4;
            lblCTotal.Text = "Dealer's total: " + Convert.ToString(cTotal);
            this.lblCTotal.Show();

            // check for the results of the game and display the results
            if (cTotal > 21)
            {
                payoff = bet * 1.5;
                MessageBox.Show("Bust for the dealer! You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal == 21)
            {
                payoff = 0 - bet;
                MessageBox.Show("Blackjack for the dealer!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (uTotal == 21)
            {
                payoff = bet * 1.5;
                MessageBox.Show("Blackjack! You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal == uTotal)
            {
                payoff = 0;
                MessageBox.Show("It is a tie!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal > uTotal)
            {
                payoff = 0 - bet;
                MessageBox.Show("The dealer wins!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal < uTotal)
            {
                payoff = bet * 1.5;
                MessageBox.Show("You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
        }

        private void BtnHit2_Click(object sender, EventArgs e)
        {
            // disable the hit and stay buttons
            this.btnHit2.Visible = false;
            this.btnStay2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnHit2.Enabled = false;
            this.lblHitOrStay.Hide();

            // generate a random number and set it to the variable
            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            // display the dealer's cards
            this.picCCard2.Show();
            this.picCCard3.Show();
            this.picCCard4.Show();

            // display the card that corresponds to the random value for the second dealer's card and the points
            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                cPoint2 = 1;
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                cPoint2 = 2;
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                cPoint2 = 3;
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                cPoint2 = 4;
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                cPoint2 = 5;
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                cPoint2 = 6;
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                cPoint2 = 7;
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                cPoint2 = 8;
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                cPoint2 = 9;
            }

            else if (cRandom2 == 10)
            {
                cPoint2 = 10;

                if (cRandom2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                }
            }

            // display the card that corresponds to the random value for the third dealer's card and the points
            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                cPoint3 = 1;
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                cPoint3 = 2;
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                cPoint3 = 3;
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                cPoint3 = 4;
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                cPoint3 = 5;
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                cPoint3 = 6;
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                cPoint3 = 7;
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                cPoint3 = 8;
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                cPoint3 = 9;
            }

            else if (cRandom3 == 10)
            {
                cPoint3 = 10;

                if (cRandom3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                }
            }

            // display the card that corresponds to the random value for the third dealer's card and the points
            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                cPoint4 = 1;
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                cPoint4 = 2;
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                cPoint4 = 3;
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                cPoint4 = 4;
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                cPoint4 = 5;
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                cPoint4 = 6;
            }

            else if (cRandom4 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                cPoint4 = 7;
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                cPoint4 = 8;
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                cPoint4 = 9;
            }

            else if (cRandom4 == 10)
            {
                cPoint4 = 10;

                if (cRandom4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                }
            }

            // calculate the dealer's total points and display it
            cTotal = cPoint + cPoint2 + cPoint3 + cPoint4;
            lblCTotal.Text = "Dealer's total: " + Convert.ToString(cTotal);
            this.lblCTotal.Show();

            // generate a random number and set it to the variable
            uRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            //display the third user card
            this.picCard4.Show();

            // display the card that corresponds to the random value for the third user card and the points
            if (uRandom4 == 1)
            {
                this.picCard4.Image = Properties.Resources.Ace;
                uPoint4 = 1;
            }
            else if (uRandom4 == 2)
            {
                this.picCard4.Image = Properties.Resources.Two;
                uPoint4 = 2;
            }
            else if (uRandom4 == 3)
            {
                this.picCard4.Image = Properties.Resources.Three;
                uPoint4 = 3;
            }
            else if (uRandom4 == 4)
            {
                this.picCard4.Image = Properties.Resources.Four;
                uPoint4 = 4;
            }
            else if (uRandom4 == 5)
            {
                this.picCard4.Image = Properties.Resources.Five;
                uPoint4 = 5;
            }
            else if (uRandom4 == 6)
            {
                this.picCard4.Image = Properties.Resources.Six;
                uPoint4 = 6;
            }
            else if (uRandom4 == 7)
            {
                this.picCard4.Image = Properties.Resources.Seven;
                uPoint4 = 7;
            }
            else if (uRandom4 == 8)
            {
                this.picCard4.Image = Properties.Resources.Eight;
                uPoint4 = 8;
            }
            else if (uRandom4 == 9)
            {
                this.picCard4.Image = Properties.Resources.Nine;
                uPoint4 = 9;
            }
            else if (uRandom4 == 10)
            {
                uPoint4 = 10;

                if (uRandomCard4 == 1)
                {
                    this.picCard4.Image = Properties.Resources.Ten;
                }
                else if (uRandomCard4 == 2)
                {
                    this.picCard4.Image = Properties.Resources.Jack;
                }
                else if (uRandomCard4 == 3)
                {
                    this.picCard4.Image = Properties.Resources.Queen;
                }
                else if (uRandomCard4 == 4)
                {
                    this.picCard4.Image = Properties.Resources.King;
                }
            }

            // calculate the user's total points and display it
            uTotal = uPoint + uPoint2 + uPoint3 + uPoint4;
            lblUTotal.Text = "Your total: " + Convert.ToString(uTotal);
            this.lblUTotal.Show();

            // check for the results of the game and display the results
            if (uTotal > 21)
            {
                payoff = 0 - 2;
                MessageBox.Show("Bust! You lose!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal > 21)
            {
                payoff = bet * 1.5;
                MessageBox.Show("Bust for the dealer! You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal == 21)
            {
                payoff = 0 - bet;
                MessageBox.Show("Blackjack for the dealer!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (uTotal == 21)
            {
                payoff = bet * 1.5;
                MessageBox.Show("Blackjack! You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal == uTotal)
            {
                payoff = 0;
                MessageBox.Show("It is a tie!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal > uTotal)
            {
                payoff = 0 - bet;
                MessageBox.Show("The dealer wins!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal < uTotal)
            {
                payoff = bet * 1.5;
                MessageBox.Show("You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
        }

        private void BtnStay2_Click(object sender, EventArgs e)
        {
            // disable the hit and stay buttons
            this.btnHit2.Visible = false;
            this.btnStay2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnHit2.Enabled = false;
            this.lblHitOrStay.Hide();

            // generate a random number and set it to the variable
            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            // display the dealer's cards
            this.picCCard2.Show();
            this.picCCard3.Show();
            this.picCCard4.Show();

            // display the card that corresponds to the random value for the second dealer's card and the points
            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                cPoint2 = 1;
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                cPoint2 = 2;
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                cPoint2 = 3;
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                cPoint2 = 4;
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                cPoint2 = 5;
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                cPoint2 = 6;
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                cPoint2 = 7;
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                cPoint2 = 8;
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                cPoint2 = 9;
            }

            else if (cRandom2 == 10)
            {
                cPoint2 = 10;

                if (cRandom2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                }
            }

            // display the card that corresponds to the random value for the third dealer's card and the points
            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                cPoint3 = 1;
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                cPoint3 = 2;
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                cPoint3 = 3;
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                cPoint3 = 4;
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                cPoint3 = 5;
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                cPoint3 = 6;
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                cPoint3 = 7;
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                cPoint3 = 8;
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                cPoint3 = 9;
            }

            else if (cRandom3 == 10)
            {
                cPoint3 = 10;

                if (cRandom3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                }
            }

            // display the card that corresponds to the random value for the third dealer's card and the points
            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                cPoint4 = 1;
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                cPoint4 = 2;
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                cPoint4 = 3;
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                cPoint4 = 4;
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                cPoint4 = 5;
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                cPoint4 = 6;
            }

            else if (cRandom4 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                cPoint4 = 7;
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                cPoint4 = 8;
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                cPoint4 = 9;
            }

            else if (cRandom4 == 10)
            {
                cPoint4 = 10;

                if (cRandom4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                }
            }

            // calculate the dealer's total points and display it
            cTotal = cPoint + cPoint2 + cPoint3 + cPoint4;
            lblCTotal.Text = "Dealer's total: " + Convert.ToString(cTotal);
            this.lblCTotal.Show();

            // check for the results of the game and display the results
            if (cTotal > 21)
            {
                payoff = bet * 1.5;
                MessageBox.Show("Bust for the dealer! You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal == 21)
            {
                payoff = 0 - bet;
                MessageBox.Show("Blackjack for the dealer!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (uTotal == 21)
            {
                payoff = bet * 1.5;
                MessageBox.Show("Blackjack! You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal == uTotal)
            {
                payoff = 0;
                MessageBox.Show("It is a tie!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal > uTotal)
            {
                payoff = 0 - bet;
                MessageBox.Show("The dealer wins!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal < uTotal)
            {
                payoff = bet * 1.5;
                MessageBox.Show("You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // close the form
            Application.Exit();
        }

        private void MniNewGame_Click(object sender, EventArgs e)
        {

            // stop the music
            player.controls.stop();
            // start a new game
            this.Close();

            Simplified21Form2 form2 = new Simplified21Form2();
            this.Hide();
            form2.ShowDialog();

            
        }
    }
}

