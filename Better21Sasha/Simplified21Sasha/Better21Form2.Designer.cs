namespace Simplified21Sasha
{
    partial class Better21Form2
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblPlay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(316, 193);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(142, 58);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.Brown;
            this.lblPlay.Font = new System.Drawing.Font("Mongolian Baiti", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlay.Location = new System.Drawing.Point(144, 20);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(478, 50);
            this.lblPlay.TabIndex = 3;
            this.lblPlay.Text = "Welcome to Better 21!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(225, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press on play to start.";
            // 
            // picTable
            // 
            this.picTable.Image = global::Simplified21Sasha.Properties.Resources.Start3;
            this.picTable.Location = new System.Drawing.Point(-10, -15);
            this.picTable.Name = "picTable";
            this.picTable.Size = new System.Drawing.Size(826, 475);
            this.picTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTable.TabIndex = 1;
            this.picTable.TabStop = false;
            // 
            // Simplified21Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picTable);
            this.Name = "Simplified21Form2";
            this.Text = "Better 21 by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picTable;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label label1;
    }
}