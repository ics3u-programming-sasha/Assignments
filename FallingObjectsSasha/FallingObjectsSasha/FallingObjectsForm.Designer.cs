namespace FallingObjectsSasha
{
    partial class frmFallingObjects
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
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblObjectHeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picGravity = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGravity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEnterTime.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTime.ForeColor = System.Drawing.Color.Black;
            this.lblEnterTime.Location = new System.Drawing.Point(63, 91);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(502, 25);
            this.lblEnterTime.TabIndex = 0;
            this.lblEnterTime.Text = "Enter the time (in seconds) since you released the object:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(596, 95);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(90, 20);
            this.txtTime.TabIndex = 1;
            // 
            // lblObjectHeight
            // 
            this.lblObjectHeight.AutoSize = true;
            this.lblObjectHeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblObjectHeight.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectHeight.Location = new System.Drawing.Point(109, 288);
            this.lblObjectHeight.Name = "lblObjectHeight";
            this.lblObjectHeight.Size = new System.Drawing.Size(404, 25);
            this.lblObjectHeight.TabIndex = 2;
            this.lblObjectHeight.Text = "The height of the object above the ground is:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.Black;
            this.lblHeight.Location = new System.Drawing.Point(560, 288);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(39, 25);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "???";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Black;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(308, 181);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 37);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // picGravity
            // 
            this.picGravity.Image = global::FallingObjectsSasha.Properties.Resources.Gravity;
            this.picGravity.Location = new System.Drawing.Point(0, 0);
            this.picGravity.Name = "picGravity";
            this.picGravity.Size = new System.Drawing.Size(816, 464);
            this.picGravity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGravity.TabIndex = 5;
            this.picGravity.TabStop = false;
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblObjectHeight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblEnterTime);
            this.Controls.Add(this.picGravity);
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picGravity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblObjectHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picGravity;
    }
}

