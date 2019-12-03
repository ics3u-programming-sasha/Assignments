/*
 * Created by: Sasha Malko
 * Created on: 25-Oct-2019
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This program allows the user to play a simplified version of the game 21.
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
        int uPoint;
        int uPoint2;
        int uPoint3;
        int uPoint4;
        int cPoint;
        int cPoint2;
        int cPoint3;
        int cPoint4;
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
        double payoff;
        Random rnd = new Random();
        WMPLib.WindowsMediaPlayer player;

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

            // set the player as the soundPlayer
            player = soundPlayer;
        }

        List<Image> listCardImages = new List<Image>();

        private void NewGame()
        {
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

            CalculateTotal();
        }

        private int DealCard(ref PictureBox aPictureBox, int point)
        {
            Random random = new Random();

            this.lblDealer.Show();
            this.lblUser.Show();
            this.lblUTotal.Show();
            this.lblCTotal.Show();
            picCard.Visible = true;
            picCard2.Visible = true;
            picCCard.Visible = true;

            int cardNumber;
            Random randNum = new Random();

            cardNumber = randNum.Next(0 , listCardImages.Count() - 1);


            if (cardNumber == 0)
            {
                aPictureBox.Image = Properties.Resources.AceC;
                listCardImages.RemoveAt(0);
                point = 1;
            }
            else if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.AceH;
                listCardImages.RemoveAt(1);
                point = 1;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.AceD;
                listCardImages.RemoveAt(2);
                point = 1;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.AceS;
                listCardImages.RemoveAt(3);
                point = 1;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.TwoC;
                listCardImages.RemoveAt(4);
                point = 2;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.TwoH;
                listCardImages.RemoveAt(5);
                point = 2;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.TwoD;
                listCardImages.RemoveAt(6);
                point = 2;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.TwoS;
                listCardImages.RemoveAt(7);
                point = 2;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.ThreeC;
                listCardImages.RemoveAt(8);
                point = 3;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.ThreeH;
                listCardImages.RemoveAt(9);
                point = 3;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.ThreeD;
                listCardImages.RemoveAt(10);
                point = 3;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.ThreeS;
                listCardImages.RemoveAt(11);
                point = 3;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.FourC;
                listCardImages.RemoveAt(12);
                point = 4;
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.FourH;
                listCardImages.RemoveAt(13);
                point = 4;
            }
            else if (cardNumber == 14)
            {
                aPictureBox.Image = Properties.Resources.FourD;
                listCardImages.RemoveAt(14);
                point = 4;
            }
            else if (cardNumber == 15)
            {
                aPictureBox.Image = Properties.Resources.FourS;
                listCardImages.RemoveAt(15);
                point = 4;
            }
            else if (cardNumber == 16)
            {
                aPictureBox.Image = Properties.Resources.FiveC;
                listCardImages.RemoveAt(16);
                point = 5;
            }
            else if (cardNumber == 17)
            {
                aPictureBox.Image = Properties.Resources.FiveD;
                listCardImages.RemoveAt(17);
                point = 5;
            }
            else if (cardNumber == 18)
            {
                aPictureBox.Image = Properties.Resources.FiveH;
                listCardImages.RemoveAt(18);
                point = 5;
            }
            else if (cardNumber == 19)
            {
                aPictureBox.Image = Properties.Resources.FiveS;
                listCardImages.RemoveAt(19);
                point = 5;
            }
            else if (cardNumber == 20)
            {
                aPictureBox.Image = Properties.Resources.SixC;
                listCardImages.RemoveAt(20);
                point = 6;
            }
            else if (cardNumber == 21)
            {
                aPictureBox.Image = Properties.Resources.SixD;
                listCardImages.RemoveAt(21);
                point = 6;
            }
            else if (cardNumber == 22)
            {
                aPictureBox.Image = Properties.Resources.SixH;
                listCardImages.RemoveAt(22);
                point = 6;
            }
            else if (cardNumber == 23)
            {
                aPictureBox.Image = Properties.Resources.SixS;
                listCardImages.RemoveAt(23);
                point = 6;
            }
            else if (cardNumber == 24)
            {
                aPictureBox.Image = Properties.Resources.SevenC;
                listCardImages.RemoveAt(24);
                point = 7;
            }
            else if (cardNumber == 25)
            {
                aPictureBox.Image = Properties.Resources.SevenD;
                listCardImages.RemoveAt(25);
                point = 7;
            }
            else if (cardNumber == 26)
            {
                aPictureBox.Image = Properties.Resources.SevenH;
                listCardImages.RemoveAt(26);
                point = 7;
            }
            else if (cardNumber == 27)
            {
                aPictureBox.Image = Properties.Resources.SevenS;
                listCardImages.RemoveAt(27);
                point = 7;
            }
            else if (cardNumber == 28)
            {
                aPictureBox.Image = Properties.Resources.EightC;
                listCardImages.RemoveAt(28);
                point = 8;
            }
            else if (cardNumber == 29)
            {
                aPictureBox.Image = Properties.Resources.EightD;
                listCardImages.RemoveAt(29);
                point = 8;
            }
            else if (cardNumber == 30)
            {
                aPictureBox.Image = Properties.Resources.EightH;
                listCardImages.RemoveAt(30);
                point = 8;
            }
            else if (cardNumber == 31)
            {
                aPictureBox.Image = Properties.Resources.EightS;
                listCardImages.RemoveAt(31);
                point = 8;
            }
            else if (cardNumber == 32)
            {
                aPictureBox.Image = Properties.Resources.NineC;
                listCardImages.RemoveAt(32);
                point = 9;
            }
            else if (cardNumber == 33)
            {
                aPictureBox.Image = Properties.Resources.NineD;
                listCardImages.RemoveAt(33);
                point = 9;
            }
            else if (cardNumber == 34)
            {
                aPictureBox.Image = Properties.Resources.NineH;
                listCardImages.RemoveAt(34);
                point = 9;
            }
            else if (cardNumber == 35)
            {
                aPictureBox.Image = Properties.Resources.NineS;
                listCardImages.RemoveAt(35);
                point = 9;
            }
            else if (cardNumber == 36)
            {
                aPictureBox.Image = Properties.Resources.TenC;
                listCardImages.RemoveAt(36);
                point = 10;
            }
            else if (cardNumber == 37)
            {
                aPictureBox.Image = Properties.Resources.TenD;
                listCardImages.RemoveAt(37);
                point = 10;
            }
            else if (cardNumber == 38)
            {
                aPictureBox.Image = Properties.Resources.TenH;
                listCardImages.RemoveAt(38);
                point = 10;
            }
            else if (cardNumber == 39)
            {
                aPictureBox.Image = Properties.Resources.TenS;
                listCardImages.RemoveAt(39);
                point = 10;
            }
            else if (cardNumber == 40)
            {
                aPictureBox.Image = Properties.Resources.JC;
                listCardImages.RemoveAt(40);
                point = 10;
            }
            else if (cardNumber == 41)
            {
                aPictureBox.Image = Properties.Resources.JD;
                listCardImages.RemoveAt(41);
                point = 10;
            }
            else if (cardNumber == 42)
            {
                aPictureBox.Image = Properties.Resources.JH;
                listCardImages.RemoveAt(42);
                point = 10;
            }
            else if (cardNumber == 43)
            {
                aPictureBox.Image = Properties.Resources.JS;
                listCardImages.RemoveAt(43);
                point = 10;
            }
            else if (cardNumber == 44)
            {
                aPictureBox.Image = Properties.Resources.QC;
                listCardImages.RemoveAt(44);
                point = 10;
            }
            else if (cardNumber == 45)
            {
                aPictureBox.Image = Properties.Resources.QD;
                listCardImages.RemoveAt(45);
                point = 10;
            }
            else if (cardNumber == 46)
            {
                aPictureBox.Image = Properties.Resources.QH;
                listCardImages.RemoveAt(46);
                point = 10;
            }
            else if (cardNumber == 47)
            {
                aPictureBox.Image = Properties.Resources.QS;
                listCardImages.RemoveAt(47);
                point = 10;
            }
            else if (cardNumber == 48)
            {
                aPictureBox.Image = Properties.Resources.KC;
                listCardImages.RemoveAt(48);
                point = 10;
            }
            else if (cardNumber == 49)
            {
                aPictureBox.Image = Properties.Resources.KD;
                listCardImages.RemoveAt(49);
                point = 10;
            }
            else if (cardNumber == 50)
            {
                aPictureBox.Image = Properties.Resources.KH;
                listCardImages.RemoveAt(50);
                point = 10;
            }
            else if (cardNumber == 51)
            {
                aPictureBox.Image = Properties.Resources.KS;
                listCardImages.RemoveAt(51);
                point = 10;
            }

            return point;
        }

        private void CalculateTotal()
        {
            HitOrStay();

            picCard.Visible = true;
            picCard2.Visible = true;
            picCCard.Visible = true;

            if (picCard.Visible == true)
            {
                uTotal1 = DealCard(ref this.picCard, point);
            }
            if (picCard2.Visible == true)
            {
                uTotal2 = DealCard(ref this.picCard2, point);
            }
            if (picCCard.Visible == true)
            {
                cTotal1 = DealCard(ref this.picCCard, point);
            }

            uTotal = uTotal1 + uTotal2;
            this.lblUTotal.Text = "Your total: " + uTotal;

            cTotal = cTotal1;
            this.lblCTotal.Text = "Dealer's total: " + cTotal;
        }

        private void HitOrStay()
        {
            this.lblHitOrStay.Show();
            this.btnHit.Visible = true;
            this.btnHit.Enabled = true;
            this.btnStay.Visible = true;
            this.btnStay.Enabled = true;
        }

        private void HitOrStay2()
        {
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

            // display the deal button and disable the betting objects
            this.btnBet.Enabled = false;
            this.btnBet.Visible = false;
            this.lblBet.Visible = false;
            this.nudBet.Visible = false;

            NewGame();
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
            Better21Form2 form2 = new Better21Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            picCard3.Visible = true;
            uTotal3 = DealCard(ref this.picCard3, point);
            uTotal = uTotal1 + uTotal2 + uTotal3;
            this.lblUTotal.Text = "Your total: " + uTotal;

            HitOrStay2();

        }

        private void DealerCards()
        {
            picCCard2.Visible = true;
            cTotal2 = DealCard(ref this.picCCard2, point);
            picCCard3.Visible = true;
            cTotal3 = DealCard(ref this.picCCard3, point);
            picCCard4.Visible = true;
            cTotal4 = DealCard(ref this.picCCard2, point);


            cTotal = cTotal1 + cTotal2 + cTotal3 + cTotal4;
            this.lblCTotal.Text = "Dealer's total: " + cTotal;

            DetermineResults();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            DealerCards();
        }

        private void btnHit2_Click(object sender, EventArgs e)
        {
            picCard4.Visible = true;
            uTotal4 = DealCard(ref this.picCard4, point);
            uTotal = uTotal1 + uTotal2 + uTotal3 + uTotal4;
            this.lblUTotal.Text = "Your total: " + uTotal;

            this.lblHitOrStay.Hide();
            this.btnHit2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnStay2.Visible = false;
            this.btnStay2.Enabled = false;

            DealerCards();

        }

        private void DetermineResults()
        {
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

            if (listCardImages.Count() < 8)
            {
                MessageBox.Show("Starting a new game.", "Better 21");
                ClearGame();
                this.listCardImages.Clear();
                NewGame();
            }
            else
            {
                MessageBox.Show("Starting a new round.", "Better 21");
                ClearGame();
                CalculateTotal();
            }

        }

        private void ClearGame()
        {
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
        }

        private void btnStay2_Click(object sender, EventArgs e)
        {
            DealerCards();
        }
    }
}