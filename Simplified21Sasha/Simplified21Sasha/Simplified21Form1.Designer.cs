namespace Simplified21Sasha
{
    partial class Simplified21Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBet = new System.Windows.Forms.Label();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.picTable = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCCard = new System.Windows.Forms.PictureBox();
            this.picCCard2 = new System.Windows.Forms.PictureBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHitOrStay = new System.Windows.Forms.Label();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.picCCard3 = new System.Windows.Forms.PictureBox();
            this.picCCard4 = new System.Windows.Forms.PictureBox();
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblUTotal = new System.Windows.Forms.Label();
            this.lblCTotal = new System.Windows.Forms.Label();
            this.btnHit2 = new System.Windows.Forms.Button();
            this.btnStay2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard4)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(322, 216);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(156, 62);
            this.btnDeal.TabIndex = 1;
            this.btnDeal.Text = "Deal cards";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(330, 296);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(144, 50);
            this.btnBet.TabIndex = 3;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.BtnBet_Click);
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.DarkGreen;
            this.lblBet.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.Khaki;
            this.lblBet.Location = new System.Drawing.Point(239, 182);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(331, 37);
            this.lblBet.TabIndex = 4;
            this.lblBet.Text = "Enter a bet from $2 to $500.";
            // 
            // nudBet
            // 
            this.nudBet.Location = new System.Drawing.Point(346, 258);
            this.nudBet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudBet.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(120, 20);
            this.nudBet.TabIndex = 5;
            this.nudBet.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // picCard
            // 
            this.picCard.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCard.Location = new System.Drawing.Point(12, 284);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(111, 154);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard.TabIndex = 2;
            this.picCard.TabStop = false;
            // 
            // picTable
            // 
            this.picTable.Image = global::Simplified21Sasha.Properties.Resources.Table1;
            this.picTable.Location = new System.Drawing.Point(-73, -53);
            this.picTable.Name = "picTable";
            this.picTable.Size = new System.Drawing.Size(872, 645);
            this.picTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTable.TabIndex = 0;
            this.picTable.TabStop = false;
            // 
            // picCard2
            // 
            this.picCard2.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCard2.Location = new System.Drawing.Point(129, 284);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(111, 154);
            this.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard2.TabIndex = 6;
            this.picCard2.TabStop = false;
            // 
            // picCCard
            // 
            this.picCCard.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCCard.Location = new System.Drawing.Point(12, 64);
            this.picCCard.Name = "picCCard";
            this.picCCard.Size = new System.Drawing.Size(111, 154);
            this.picCCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCCard.TabIndex = 7;
            this.picCCard.TabStop = false;
            // 
            // picCCard2
            // 
            this.picCCard2.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCCard2.Location = new System.Drawing.Point(129, 65);
            this.picCCard2.Name = "picCCard2";
            this.picCCard2.Size = new System.Drawing.Size(111, 154);
            this.picCCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCCard2.TabIndex = 8;
            this.picCCard2.TabStop = false;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.BackColor = System.Drawing.Color.DarkGreen;
            this.lblDealer.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.ForeColor = System.Drawing.Color.Khaki;
            this.lblDealer.Location = new System.Drawing.Point(5, 24);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(170, 37);
            this.lblDealer.TabIndex = 9;
            this.lblDealer.Text = "Dealer\'s cards:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.DarkGreen;
            this.lblUser.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Khaki;
            this.lblUser.Location = new System.Drawing.Point(12, 234);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(138, 37);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Your cards:";
            // 
            // lblHitOrStay
            // 
            this.lblHitOrStay.AutoSize = true;
            this.lblHitOrStay.BackColor = System.Drawing.Color.DarkGreen;
            this.lblHitOrStay.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitOrStay.ForeColor = System.Drawing.Color.Khaki;
            this.lblHitOrStay.Location = new System.Drawing.Point(156, 234);
            this.lblHitOrStay.Name = "lblHitOrStay";
            this.lblHitOrStay.Size = new System.Drawing.Size(331, 37);
            this.lblHitOrStay.TabIndex = 18;
            this.lblHitOrStay.Text = "Would you like to hit or stay?";
            // 
            // picCard3
            // 
            this.picCard3.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCard3.Location = new System.Drawing.Point(246, 284);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(111, 154);
            this.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard3.TabIndex = 19;
            this.picCard3.TabStop = false;
            // 
            // picCard4
            // 
            this.picCard4.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCard4.Location = new System.Drawing.Point(363, 284);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(111, 154);
            this.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard4.TabIndex = 31;
            this.picCard4.TabStop = false;
            // 
            // picCCard3
            // 
            this.picCCard3.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCCard3.Location = new System.Drawing.Point(246, 65);
            this.picCCard3.Name = "picCCard3";
            this.picCCard3.Size = new System.Drawing.Size(111, 154);
            this.picCCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCCard3.TabIndex = 41;
            this.picCCard3.TabStop = false;
            // 
            // picCCard4
            // 
            this.picCCard4.Image = global::Simplified21Sasha.Properties.Resources.Two1;
            this.picCCard4.Location = new System.Drawing.Point(363, 65);
            this.picCCard4.Name = "picCCard4";
            this.picCCard4.Size = new System.Drawing.Size(111, 154);
            this.picCCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCCard4.TabIndex = 42;
            this.picCCard4.TabStop = false;
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(799, 24);
            this.mnuOptions.TabIndex = 48;
            this.mnuOptions.Text = "menuStrip1";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(77, 20);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.MniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(38, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(607, 318);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(98, 42);
            this.btnHit.TabIndex = 49;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(607, 378);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(98, 42);
            this.btnStay.TabIndex = 50;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.BtnStay_Click);
            // 
            // lblUTotal
            // 
            this.lblUTotal.AutoSize = true;
            this.lblUTotal.BackColor = System.Drawing.Color.DarkGreen;
            this.lblUTotal.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUTotal.ForeColor = System.Drawing.Color.Khaki;
            this.lblUTotal.Location = new System.Drawing.Point(554, 47);
            this.lblUTotal.Name = "lblUTotal";
            this.lblUTotal.Size = new System.Drawing.Size(98, 28);
            this.lblUTotal.TabIndex = 51;
            this.lblUTotal.Text = "Your total:";
            // 
            // lblCTotal
            // 
            this.lblCTotal.AutoSize = true;
            this.lblCTotal.BackColor = System.Drawing.Color.DarkGreen;
            this.lblCTotal.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCTotal.ForeColor = System.Drawing.Color.Khaki;
            this.lblCTotal.Location = new System.Drawing.Point(552, 89);
            this.lblCTotal.Name = "lblCTotal";
            this.lblCTotal.Size = new System.Drawing.Size(122, 28);
            this.lblCTotal.TabIndex = 52;
            this.lblCTotal.Text = "Dealer\'s total:";
            // 
            // btnHit2
            // 
            this.btnHit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit2.Location = new System.Drawing.Point(607, 318);
            this.btnHit2.Name = "btnHit2";
            this.btnHit2.Size = new System.Drawing.Size(98, 42);
            this.btnHit2.TabIndex = 53;
            this.btnHit2.Text = "Hit";
            this.btnHit2.UseVisualStyleBackColor = true;
            this.btnHit2.Click += new System.EventHandler(this.BtnHit2_Click);
            // 
            // btnStay2
            // 
            this.btnStay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay2.Location = new System.Drawing.Point(607, 378);
            this.btnStay2.Name = "btnStay2";
            this.btnStay2.Size = new System.Drawing.Size(98, 42);
            this.btnStay2.TabIndex = 54;
            this.btnStay2.Text = "Stay";
            this.btnStay2.UseVisualStyleBackColor = true;
            this.btnStay2.Click += new System.EventHandler(this.BtnStay2_Click);
            // 
            // Simplified21Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.btnStay2);
            this.Controls.Add(this.btnHit2);
            this.Controls.Add(this.lblCTotal);
            this.Controls.Add(this.lblUTotal);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picCCard4);
            this.Controls.Add(this.picCCard3);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.lblHitOrStay);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.picCCard2);
            this.Controls.Add(this.picCCard);
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.nudBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.mnuOptions);
            this.Controls.Add(this.picTable);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "Simplified21Form1";
            this.Text = "Simplified 21 by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCCard4)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTable;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.NumericUpDown nudBet;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.PictureBox picCCard;
        private System.Windows.Forms.PictureBox picCCard2;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHitOrStay;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard4;
        private System.Windows.Forms.PictureBox picCCard3;
        private System.Windows.Forms.PictureBox picCCard4;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblUTotal;
        private System.Windows.Forms.Label lblCTotal;
        private System.Windows.Forms.Button btnHit2;
        private System.Windows.Forms.Button btnStay2;
    }
}

