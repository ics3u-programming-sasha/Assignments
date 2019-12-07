/*
 * Created by: Sasha Malko
 * Created on: 20-Nov-2019
 * Created for: ICS3U Programming
 * Assignment #6b - Better 21
 * This program allows the user to play a better version of the game 21.
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

namespace Simplified21Sasha
{
    public partial class Better21Form1 : Form
    {

        // declare variables
        double bet;
        int uTotal1;
        int uTotal2;
        int uTotal3;
        int cTotal1;
        int cTotal2;
        int cTotal3;
        int cTotal4;
        int cTotal;
        int uTotal;
        int uTotal4;
        int point = 0;
        int aceValue = 0;
        int cValue = 1;
        int cardNumber;
        int length = 52;
        double payoff;
        WMPLib.WindowsMediaPlayer player;
        WMPLib.WindowsMediaPlayer effectPlayer = new WMPLib.WindowsMediaPlayer();
        Random randNum = new Random();

        public Better21Form1(ref WMPLib.WindowsMediaPlayer soundPlayer)
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
            this.lblFlip.Hide();
            this.lblAce.Hide();
            this.btnOne.Visible = false;
            this.btnOne.Enabled = false;
            this.btnEleven.Visible = false;
            this.btnEleven.Visible = false;

            // set the player as the soundPlayer
            player = soundPlayer;
        }

        // declare the list
        List<Image> listCardImages = new List<Image>();

        // Procedure: NewGame
        // Input: None
        // Output: void
        // Description: This procedure populates a list with images of cards. 
        private void NewGame()
        {
            // populate the deck
            listCardImages.Insert(0, Properties.Resources.AceC);
            listCardImages.Insert(1, Properties.Resources.AceH);
            listCardImages.Insert(2, Properties.Resources.AceD);
            listCardImages.Insert(3, Properties.Resources.AceS);

            listCardImages.Insert(4, Properties.Resources.TwoC);
            listCardImages.Insert(5, Properties.Resources.TwoH);
            listCardImages.Insert(6, Properties.Resources.TwoD);
            listCardImages.Insert(7, Properties.Resources.TwoS);

            listCardImages.Insert(8, Properties.Resources.ThreeC);
            listCardImages.Insert(9, Properties.Resources.ThreeH);
            listCardImages.Insert(10, Properties.Resources.ThreeD);
            listCardImages.Insert(11, Properties.Resources.ThreeS);

            listCardImages.Insert(12, Properties.Resources.FourC);
            listCardImages.Insert(13, Properties.Resources.FourH);
            listCardImages.Insert(14, Properties.Resources.FourD);
            listCardImages.Insert(15, Properties.Resources.FourS);

            listCardImages.Insert(16, Properties.Resources.FiveC);
            listCardImages.Insert(17, Properties.Resources.FiveH);
            listCardImages.Insert(18, Properties.Resources.FiveD);
            listCardImages.Insert(19, Properties.Resources.FiveS);

            listCardImages.Insert(20, Properties.Resources.SixC);
            listCardImages.Insert(21, Properties.Resources.SixH);
            listCardImages.Insert(22, Properties.Resources.SixD);
            listCardImages.Insert(23, Properties.Resources.SixS);

            listCardImages.Insert(24, Properties.Resources.SevenC);
            listCardImages.Insert(25, Properties.Resources.SevenH);
            listCardImages.Insert(26, Properties.Resources.SevenD);
            listCardImages.Insert(27, Properties.Resources.SevenS);

            listCardImages.Insert(28, Properties.Resources.EightC);
            listCardImages.Insert(29, Properties.Resources.EightH);
            listCardImages.Insert(30, Properties.Resources.EightD);
            listCardImages.Insert(31, Properties.Resources.EightS);

            listCardImages.Insert(32, Properties.Resources.NineC);
            listCardImages.Insert(33, Properties.Resources.NineH);
            listCardImages.Insert(34, Properties.Resources.NineD);
            listCardImages.Insert(35, Properties.Resources.NineS);

            listCardImages.Insert(36, Properties.Resources.TenC);
            listCardImages.Insert(37, Properties.Resources.TenH);
            listCardImages.Insert(38, Properties.Resources.TenD);
            listCardImages.Insert(39, Properties.Resources.TenS);

            listCardImages.Insert(40, Properties.Resources.JC);
            listCardImages.Insert(41, Properties.Resources.JH);
            listCardImages.Insert(42, Properties.Resources.JD);
            listCardImages.Insert(43, Properties.Resources.JS);

            listCardImages.Insert(44, Properties.Resources.QC);
            listCardImages.Insert(45, Properties.Resources.QH);
            listCardImages.Insert(46, Properties.Resources.QD);
            listCardImages.Insert(47, Properties.Resources.QS);

            listCardImages.Insert(48, Properties.Resources.KC);
            listCardImages.Insert(49, Properties.Resources.KH);
            listCardImages.Insert(50, Properties.Resources.KD);
            listCardImages.Insert(51, Properties.Resources.KS);

            // call CalculateTotal
            CalculateTotal();
        }

        // Procedure: DealCard
        // Input: ref PictureBox aPictureBox, int cardNumber
        // Output: void
        // Description: This procedure deals cards to the player and the dealer. 
        private void DealCard(ref PictureBox aPictureBox, int cardNumber)
        {
            // display totals and cards
            this.lblDealer.Show();
            this.lblUser.Show();
            this.lblUTotal.Show();
            this.lblCTotal.Show();
            picCard.Visible = true;
            picCard2.Visible = true;
            picCCard.Visible = true;
            picCCard2.Visible = true;

            // set the card image equal to the value of cardNumber in the list
            Image card = listCardImages[cardNumber];
            aPictureBox.Image = card;

            // set the points for each card
            if (cardNumber == 0)
            { 
                point = 0;
            }
            else if (cardNumber == 1)
            {
                point = 0;
            }
            else if (cardNumber == 2)
            {
                point = 0;
            }
            else if (cardNumber == 3)
            {
                point = 0;
            }
            else if (cardNumber == 4)
            {
                point = 2;
            }
            else if (cardNumber == 5)
            {
                point = 2;
            }
            else if (cardNumber == 6)
            {
                point = 2;
            }
            else if (cardNumber == 7)
            {
                point = 2;
            }
            else if (cardNumber == 8)
            {
                point = 3;
            }
            else if (cardNumber == 9)
            {
                point = 3;
            }
            else if (cardNumber == 10)
            {
                point = 3;
            }
            else if (cardNumber == 11)
            {
                point = 3;
            }
            else if (cardNumber == 12)
            {
                point = 4;
            }
            else if (cardNumber == 13)
            {
                point = 4;
            }
            else if (cardNumber == 14)
            {
                point = 4;
            }
            else if (cardNumber == 15)
            {
                point = 4;
            }
            else if (cardNumber == 16)
            {
                point = 5;
            }
            else if (cardNumber == 17)
            {
                point = 5;
            }
            else if (cardNumber == 18)
            {
                point = 5;
            }
            else if (cardNumber == 19)
            {
                point = 5;
            }
            else if (cardNumber == 20)
            {
                point = 6;
            }
            else if (cardNumber == 21)
            {
                point = 6;
            }
            else if (cardNumber == 22)
            {
                point = 6;
            }
            else if (cardNumber == 23)
            {
                point = 6;
            }
            else if (cardNumber == 24)
            {
                point = 7;
            }
            else if (cardNumber == 25)
            {
                point = 7;
            }
            else if (cardNumber == 26)
            {
                point = 7;
            }
            else if (cardNumber == 27)
            {
                point = 7;
            }
            else if (cardNumber == 28)
            {
                point = 8;
            }
            else if (cardNumber == 29)
            {
                point = 8;
            }
            else if (cardNumber == 30)
            {
                point = 8;
            }
            else if (cardNumber == 31)
            {
                point = 8;
            }
            else if (cardNumber == 32)
            {
                point = 9;
            }
            else if (cardNumber == 33)
            {
                point = 9;
            }
            else if (cardNumber == 34)
            {
                point = 9;
            }
            else if (cardNumber == 35)
            {
                point = 9;
            }
            else if (cardNumber == 36)
            {
                point = 10;
            }
            else if (cardNumber == 37)
            {
                point = 10;
            }
            else if (cardNumber == 38)
            {
                point = 10;
            }
            else if (cardNumber == 39)
            {
                point = 10;
            }
            else if (cardNumber == 40)
            {
                point = 10;
            }
            else if (cardNumber == 41)
            {
                point = 10;
            }
            else if (cardNumber == 42)
            {
                point = 10;
            }
            else if (cardNumber == 43)
            {
                point = 10;
            }
            else if (cardNumber == 44)
            {
                point = 10;
            }
            else if (cardNumber == 45)
            {
                point = 10;
            }
            else if (cardNumber == 46)
            {
                point = 10;
            }
            else if (cardNumber == 47)
            {
                point = 10;
            }
            else if (cardNumber == 48)
            {
                point = 10;
            }
            else if (cardNumber == 49)
            {
                point = 10;
            }
            else if (cardNumber == 50)
            {
                point = 10;
            }
            else if (cardNumber == 51)
            {
                point = 10;
            }

        }

        // Procedure: Ace
        // Input: None
        // Output: void
        // Description: This procedure displays objects related to the ace decision and hides other objects. 
        private void Ace()
        {
            // display the objects related to he ace decision
            this.lblAce.Show();
            this.btnOne.Visible = true;
            this.btnOne.Enabled = true;
            this.btnEleven.Visible = true;
            this.btnEleven.Visible = true;

            // hide objects that are not needed
            this.lblHitOrStay.Hide();
            this.btnHit.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Visible = false;
            this.btnStay.Enabled = false;
            this.btnHit2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnStay2.Visible = false;
            this.btnStay2.Enabled = false;
        }

        // Procedure: CalculateTotal
        // Input: None
        // Output: void
        // Description: This procedure displays cards and calculates totals. 
        private void CalculateTotal()
        {
            // call HitOrStay
            HitOrStay();

            // display the cards
            picCard.Visible = true;
            picCard2.Visible = true;
            picCCard.Visible = true;

            // get the cards and points
            if (picCard.Visible == true)
            {
                cardNumber = randNum.Next(0, listCardImages.Count() - 1);
                DealCard(ref this.picCard, cardNumber);
                uTotal1 = point;
            }
            if (picCard2.Visible == true)
            {
                cardNumber = randNum.Next(0, listCardImages.Count() - 1);
                DealCard(ref this.picCard2, cardNumber);
                uTotal2 = point;
            }
            if (picCCard.Visible == true)
            {
                cardNumber = randNum.Next(0, listCardImages.Count() - 1);
                DealCard(ref this.picCCard, cardNumber);
                cTotal1 = point;
            }
            if (picCCard2.Visible == true)
            {
                picCCard2.Image = Properties.Resources.Back;
            }

            // calculate the totals
            if (uTotal1 == 0)
            {
                Ace();
                uTotal = uTotal1 + uTotal2 + aceValue;
                this.lblUTotal.Text = "Your total: ";
            }
            else if (uTotal2 == 0)
            {
                Ace();
                uTotal = uTotal1 + uTotal2 + aceValue;
                this.lblUTotal.Text = "Your total: " + uTotal;
            }
            else
            {
                uTotal = uTotal1 + uTotal2 + aceValue;
                this.lblUTotal.Text = "Your total: " + uTotal;

                if (cTotal1 == 0)
                {
                    cTotal = cTotal1 + cValue;
                    this.lblCTotal.Text = "Dealer's total: " + cTotal;
                }
                else
                {
                    cTotal = cTotal1;
                    this.lblCTotal.Text = "Dealer's total: " + cTotal;
                }
            }

        }

        // Procedure: HitOrStay
        // Input: None
        // Output: void
        // Description: This procedure displays objects related to the hit or stay decision. 
        private void HitOrStay()
        {
            // display objects related to the hit or stay decision
            this.lblHitOrStay.Show();
            this.btnHit.Visible = true;
            this.btnHit.Enabled = true;
            this.btnStay.Visible = true;
            this.btnStay.Enabled = true;
        }

        // Procedure: HitOrStay2
        // Input: None
        // Output: void
        // Description: This procedure displays objects related to the second hit or stay decision. 
        private void HitOrStay2()
        {
            // display objects related to the hit or stay decision
            this.lblHitOrStay.Show();
            this.btnHit.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Visible = false;
            this.btnStay.Enabled = false;
            this.btnHit2.Visible = true;
            this.btnHit2.Enabled = true;
            this.btnStay2.Visible = true;
            this.btnStay2.Enabled = true;
        }

        private void BtnBet_Click(object sender, EventArgs e)
        {
            // convert the string in the text box to an integer
            bet = Convert.ToInt32(this.nudBet.Value);

            // disable the betting objects
            this.btnBet.Enabled = false;
            this.btnBet.Visible = false;
            this.lblBet.Visible = false;
            this.nudBet.Visible = false;

            // call NewGame
            NewGame();
        }


        private void MniExit_Click(object sender, EventArgs e)
        {
            // close the form
            Application.Exit();
        }

        private void MniNewGame_Click(object sender, EventArgs e)
        {

            // start a new game
            this.Close();
            Better21Form1 form1 = new Better21Form1(ref player);
            this.Hide();
            form1.ShowDialog();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            // call HitOrStay2
            HitOrStay2();

            // get the card and total
            cardNumber = randNum.Next(0, listCardImages.Count() - 1);
            DealCard(ref this.picCard3, cardNumber);
            uTotal3 = point;
            this.picCard3.Visible = true;

            // calculate the totals
            if (uTotal3 == 0)
            {
                Ace();
                uTotal = uTotal1 + uTotal2 + uTotal3 + aceValue;
                this.lblUTotal.Text = "Your total: " + uTotal;
            }
            else
            {
                uTotal = uTotal1 + uTotal2 + uTotal3 + aceValue;
                this.lblUTotal.Text = "Your total: " + uTotal;
            }

        }

        // Procedure: DealerCards
        // Input: None
        // Output: void
        // Description: This procedure displays the dealer's cards and totals. 
        private void DealerCards()
        {
            // get the card and total
            cardNumber = randNum.Next(0, listCardImages.Count() - 1);
            DealCard(ref this.picCCard3, cardNumber);
            cTotal3 = point;
            this.picCCard3.Visible = true;

            // get the card and total
            cardNumber = randNum.Next(0, listCardImages.Count() - 1);
            DealCard(ref this.picCCard4, cardNumber);
            cTotal4 = point;
            this.picCCard4.Visible = true;

            // calculate the totals
            if (cTotal1 == 0)
            {
                cTotal = cTotal1 + cTotal2 + cTotal3 + cTotal4 + cValue;
                this.lblCTotal.Text = "Dealer's total: " + cTotal;
            }
            else if (cTotal2 == 0)
            {
                cTotal = cTotal1 + cTotal2 + cTotal3 + cTotal4 + cValue;
                this.lblCTotal.Text = "Dealer's total: " + cTotal;
            }
            else if (cTotal3 == 0)
            {
                cTotal = cTotal1 + cTotal2 + cTotal3 + cTotal4 + cValue;
                this.lblCTotal.Text = "Dealer's total: " + cTotal;
            }
            else if (cTotal4 == 0)
            {
                cTotal = cTotal1 + cTotal2 + cTotal3 + cTotal4 + cValue;
                this.lblCTotal.Text = "Dealer's total: " + cTotal;
            }
            else 
            {
                cTotal = cTotal1 + cTotal2 + cTotal3 + cTotal4;
                this.lblCTotal.Text = "Dealer's total: " + cTotal;
            }

            // call DetermineResults
            DetermineResults();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            // disable the objects related to the hit or stay decision and display the flip label
            this.lblHitOrStay.Hide();
            this.btnHit.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Visible = false;
            this.btnStay.Enabled = false;
            this.lblFlip.Show(); 
        }

        private void btnHit2_Click(object sender, EventArgs e)
        {
            // get the card and total
            cardNumber = randNum.Next(0, listCardImages.Count() - 1);
            DealCard(ref this.picCard4, cardNumber);
            uTotal4 = point;
            this.picCard4.Visible = true;

            // calculate the totals
            if (uTotal4 == 0)
            {
                uTotal4 = 1;

            }
            uTotal = uTotal1 + uTotal2 + uTotal3 + uTotal4 + aceValue;
            this.lblUTotal.Text = "Your total: " + uTotal;

            // disable the objects related to the hit or stay decision and display the flip label
            this.lblHitOrStay.Hide();
            this.btnHit.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Visible = false;
            this.btnStay.Enabled = false;
            this.lblFlip.Show();
            this.lblHitOrStay.Hide();
            this.btnHit2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnStay2.Visible = false;
            this.btnStay2.Enabled = false;

            // set the ace value to 0
            aceValue = 0;

            // set the length of the list to the length minus 8
            length = length - 8;

        }

        // Procedure: DetermineResults
        // Input: None
        // Output: void
        // Description: This procedure displays the results of the game. 
        private void DetermineResults()
        {
            // play the sound effect
            effectPlayer.URL = "TaDa.mp3";
            effectPlayer.controls.play();

            // check the results of the game and display the results
            if (uTotal > 21)
            {
                payoff = 0 - bet;
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
            else if (cTotal < uTotal)
            {
                payoff = bet * 1.5;
                MessageBox.Show("You win!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal > uTotal)
            {
                payoff = 0 - bet;
                MessageBox.Show("The dealer wins!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }
            else if (cTotal == uTotal)
            {
                payoff = 0;
                MessageBox.Show("It is a tie!" + " Your total:" + uTotal + " Dealer's total:" + cTotal + " Your payoff:$" + payoff, "Results");
            }

            // check if there are enough cards to keep playing, and if not, start a new game
            if (length < 7)
            {
                MessageBox.Show("Starting a new game.", "Better 21");
                ClearGame();
                this.listCardImages.Clear();
                NewGame();
                length = 52;
            }
            else
            {
                MessageBox.Show("Starting a new round.", "Better 21");
                ClearGame();
                CalculateTotal();
            }

        }

        // Procedure: ClearGame
        // Input: None
        // Output: void
        // Description: This procedure clears the form from objects. 
        private void ClearGame()
        {
            // clear the form from objects
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
            this.lblAce.Hide();
            this.btnOne.Visible = false;
            this.btnOne.Enabled = false;
            this.btnEleven.Visible = false;
            this.btnEleven.Visible = false;
        }

        private void btnStay2_Click(object sender, EventArgs e)
        {
            // disable objects related to the second hit or stay decision
            this.lblHitOrStay.Hide();
            this.btnHit2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnStay2.Visible = false;
            this.btnStay2.Enabled = false;
            this.lblFlip.Show();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            // disable the objects related to the ace decision
            this.lblAce.Hide();
            this.btnOne.Visible = false;
            this.btnOne.Enabled = false;
            this.btnEleven.Visible = false;
            this.btnEleven.Visible = false;

            // set the ace value equal to 1
            aceValue = 1;

            // call hit or stay if the values equal to 0 or disable hit or stay objects if uTotal4 equals 0
            if (uTotal1 == 0)
            {
                HitOrStay();
            }
            if (uTotal2 == 0)
            {
                HitOrStay();
            }
            else if (uTotal3 == 0 )
            {
                HitOrStay2();
            }
            else if (uTotal4 == 0)
            {
                this.lblHitOrStay.Hide();
                this.btnHit2.Visible = false;
                this.btnHit2.Enabled = false;
                this.btnStay2.Visible = false;
                this.btnStay2.Enabled = false;
                this.lblFlip.Show();
            }
        }

        private void btnEleven_Click(object sender, EventArgs e)
        {
            // disable the objects related to the ace decision
            this.lblAce.Hide();
            this.btnOne.Visible = false;
            this.btnOne.Enabled = false;
            this.btnEleven.Visible = false;
            this.btnEleven.Visible = false;

            // set the ace value equal to 11
            aceValue = 11;

            // call hit or stay if the values equal to 0 or disable hit or stay objects if uTotal4 equals 0
            if (uTotal1 == 0)
            {
                HitOrStay();
            }
            else if (uTotal2 == 0)
            {
                HitOrStay();
            }
            else if (uTotal3 == 0)
            {
                HitOrStay2();
            }
            else if (uTotal4 == 0)
            {
                this.lblHitOrStay.Hide();
                this.btnHit2.Visible = false;
                this.btnHit2.Enabled = false;
                this.btnStay2.Visible = false;
                this.btnStay2.Enabled = false;
                this.lblFlip.Show();
            }
        }

        private void picCCard2_Click(object sender, EventArgs e)
        {
            // get the card and total
            cardNumber = randNum.Next(0, listCardImages.Count() - 1);
            DealCard(ref this.picCCard2, cardNumber);
            cTotal2 = point;
            this.picCCard2.Visible = true;
            cTotal2 = point;

            // hide the flip label
            this.lblFlip.Hide();

            // call DealerCards
            DealerCards();

        }
    }
}