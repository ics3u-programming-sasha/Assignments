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

        const int MIN_NUM = 1;
        const int MAX_NUM = 10;
        const int CMIN_NUM = 1;
        const int CMAX_NUM = 4;

        int uRandom;
        int uRandom2;
        int uRandom3;
        int uRandom5;
        int uRandom6;
        int uRandom8;
        int cRandom;
        int cRandom2;
        int cRandom3;
        int cRandom4;
        int cRandomCard;
        int cRandomCard2;
        int cRandomCard3;
        int cRandomCard4;
        int uRandomCard;
        int uRandomCard2;
        int uRandomCard3;
        int uRandomCard4;
        int uRandomCard5;
        int uRandomCard6;
        int uRandomCard7;
        int uRandomCard8;
        double bet;
        double totalBet;
        double insuranceBet; 
        double cPoints;
        double uPoints;

        Random rnd = new Random();


        public Simplified21Form1()
        {
            InitializeComponent();

            this.picCard.Hide();
            this.picCard2.Hide();
            this.picCard3.Hide();
            this.picCard2.Hide();
            this.picCard5.Hide();
            this.picCard4.Hide();
            this.picCard6.Hide();
            this.picCard5.Hide();
            this.picCard7.Hide();
            this.picCard8.Hide();
            this.picCCard.Hide();
            this.picCCard2.Hide();
            this.picCCard3.Hide();
            this.picCCard4.Hide();
            this.picCard3.Hide();
            this.lblDealer.Hide();
            this.lblUser.Hide();
            this.lblSplit.Hide();
            this.lblAce.Hide();
            this.lblHitOrStay.Hide();
            this.lblInsurance.Hide();
            this.btnDeal.Enabled = false;
            this.btnDeal.Visible = false;
            this.btnYes.Enabled = false;
            this.btnYes.Visible = false;
            this.btnNo.Enabled = false;
            this.btnNo.Visible = false;
            this.btnHit.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Visible = false;
            this.btnStay.Enabled = false;
            this.btnStay2.Visible = false;
            this.btnStay2.Enabled = false;
            this.btnHit2.Enabled = false;
            this.btnHit2.Visible = false;
            this.btnHit3.Visible = false;
            this.btnHit3.Enabled = false;
            this.btnStay3.Visible = false;
            this.btnStay3.Enabled = false;
            this.btnHit4.Visible = false;
            this.btnHit4.Enabled = false;
            this.btnStay4.Visible = false;
            this.btnStay4.Enabled = false;
            this.btnHit5.Visible = false;
            this.btnStay5.Visible = false;
            this.btnHit5.Enabled = false;
            this.btnStay5.Enabled = false;
            this.btnHit6.Visible = false;
            this.btnStay6.Visible = false;
            this.btnHit6.Enabled = false;
            this.btnStay6.Enabled = false;
            this.btnHit7.Visible = false;
            this.btnStay7.Visible = false;
            this.btnHit7.Enabled = false;
            this.btnStay7.Enabled = false;
            this.btnHit8.Visible = false;
            this.btnStay8.Visible = false;
            this.btnHit8.Enabled = false;
            this.btnStay8.Enabled = false;
            this.btnOne.Visible = false;
            this.btnOne.Visible = false;
            this.btnEleven.Enabled = false;
            this.btnEleven.Visible = false;
            this.btnIYes.Visible = false;
            this.btnINo.Visible = false;
            this.btnIYes.Enabled = false;
            this.btnINo.Enabled = false;
            this.nudInsurance.Visible = false;
            this.lblIEnter.Visible = false;
            this.btnEnter.Visible = false;
            this.lblIEnter.Enabled = false; 
        }
        private void BtnBet_Click(object sender, EventArgs e)
        {

            bet = Convert.ToInt32(this.nudBet.Value);

            this.btnBet.Enabled = false;
            this.btnBet.Visible = false;
            this.lblBet.Visible = false;
            this.nudBet.Visible = false;
            this.btnDeal.Enabled = true;
            this.btnDeal.Visible = true;
        }

        private void BtnDeal_Click(object sender, EventArgs e)
        {
            this.btnDeal.Enabled = false;
            this.btnDeal.Visible = false;
            this.btnHit7.Visible = true;
            this.btnStay7.Visible = true;
            this.btnHit7.Enabled = true;
            this.btnStay7.Enabled = true;
            this.lblDealer.Show();
            this.lblUser.Show();
            this.picCard.Show();
            this.picCard2.Show();
            this.picCCard.Show();
            this.picCCard2.Show();

            uRandom = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            uRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandom = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            uRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (uRandom == 1)
            {
                this.picCard.Image = Properties.Resources.Ace;
            }

            else if (uRandom == 2)
            {
                this.picCard.Image = Properties.Resources.Two;
            }

            else if (uRandom == 3)
            {
                this.picCard.Image = Properties.Resources.Three;
            }

            else if (uRandom == 4)
            {
                this.picCard.Image = Properties.Resources.Four; 
            }

            else if (uRandom == 5)
            {
                this.picCard.Image = Properties.Resources.Five;
            }

            else if (uRandom == 6)
            {
                this.picCard.Image = Properties.Resources.Six; 
            }

            else if (uRandom == 7)
            {
                this.picCard.Image = Properties.Resources.Seven;
            }

            else if (uRandom == 8)
            {
                this.picCard.Image = Properties.Resources.Eight; 
            }

            else if (uRandom == 9)
            {
                this.picCard.Image = Properties.Resources.Nine;
            }

            else if (uRandom == 10)
            {

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

            if (uRandom2 == 1)
            {
                this.picCard2.Image = Properties.Resources.Ace;
            }

            else if (uRandom2 == 2)
            {
                this.picCard2.Image = Properties.Resources.Two;
            }

            else if (uRandom2 == 3)
            {
                this.picCard2.Image = Properties.Resources.Three; 
            }

            else if (uRandom2 == 4)
            {
                this.picCard2.Image = Properties.Resources.Four;
            }

            else if (uRandom2 == 5)
            {
                this.picCard2.Image = Properties.Resources.Five;
            }

            else if (uRandom2 == 6)
            {
                this.picCard2.Image = Properties.Resources.Six; 
            }

            else if (uRandom2 == 7)
            {
                this.picCard2.Image = Properties.Resources.Seven;
            }

            else if (uRandom2 == 8)
            {
                this.picCard2.Image = Properties.Resources.Eight;
            }

            else if (uRandom2 == 9)
            {
                this.picCard2.Image = Properties.Resources.Nine;
            }

            else if (uRandom2 == 10)
            {

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


            this.picCCard2.Image = Properties.Resources.Back;

            if (cRandom == 1)
            {
                this.picCCard.Image = Properties.Resources.Ace;
    
                this.lblInsurance.Show();
                this.btnIYes.Visible = true;
                this.btnINo.Visible = true;
                this.btnIYes.Enabled = true;
                this.btnINo.Enabled = true;
                this.btnHit7.Visible = false;
                this.btnStay7.Visible = false;
                this.btnHit7.Enabled = false;
                this.btnStay.Enabled = false;
                this.lblSplit.Visible = false;
                this.btnYes.Visible = false;
                this.btnNo.Visible = false;
                this.btnYes.Enabled = false;
                this.btnNo.Enabled = false;
            }

            else if (cRandom == 2)
            {
                this.picCCard.Image = Properties.Resources.Two;
            }

            else if (cRandom == 3)
            {
                this.picCCard.Image = Properties.Resources.Three;
            }

            else if (cRandom == 4)
            {
                this.picCCard.Image = Properties.Resources.Four;
            }

            else if (cRandom == 5)
            {
                this.picCCard.Image = Properties.Resources.Five;
            }

            else if (cRandom == 6)
            {
                this.picCCard.Image = Properties.Resources.Six;
            }

            else if (cRandom == 7)
            {
                this.picCCard.Image = Properties.Resources.Seven;
            }

            else if (cRandom == 8)
            {
                this.picCCard.Image = Properties.Resources.Eight;
            }

            else if (cRandom == 9)
            {
                this.picCCard.Image = Properties.Resources.Nine;
            }

            else if (cRandom == 10)
            {

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

            /* if (cRandom == 1)
            {
                this.lblSplit.Hide();
                this.btnYes.Enabled = false;
                this.btnYes.Visible = false;
                this.btnNo.Enabled = false;
                this.btnNo.Visible = false;
            }

            else if (uRandom == uRandom2)
            {
                if (uRandom == 10)
                {
                    if (uRandomCard == uRandomCard2)
                    {
                        this.lblSplit.Show();
                        this.btnYes.Enabled = true;
                        this.btnYes.Visible = true;
                        this.btnNo.Enabled = true;
                        this.btnNo.Visible = true;
                        this.btnHit.Visible = false;
                        this.btnStay.Visible = false;
                    }

                    else
                    {
                        this.lblSplit.Hide();
                        this.btnYes.Enabled = false;
                        this.btnYes.Visible = false;
                        this.btnNo.Enabled = false;
                        this.btnNo.Visible = false;
                    }
                }

                else
                {
                    this.lblSplit.Show();
                    this.btnYes.Enabled = true;
                    this.btnYes.Visible = true;
                    this.btnNo.Enabled = true;
                    this.btnNo.Visible = true;
                    this.btnHit.Visible = false;
                    this.btnStay.Visible = false;
                }
            }
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.lblSplit.Hide();
            this.btnYes.Enabled = false;
            this.btnYes.Visible = false;
            this.btnNo.Enabled = false;
            this.btnNo.Visible = false;
            this.picCard3.Show();
            this.picCard2.Show();
            this.picCCard3.Show();

            picCard2.Location = new Point(540, 285);

            uRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            uRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);
            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);


            if (uRandom == 1)
            {

                if (uRandom3 == 1)
                {
                    this.picCard3.Image = Properties.Resources.Ace;
                }

                else if (uRandom3 == 2)
                {
                    this.picCard3.Image = Properties.Resources.Two;
                }

                else if (uRandom3 == 3)
                {
                    this.picCard3.Image = Properties.Resources.Three;
                }

                else if (uRandom3 == 4)
                {
                    this.picCard3.Image = Properties.Resources.Four;
                }

                else if (uRandom3 == 5)
                {
                    this.picCard3.Image = Properties.Resources.Five;
                }

                else if (uRandom3 == 6)
                {
                    this.picCard3.Image = Properties.Resources.Six;
                }

                else if (uRandom3 == 7)
                {
                    this.picCard3.Image = Properties.Resources.Seven;
                }

                else if (uRandom3 == 8)
                {
                    this.picCard3.Image = Properties.Resources.Eight;
                }

                else if (uRandom3 == 9)
                {
                    this.picCard3.Image = Properties.Resources.Nine;
                }

                else if (uRandom3 == 10)
                {

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

                if (uRandom == 1)
                {

                    if (uRandom2 == 1)
                    {
                        this.picCard2.Image = Properties.Resources.Ace;
                    }

                    else if (uRandom2 == 2)
                    {
                        this.picCard2.Image = Properties.Resources.Two;
                    }

                    else if (uRandom2 == 3)
                    {
                        this.picCard2.Image = Properties.Resources.Three;
                    }

                    else if (uRandom2 == 4)
                    {
                        this.picCard2.Image = Properties.Resources.Four;
                    }

                    else if (uRandom2 == 5)
                    {
                        this.picCard2.Image = Properties.Resources.Five;
                    }

                    else if (uRandom2 == 6)
                    {
                        this.picCard2.Image = Properties.Resources.Six;
                    }

                    else if (uRandom2 == 7)
                    {
                        this.picCard2.Image = Properties.Resources.Seven;
                    }

                    else if (uRandom2 == 8)
                    {
                        this.picCard2.Image = Properties.Resources.Eight;
                    }

                    else if (uRandom2 == 9)
                    {
                        this.picCard2.Image = Properties.Resources.Nine;
                    }

                    else if (uRandom2 == 10)
                    {

                        if (uRandomCard4 == 1)
                        {
                            this.picCard2.Image = Properties.Resources.Ten;
                        }

                        else if (uRandomCard4 == 2)
                        {
                            this.picCard2.Image = Properties.Resources.Jack;
                        }

                        else if (uRandomCard4 == 3)
                        {
                            this.picCard2.Image = Properties.Resources.Queen;
                        }

                        else if (uRandomCard4 == 4)
                        {
                            this.picCard2.Image = Properties.Resources.King;
                        }
                    }
                }

                if (cRandom3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ace;
                }

                else if (cRandom3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.Two;

                }

                else if (cRandom3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Three;

                }

                else if (cRandom3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Four;

                }

                else if (cRandom3 == 5)
                {
                    this.picCCard3.Image = Properties.Resources.Five;

                }

                else if (cRandom3 == 6)
                {
                    this.picCCard3.Image = Properties.Resources.Six;

                }

                else if (cRandom3 == 7)
                {
                    this.picCCard3.Image = Properties.Resources.Seven;

                }

                else if (cRandom3 == 8)
                {
                    this.picCCard3.Image = Properties.Resources.Eight;

                }

                else if (cRandom3 == 9)
                {
                    this.picCCard3.Image = Properties.Resources.Nine;

                }

                else if (cRandom3 == 10)
                {

                    if (cRandomCard3 == 1)
                    {
                        this.picCCard3.Image = Properties.Resources.Ten;
    
                    }

                    else if (cRandomCard3 == 2)
                    {
                        this.picCCard3.Image = Properties.Resources.King;
    
                    }

                    else if (cRandomCard3 == 3)
                    {
                        this.picCCard3.Image = Properties.Resources.Queen;
    
                    }

                    else if (cRandomCard3 == 4)
                    {
                        this.picCCard3.Image = Properties.Resources.Jack;
    
                    }
                }
            }

            else
            {
                this.btnHit.Visible = true;
                this.btnStay.Visible = true;
                this.btnHit.Enabled = true;
                this.btnStay.Enabled = true;
                this.lblHitOrStay.Hide();
            }
        */}

        private void BtnHit_Click(object sender, EventArgs e)
        {
            this.btnHit.Visible = false;
            this.btnStay.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;

            this.btnHit2.Visible = true;
            this.btnStay2.Visible = true;
            this.btnHit2.Enabled = true;
            this.btnStay2.Enabled = true;

            this.picCard2.Show(); 

            if (uRandom2 == 1)
            {
                this.picCard2.Image = Properties.Resources.Ace;
    
            }

            else if (uRandom2 == 2)
            {
                this.picCard2.Image = Properties.Resources.Two;
    
            }

            else if (uRandom2 == 3)
            {
                this.picCard2.Image = Properties.Resources.Three;
    
            }

            else if (uRandom2 == 4)
            {
                this.picCard2.Image = Properties.Resources.Four;
    
            }

            else if (uRandom2 == 5)
            {
                this.picCard2.Image = Properties.Resources.Five;
    
            }

            else if (uRandom2 == 6)
            {
                this.picCard2.Image = Properties.Resources.Six;
    
            }

            else if (uRandom2 == 7)
            {
                this.picCard2.Image = Properties.Resources.Seven;
    
            }

            else if (uRandom2 == 8)
            {
                this.picCard2.Image = Properties.Resources.Eight;
    
            }

            else if (uRandom2 == 9)
            {
                this.picCard2.Image = Properties.Resources.Nine;
    
            }

            else if (uRandom2 == 10)
            {

                if (uRandomCard4 == 1)
                {
                    this.picCard2.Image = Properties.Resources.Ten;
        
                }

                else if (uRandomCard4 == 2)
                {
                    this.picCard2.Image = Properties.Resources.Jack;
        
                }

                else if (uRandomCard4 == 3)
                {
                    this.picCard2.Image = Properties.Resources.Queen;
        
                }

                else if (uRandomCard4 == 4)
                {
                    this.picCard2.Image = Properties.Resources.King;
        
                }
            }
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.btnYes.Visible = false;
            this.btnYes.Visible = false;
            this.btnYes.Enabled = false;
            this.btnYes.Enabled = false;
            this.btnNo.Visible = false;
            this.btnNo.Visible = false;
            this.btnNo.Enabled = false;
            this.btnNo.Enabled = false;
            this.lblSplit.Hide();

            this.btnHit5.Visible = true;
            this.btnStay5.Visible = true;
            this.btnHit5.Enabled = true;
            this.btnStay5.Enabled = true;
            this.lblHitOrStay.Hide();

        }

        private void BtnHit2_Click(object sender, EventArgs e)
        {
            this.btnHit2.Visible = false;
            this.btnStay2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnStay2.Enabled = false;

            this.btnHit3.Visible = true;
            this.btnStay3.Visible = true;
            this.btnHit3.Enabled = true;
            this.btnStay3.Enabled = true;

            uRandom5 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard5 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (uRandom5 == 1)
            {
                this.picCard5.Image = Properties.Resources.Ace;
                this.picCard5.Show();
            }

            else if (uRandom5 == 2)
            {
                this.picCard5.Image = Properties.Resources.Two;
                this.picCard5.Show();
            }

            else if (uRandom5 == 3)
            {
                this.picCard5.Image = Properties.Resources.Three;
                this.picCard5.Show();
            }

            else if (uRandom5 == 4)
            {
                this.picCard5.Image = Properties.Resources.Four;
                this.picCard5.Show();
            }

            else if (uRandom5 == 5)
            {
                this.picCard5.Image = Properties.Resources.Five;
                this.picCard5.Show();
            }

            else if (uRandom5 == 6)
            {
                this.picCard5.Image = Properties.Resources.Six;
                this.picCard5.Show();
            }

            else if (uRandom5 == 7)
            {
                this.picCard5.Image = Properties.Resources.Seven;
                this.picCard5.Show();
            }

            else if (uRandom5 == 8)
            {
                this.picCard5.Image = Properties.Resources.Eight;
                this.picCard5.Show();
            }

            else if (uRandom5 == 9)
            {
                this.picCard5.Image = Properties.Resources.Nine;
                this.picCard5.Show();
            }

            else if (uRandom5 == 10)
            {

                if (uRandomCard5 == 1)
                {
                    this.picCard5.Image = Properties.Resources.Ten;
                    this.picCard5.Show();
                }

                else if (uRandomCard5 == 2)
                {
                    this.picCard5.Image = Properties.Resources.Jack;
                    this.picCard5.Show();
                }

                else if (uRandomCard5 == 3)
                {
                    this.picCard5.Image = Properties.Resources.Queen;
                    this.picCard5.Show();
                }

                else if (uRandomCard5 == 4)
                {
                    this.picCard5.Image = Properties.Resources.King;
                    this.picCard5.Show();
                }

            }
        }

        private void BtnHit3_Click(object sender, EventArgs e)
        {
            this.btnHit3.Visible = false;
            this.btnStay3.Visible = false;
            this.btnHit3.Enabled = false;
            this.btnStay3.Enabled = false;

            this.btnHit4.Visible = true;
            this.btnStay4.Visible = true;
            this.btnHit4.Enabled = true;
            this.btnStay4.Enabled = true;

            uRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (uRandom3 == 1)
            {
                this.picCard3.Image = Properties.Resources.Ace;
                this.picCard3.Show();
            }

            else if (uRandom3 == 2)
            {
                this.picCard3.Image = Properties.Resources.Two;
                this.picCard3.Show();
            }

            else if (uRandom3 == 3)
            {
                this.picCard3.Image = Properties.Resources.Three;
                this.picCard3.Show();
            }

            else if (uRandom3 == 4)
            {
                this.picCard3.Image = Properties.Resources.Four;
                this.picCard3.Show();
            }

            else if (uRandom3 == 5)
            {
                this.picCard3.Image = Properties.Resources.Five;
                this.picCard3.Show();
            }

            else if (uRandom3 == 6)
            {
                this.picCard3.Image = Properties.Resources.Six;
                this.picCard3.Show();
            }

            else if (uRandom3 == 7)
            {
                this.picCard3.Image = Properties.Resources.Seven;
                this.picCard3.Show();
            }

            else if (uRandom3 == 8)
            {
                this.picCard3.Image = Properties.Resources.Eight;
                this.picCard3.Show();
            }

            else if (uRandom3 == 9)
            {
                this.picCard3.Image = Properties.Resources.Nine;
                this.picCard3.Show();
            }

            else if (uRandom3 == 10)
            {

                if (uRandomCard3 == 1)
                {
                    this.picCard3.Image = Properties.Resources.Ten;
                    this.picCard3.Show();
                }

                else if (uRandomCard3 == 2)
                {
                    this.picCard3.Image = Properties.Resources.Jack;
                    this.picCard3.Show();
                }

                else if (uRandomCard3 == 3)
                {
                    this.picCard3.Image = Properties.Resources.Queen;
                    this.picCard3.Show();
                }

                else if (uRandomCard3 == 4)
                {
                    this.picCard3.Image = Properties.Resources.King;
                    this.picCard3.Show();
                }
            }
        }

        private void BtnHit4_Click(object sender, EventArgs e)
        {
            uRandom6 = rnd.Next(MIN_NUM, MAX_NUM + 1);

            uRandomCard6 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            this.btnHit4.Visible = false;
            this.btnStay4.Visible = false;
            this.btnHit4.Enabled = false;
            this.btnStay4.Enabled = false;


            if (uRandom6 == 1)
            {
                this.picCard6.Image = Properties.Resources.Ace;
                this.picCard6.Show();
            }

            else if (uRandom6 == 2)
            {
                this.picCard6.Image = Properties.Resources.Two;
                this.picCard6.Show();
            }

            else if (uRandom6 == 3)
            {
                this.picCard6.Image = Properties.Resources.Three;
                this.picCard6.Show();
            }

            else if (uRandom6 == 4)
            {
                this.picCard6.Image = Properties.Resources.Four;
                this.picCard6.Show();
            }

            else if (uRandom6 == 5)
            {
                this.picCard6.Image = Properties.Resources.Five;
                this.picCard6.Show();
            }

            else if (uRandom6 == 6)
            {
                this.picCard6.Image = Properties.Resources.Six;
                this.picCard6.Show();
            }

            else if (uRandom6 == 7)
            {
                this.picCard6.Image = Properties.Resources.Seven;
                this.picCard6.Show();
            }

            else if (uRandom6 == 8)
            {
                this.picCard6.Image = Properties.Resources.Eight;
                this.picCard6.Show();
            }

            else if (uRandom6 == 9)
            {
                this.picCard6.Image = Properties.Resources.Nine;
                this.picCard6.Show();
            }

            else if (uRandom6 == 10)
            {

                if (uRandomCard6 == 1)
                {
                    this.picCard6.Image = Properties.Resources.Ten;
                    this.picCard6.Show();
                }

                else if (uRandomCard6 == 2)
                {
                    this.picCard6.Image = Properties.Resources.Jack;
                    this.picCard6.Show();
                }

                else if (uRandomCard6 == 3)
                {
                    this.picCard6.Image = Properties.Resources.Queen;
                    this.picCard6.Show();
                }

                else if (uRandomCard6 == 4)
                {
                    this.picCard6.Image = Properties.Resources.King;
                    this.picCard6.Show();
                }
            }

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2 + uRandom2 + uRandom5 + uRandom6 + uRandom5;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie !" + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win!" + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnHit5_Click(object sender, EventArgs e)
        {
            this.btnHit5.Visible = false;
            this.btnStay5.Visible = false;
            this.btnHit5.Enabled = false;
            this.btnStay5.Enabled = false;

            this.btnHit6.Visible = true;
            this.btnStay6.Visible = true;
            this.btnHit6.Enabled = true;
            this.btnStay6.Enabled = true;

            uRandom5 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard7 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (uRandom5 == 1)
            {
                this.picCard5.Image = Properties.Resources.Ace;
                this.picCard5.Show();
            }

            else if (uRandom5 == 2)
            {
                this.picCard5.Image = Properties.Resources.Two;
                this.picCard5.Show();
            }

            else if (uRandom5 == 3)
            {
                this.picCard5.Image = Properties.Resources.Three;
                this.picCard5.Show();
            }

            else if (uRandom5 == 4)
            {
                this.picCard5.Image = Properties.Resources.Four;
                this.picCard5.Show();
            }

            else if (uRandom5 == 5)
            {
                this.picCard5.Image = Properties.Resources.Five;
                this.picCard5.Show();
            }

            else if (uRandom5 == 6)
            {
                this.picCard5.Image = Properties.Resources.Six;
                this.picCard5.Show();
            }

            else if (uRandom5 == 7)
            {
                this.picCard5.Image = Properties.Resources.Seven;
                this.picCard5.Show();
            }

            else if (uRandom5 == 8)
            {
                this.picCard5.Image = Properties.Resources.Eight;
                this.picCard5.Show();
            }

            else if (uRandom5 == 9)
            {
                this.picCard5.Image = Properties.Resources.Nine;
                this.picCard5.Show();
            }

            else if (uRandom5 == 10)
            {

                if (uRandomCard7 == 1)
                {
                    this.picCard5.Image = Properties.Resources.Ten;
                    this.picCard5.Show();
                }

                else if (uRandomCard7 == 2)
                {
                    this.picCard5.Image = Properties.Resources.Jack;
                    this.picCard5.Show();
                }

                else if (uRandomCard7 == 3)
                {
                    this.picCard5.Image = Properties.Resources.Queen;
                    this.picCard5.Show();
                }

                else if (uRandomCard7 == 4)
                {
                    this.picCard5.Image = Properties.Resources.King;
                    this.picCard5.Show();
                }
            }
        }

        private void BtnHit6_Click(object sender, EventArgs e)
        {
            this.btnHit6.Visible = false;
            this.btnStay6.Visible = false;
            this.btnHit6.Enabled = false;
            this.btnStay6.Enabled = false;

            this.btnHit7.Visible = false;
            this.btnStay7.Visible = false;
            this.btnHit7.Enabled = false;
            this.btnStay7.Enabled = false;

            uRandom8 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            uRandomCard8 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (uRandom8 == 1)
            {
                this.picCard8.Image = Properties.Resources.Ace;
                this.picCard8.Show();
            }

            else if (uRandom8 == 2)
            {
                this.picCard8.Image = Properties.Resources.Two;
                this.picCard8.Show();
            }

            else if (uRandom8 == 3)
            {
                this.picCard8.Image = Properties.Resources.Three;
                this.picCard8.Show();
            }

            else if (uRandom8 == 4)
            {
                this.picCard8.Image = Properties.Resources.Four;
                this.picCard8.Show();
            }

            else if (uRandom8 == 5)
            {
                this.picCard8.Image = Properties.Resources.Five;
                this.picCard8.Show();
            }

            else if (uRandom8 == 6)
            {
                this.picCard8.Image = Properties.Resources.Six;
                this.picCard8.Show();
            }

            else if (uRandom8 == 7)
            {
                this.picCard8.Image = Properties.Resources.Seven;
                this.picCard8.Show();
            }

            else if (uRandom8 == 8)
            {
                this.picCard8.Image = Properties.Resources.Eight;
                this.picCard8.Show();
            }

            else if (uRandom8 == 9)
            {
                this.picCard8.Image = Properties.Resources.Nine;
                this.picCard8.Show();
            }

            else if (uRandom8 == 10)
            {

                if (uRandomCard8 == 1)
                {
                    this.picCard8.Image = Properties.Resources.Ten;
                    this.picCard8.Show();
                }

                else if (uRandomCard8 == 2)
                {
                    this.picCard8.Image = Properties.Resources.Jack;
                    this.picCard8.Show();
                }

                else if (uRandomCard8 == 3)
                {
                    this.picCard8.Image = Properties.Resources.Queen;
                    this.picCard8.Show();
                }

                else if (uRandomCard8 == 4)
                {
                    this.picCard8.Image = Properties.Resources.King;
                    this.picCard8.Show();
                }
            }
        }

        private void BtnHit7_Click(object sender, EventArgs e)
        {
            this.btnHit7.Visible = false;
            this.btnStay7.Visible = false;
            this.btnHit7.Enabled = false;
            this.btnStay7.Enabled = false;

            this.btnHit8.Visible = true;
            this.btnStay8.Visible = true;
            this.btnHit8.Enabled = true;
            this.btnStay8.Enabled = true;

            uRandom5 = rnd.Next(MIN_NUM, MAX_NUM + 1);

            uRandomCard7 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (uRandom5 == 1)
            {
                this.picCard5.Image = Properties.Resources.Ace;
                this.picCard5.Show();
            }

            else if (uRandom5 == 2)
            {
                this.picCard5.Image = Properties.Resources.Two;
                this.picCard5.Show();
            }

            else if (uRandom5 == 3)
            {
                this.picCard5.Image = Properties.Resources.Three;
                this.picCard5.Show();
            }

            else if (uRandom5 == 4)
            {
                this.picCard5.Image = Properties.Resources.Four;
                this.picCard5.Show();
            }

            else if (uRandom5 == 5)
            {
                this.picCard5.Image = Properties.Resources.Five;
                this.picCard5.Show();
            }

            else if (uRandom5 == 6)
            {
                this.picCard5.Image = Properties.Resources.Six;
                this.picCard5.Show();
            }

            else if (uRandom5 == 7)
            {
                this.picCard5.Image = Properties.Resources.Seven;
                this.picCard5.Show();
            }

            else if (uRandom5 == 8)
            {
                this.picCard5.Image = Properties.Resources.Eight;
                this.picCard5.Show();
            }

            else if (uRandom5 == 9)
            {
                this.picCard5.Image = Properties.Resources.Nine;
                this.picCard5.Show();
            }

            else if (uRandom5 == 10)
            {

                if (uRandomCard7 == 1)
                {
                    this.picCard5.Image = Properties.Resources.Ten;
                    this.picCard5.Show();
                }

                else if (uRandomCard7 == 2)
                {
                    this.picCard5.Image = Properties.Resources.Jack;
                    this.picCard5.Show();
                }

                else if (uRandomCard7 == 3)
                {
                    this.picCard5.Image = Properties.Resources.Queen;
                    this.picCard5.Show();
                }

                else if (uRandomCard7 == 4)
                {
                    this.picCard5.Image = Properties.Resources.King;
                    this.picCard5.Show();
                }

            }
        }

        private void BtnHit8_Click(object sender, EventArgs e)
        {
            this.btnHit8.Visible = false;
            this.btnStay8.Visible = false;
            this.btnHit8.Enabled = false;
            this.btnStay8.Enabled = false;

            uRandom8 = rnd.Next(MIN_NUM, MAX_NUM + 1);

            uRandomCard8 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (uRandom8 == 1)
            {
                this.picCard8.Image = Properties.Resources.Ace;
                this.picCard8.Show();
            }

            else if (uRandom8 == 2)
            {
                this.picCard8.Image = Properties.Resources.Two;
                this.picCard8.Show();
            }

            else if (uRandom8 == 3)
            {
                this.picCard8.Image = Properties.Resources.Three;
                this.picCard8.Show();
            }

            else if (uRandom8 == 4)
            {
                this.picCard8.Image = Properties.Resources.Four;
                this.picCard8.Show();
            }

            else if (uRandom8 == 5)
            {
                this.picCard8.Image = Properties.Resources.Five;
                this.picCard8.Show();
            }

            else if (uRandom8 == 6)
            {
                this.picCard8.Image = Properties.Resources.Six;
                this.picCard8.Show();
            }

            else if (uRandom8 == 7)
            {
                this.picCard8.Image = Properties.Resources.Seven;
                this.picCard8.Show();
            }

            else if (uRandom8 == 8)
            {
                this.picCard8.Image = Properties.Resources.Eight;
                this.picCard8.Show();
            }

            else if (uRandom8 == 9)
            {
                this.picCard8.Image = Properties.Resources.Nine;
                this.picCard8.Show();
            }

            else if (uRandom8 == 10)
            {

                if (uRandomCard8 == 1)
                {
                    this.picCard8.Image = Properties.Resources.Ten;
                    this.picCard8.Show();
                }

                else if (uRandomCard8 == 2)
                {
                    this.picCard8.Image = Properties.Resources.Jack;
                    this.picCard8.Show();
                }

                else if (uRandomCard8 == 3)
                {
                    this.picCard8.Image = Properties.Resources.Queen;
                    this.picCard8.Show();
                }

                else if (uRandomCard8 == 4)
                {
                    this.picCard8.Image = Properties.Resources.King;
                    this.picCard8.Show();
                }
            }

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }
            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2 + uRandom5 + uRandom8;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie !" + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win!" + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }

        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            this.btnHit.Visible = false;
            this.btnStay.Visible = false;
            this.btnHit.Enabled = false;
            this.btnStay.Enabled = false;

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandom2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2 + uRandom5;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie! Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins!" + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnStay2_Click(object sender, EventArgs e)
        {
            this.btnHit2.Visible = false;
            this.btnStay2.Visible = false;
            this.btnHit2.Enabled = false;
            this.btnStay2.Enabled = false;


            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandom2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2 + uRandom5 + uRandom8;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie! Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins!" + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnStay3_Click(object sender, EventArgs e)
        {
            this.btnHit3.Visible = false;
            this.btnStay3.Visible = false;
            this.btnHit3.Enabled = false;
            this.btnStay3.Enabled = false;

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandom2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins!" + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " +  Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win !" + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " +  Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " +  Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnStay8_Click(object sender, EventArgs e)
        {
            this.btnHit8.Visible = false;
            this.btnStay8.Visible = false;
            this.btnHit8.Enabled = false;
            this.btnStay8.Enabled = false;

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }
            uPoints = uRandom + uRandom2 + uRandom5 + uRandom8;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie!" + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! " + "The dealer wins!" + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnStay4_Click(object sender, EventArgs e)
        {
            this.btnHit4.Visible = false;
            this.btnStay4.Visible = false;
            this.btnHit4.Enabled = false;
            this.btnStay4.Enabled = false;

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2 + uRandom5;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie!" + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! " + "The dealer wins!" + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnStay5_Click(object sender, EventArgs e)
        {

            this.btnHit5.Visible = false;
            this.btnStay5.Visible = false;
            this.btnHit5.Enabled = false;
            this.btnStay5.Enabled = false;

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2 + uRandom5 + uRandom8;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie !" + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win!" + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnStay6_Click(object sender, EventArgs e)
        {
            this.btnHit6.Visible = false;
            this.btnStay6.Visible = false;
            this.btnHit6.Enabled = false;
            this.btnStay6.Enabled = false;

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            uPoints = uRandom + uRandom2 +  uRandom5 + uRandom8;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie! Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win! Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnStay7_Click(object sender, EventArgs e)
        {
            this.btnHit7.Visible = false;
            this.btnStay7.Visible = false;
            this.btnHit7.Enabled = false;
            this.btnStay7.Enabled = false;

            cRandom2 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard2 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom2 == 1)
            {
                this.picCCard2.Image = Properties.Resources.Ace;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 2)
            {
                this.picCCard2.Image = Properties.Resources.Two;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 3)
            {
                this.picCCard2.Image = Properties.Resources.Three;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 4)
            {
                this.picCCard2.Image = Properties.Resources.Four;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 5)
            {
                this.picCCard2.Image = Properties.Resources.Five;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 6)
            {
                this.picCCard2.Image = Properties.Resources.Six;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 7)
            {
                this.picCCard2.Image = Properties.Resources.Seven;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 8)
            {
                this.picCCard2.Image = Properties.Resources.Eight;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 9)
            {
                this.picCCard2.Image = Properties.Resources.Nine;
                this.picCCard2.Show();
            }

            else if (cRandom2 == 10)
            {

                if (cRandomCard2 == 1)
                {
                    this.picCCard2.Image = Properties.Resources.Ten;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 2)
                {
                    this.picCCard2.Image = Properties.Resources.King;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 3)
                {
                    this.picCCard2.Image = Properties.Resources.Queen;
                    this.picCCard2.Show();
                }

                else if (cRandomCard2 == 4)
                {
                    this.picCCard2.Image = Properties.Resources.Jack;
                    this.picCCard2.Show();
                }
            }

            cRandom3 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard3 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom3 == 1)
            {
                this.picCCard3.Image = Properties.Resources.Ace;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 2)
            {
                this.picCCard3.Image = Properties.Resources.Two;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 3)
            {
                this.picCCard3.Image = Properties.Resources.Three;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 4)
            {
                this.picCCard3.Image = Properties.Resources.Four;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 5)
            {
                this.picCCard3.Image = Properties.Resources.Five;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 6)
            {
                this.picCCard3.Image = Properties.Resources.Six;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard3.Image = Properties.Resources.Seven;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 8)
            {
                this.picCCard3.Image = Properties.Resources.Eight;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 9)
            {
                this.picCCard3.Image = Properties.Resources.Nine;
                this.picCCard3.Show();
            }

            else if (cRandom3 == 10)
            {

                if (cRandomCard3 == 1)
                {
                    this.picCCard3.Image = Properties.Resources.Ten;

                }

                else if (cRandomCard3 == 2)
                {
                    this.picCCard3.Image = Properties.Resources.King;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 3)
                {
                    this.picCCard3.Image = Properties.Resources.Queen;
                    this.picCCard3.Show();
                }

                else if (cRandomCard3 == 4)
                {
                    this.picCCard3.Image = Properties.Resources.Jack;
                    this.picCCard3.Show();
                }
            }

            cRandom4 = rnd.Next(MIN_NUM, MAX_NUM + 1);
            cRandomCard4 = rnd.Next(CMIN_NUM, CMAX_NUM + 1);

            if (cRandom4 == 1)
            {
                this.picCCard4.Image = Properties.Resources.Ace;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 2)
            {
                this.picCCard4.Image = Properties.Resources.Two;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 3)
            {
                this.picCCard4.Image = Properties.Resources.Three;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 4)
            {
                this.picCCard4.Image = Properties.Resources.Four;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 5)
            {
                this.picCCard4.Image = Properties.Resources.Five;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 6)
            {
                this.picCCard4.Image = Properties.Resources.Six;
                this.picCCard4.Show();
            }

            else if (cRandom3 == 7)
            {
                this.picCCard4.Image = Properties.Resources.Seven;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 8)
            {
                this.picCCard4.Image = Properties.Resources.Eight;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 9)
            {
                this.picCCard4.Image = Properties.Resources.Nine;
                this.picCCard4.Show();
            }

            else if (cRandom4 == 10)
            {

                if (cRandomCard4 == 1)
                {
                    this.picCCard4.Image = Properties.Resources.Ten;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 2)
                {
                    this.picCCard4.Image = Properties.Resources.King;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 3)
                {
                    this.picCCard4.Image = Properties.Resources.Queen;
                    this.picCCard4.Show();
                }

                else if (cRandomCard4 == 4)
                {
                    this.picCCard4.Image = Properties.Resources.Jack;
                    this.picCCard4.Show();
                }
            }

            if (uRandom == 1)
            {
                this.lblAce.Show();
                this.btnEleven.Visible = true;
                this.btnOne.Visible = true;
                this.btnEleven.Enabled = true;
                this.btnOne.Enabled = true;
            }

            uPoints = uRandom + uRandom2;
            cPoints = cRandom + cRandom2 + cRandom3 + cRandom4;

            if (uPoints > 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Bust! The dealer wins! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (cPoints > 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Bust for the dealer! " + "You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == cPoints)
            {
                totalBet = 0 + insuranceBet;
                MessageBox.Show("Tie! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            if (cPoints == 21)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("Blackjack for the dealer! The dealer wins! " + "Your payoff: $" +  Convert.ToString(totalBet)  + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints == 21)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("Blackjack! You win! " + "Your payoff: $" + Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints > cPoints)
            {
                totalBet = bet * 1.5 + insuranceBet;
                MessageBox.Show("You win! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
            else if (uPoints < cPoints)
            {
                totalBet = 0 - bet + insuranceBet;
                MessageBox.Show("The dealer wins! " + "Your payoff: $"+ Convert.ToString(totalBet) + " Your total: " + Convert.ToString(uPoints), "Results");
            }
        }

        private void BtnIYes_Click(object sender, EventArgs e)
        {
            nudInsurance.Visible = true;
            insuranceBet = Convert.ToInt32(nudInsurance.Value);
            this.btnIYes.Visible = false;
            this.btnIYes.Enabled = false;
            this.btnINo.Enabled = false;
            this.btnINo.Visible = false;
            this.lblIEnter.Visible = true; 
            this.lblInsurance.Visible = false;
            this.btnEnter.Visible = true;
            this.lblIEnter.Enabled = true;
        }

        private void BtnINo_Click(object sender, EventArgs e)
        {
            insuranceBet = 0;

            this.lblIEnter.Visible = false;
            this.btnEnter.Visible = false;
            this.lblIEnter.Enabled = false;
            this.btnINo.Visible = false;
            this.btnIYes.Visible = false;
            this.btnINo.Enabled = false;
            this.btnIYes.Enabled = false;
            this.nudInsurance.Visible = false;
            this.lblInsurance.Hide(); 
            this.btnHit7.Visible = true;
            this.btnStay7.Visible = true;
            this.btnHit7.Enabled = true;
            this.btnStay7.Enabled = true;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (cRandom2 == 10)
            {
                insuranceBet = bet * 2;
            }
            else
            {
                insuranceBet = 0 - bet;
            }

            this.lblIEnter.Visible = false;
            this.btnEnter.Visible = false;
            this.lblIEnter.Enabled = false;
            this.nudInsurance.Visible = false;
            if (uRandom == uRandom2)
            {
                if (uRandom == 10)
                {
                    if (uRandomCard == uRandomCard2)
                    {
                        this.lblSplit.Show();
                        this.btnYes.Enabled = true;
                        this.btnYes.Visible = true;
                        this.btnNo.Enabled = true;
                        this.btnNo.Visible = true;
                    }
                    else
                    {
                        this.lblSplit.Hide();
                        this.btnYes.Enabled = false;
                        this.btnYes.Visible = false;
                        this.btnNo.Enabled = false;
                        this.btnNo.Visible = false;
                    }
                }
                else
                {
                    this.lblSplit.Show();
                    this.btnYes.Enabled = true;
                    this.btnYes.Visible = true;
                    this.btnNo.Enabled = true;
                    this.btnNo.Visible = true;
                }
            }

            else
            {
                this.btnHit7.Visible = true;
                this.btnStay7.Visible = true;
                this.btnHit7.Enabled = true;
                this.btnStay7.Enabled = true;
            }
        }

        private void BtnEleven_Click(object sender, EventArgs e)
        {
            uRandom = 11;
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            uRandom = 1;
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MniNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}