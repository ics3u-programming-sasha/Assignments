namespace PizzaOrderSasha
{
    partial class frmPizzaOrder
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
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.lblSoftDrink = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblSelections = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubD = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picExtraLarge = new System.Windows.Forms.PictureBox();
            this.picLarge = new System.Windows.Forms.PictureBox();
            this.picMedium = new System.Windows.Forms.PictureBox();
            this.picCanada = new System.Windows.Forms.PictureBox();
            this.picSoftDrink = new System.Windows.Forms.PictureBox();
            this.picToppings = new System.Windows.Forms.PictureBox();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSelectSize = new System.Windows.Forms.Label();
            this.lblSelectDrink = new System.Windows.Forms.Label();
            this.nudSoftDrink = new System.Windows.Forms.NumericUpDown();
            this.lblAlberta = new System.Windows.Forms.Label();
            this.lblSaskatchewan = new System.Windows.Forms.Label();
            this.lblBritishColumbia = new System.Windows.Forms.Label();
            this.lblOntario = new System.Windows.Forms.Label();
            this.lblQuebec = new System.Windows.Forms.Label();
            this.nudProvince = new System.Windows.Forms.NumericUpDown();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblSelectDelivery = new System.Windows.Forms.Label();
            this.nudDelivery = new System.Windows.Forms.NumericUpDown();
            this.lblTip = new System.Windows.Forms.Label();
            this.nudTip = new System.Windows.Forms.NumericUpDown();
            this.lblNovaScotia = new System.Windows.Forms.Label();
            this.lblFinalSize = new System.Windows.Forms.Label();
            this.lblFinalToppings = new System.Windows.Forms.Label();
            this.lblFinalDrink = new System.Windows.Forms.Label();
            this.lblFinalProvince1 = new System.Windows.Forms.Label();
            this.lblFinalDelivery = new System.Windows.Forms.Label();
            this.lblFinalTip = new System.Windows.Forms.Label();
            this.lblFinalDiscount = new System.Windows.Forms.Label();
            this.lblFinalProvince2 = new System.Windows.Forms.Label();
            this.lblFinalProvince3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtraLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoftDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoftDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(22, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(390, 26);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "What size of pizza would you like to order?";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(13, 276);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(329, 26);
            this.lblToppings.TabIndex = 5;
            this.lblToppings.Text = "How many toppings would you like?";
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(27, 345);
            this.nudToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 20);
            this.nudToppings.TabIndex = 6;
            this.nudToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoftDrink
            // 
            this.lblSoftDrink.AutoSize = true;
            this.lblSoftDrink.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftDrink.Location = new System.Drawing.Point(12, 423);
            this.lblSoftDrink.Name = "lblSoftDrink";
            this.lblSoftDrink.Size = new System.Drawing.Size(259, 26);
            this.lblSoftDrink.TabIndex = 8;
            this.lblSoftDrink.Text = "Would you like a soft drink?";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(573, 9);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(390, 24);
            this.lblProvince.TabIndex = 16;
            this.lblProvince.Text = "Please select what province you are located in:";
            // 
            // lblSelections
            // 
            this.lblSelections.AutoSize = true;
            this.lblSelections.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelections.Location = new System.Drawing.Point(351, 314);
            this.lblSelections.Name = "lblSelections";
            this.lblSelections.Size = new System.Drawing.Size(153, 26);
            this.lblSelections.TabIndex = 22;
            this.lblSelections.Text = "Your selections:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(640, 343);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 26);
            this.lblSubtotal.TabIndex = 24;
            // 
            // lblSubD
            // 
            this.lblSubD.AutoSize = true;
            this.lblSubD.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubD.Location = new System.Drawing.Point(640, 396);
            this.lblSubD.Name = "lblSubD";
            this.lblSubD.Size = new System.Drawing.Size(0, 26);
            this.lblSubD.TabIndex = 25;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(640, 447);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(0, 26);
            this.lblTax.TabIndex = 26;
            // 
            // lblSubT
            // 
            this.lblSubT.AutoSize = true;
            this.lblSubT.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubT.Location = new System.Drawing.Point(643, 501);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(0, 26);
            this.lblSubT.TabIndex = 27;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(643, 555);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 26);
            this.lblTotal.TabIndex = 28;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(405, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 40);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // picExtraLarge
            // 
            this.picExtraLarge.Image = global::PizzaOrderSasha.Properties.Resources.Extra_Large2;
            this.picExtraLarge.Location = new System.Drawing.Point(254, 32);
            this.picExtraLarge.Name = "picExtraLarge";
            this.picExtraLarge.Size = new System.Drawing.Size(126, 162);
            this.picExtraLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExtraLarge.TabIndex = 32;
            this.picExtraLarge.TabStop = false;
            // 
            // picLarge
            // 
            this.picLarge.Image = global::PizzaOrderSasha.Properties.Resources.Large2;
            this.picLarge.Location = new System.Drawing.Point(140, 47);
            this.picLarge.Name = "picLarge";
            this.picLarge.Size = new System.Drawing.Size(108, 147);
            this.picLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLarge.TabIndex = 31;
            this.picLarge.TabStop = false;
            // 
            // picMedium
            // 
            this.picMedium.Image = global::PizzaOrderSasha.Properties.Resources.Medium2;
            this.picMedium.Location = new System.Drawing.Point(31, 70);
            this.picMedium.Name = "picMedium";
            this.picMedium.Size = new System.Drawing.Size(103, 124);
            this.picMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMedium.TabIndex = 30;
            this.picMedium.TabStop = false;
            // 
            // picCanada
            // 
            this.picCanada.Image = global::PizzaOrderSasha.Properties.Resources.Canada;
            this.picCanada.Location = new System.Drawing.Point(646, 55);
            this.picCanada.Name = "picCanada";
            this.picCanada.Size = new System.Drawing.Size(308, 215);
            this.picCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanada.TabIndex = 15;
            this.picCanada.TabStop = false;
            // 
            // picSoftDrink
            // 
            this.picSoftDrink.Image = global::PizzaOrderSasha.Properties.Resources.Soft_Drink1;
            this.picSoftDrink.Location = new System.Drawing.Point(12, 452);
            this.picSoftDrink.Name = "picSoftDrink";
            this.picSoftDrink.Size = new System.Drawing.Size(139, 134);
            this.picSoftDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSoftDrink.TabIndex = 9;
            this.picSoftDrink.TabStop = false;
            // 
            // picToppings
            // 
            this.picToppings.Image = global::PizzaOrderSasha.Properties.Resources.Toppings1;
            this.picToppings.Location = new System.Drawing.Point(172, 314);
            this.picToppings.Name = "picToppings";
            this.picToppings.Size = new System.Drawing.Size(133, 106);
            this.picToppings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picToppings.TabIndex = 7;
            this.picToppings.TabStop = false;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(128, 244);
            this.nudSize.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 20);
            this.nudSize.TabIndex = 33;
            this.nudSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSelectSize
            // 
            this.lblSelectSize.AutoSize = true;
            this.lblSelectSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSize.Location = new System.Drawing.Point(60, 212);
            this.lblSelectSize.Name = "lblSelectSize";
            this.lblSelectSize.Size = new System.Drawing.Size(282, 20);
            this.lblSelectSize.TabIndex = 34;
            this.lblSelectSize.Text = "Medium = 1, Large = 2, Extra Large = 3";
            // 
            // lblSelectDrink
            // 
            this.lblSelectDrink.AutoSize = true;
            this.lblSelectDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDrink.Location = new System.Drawing.Point(168, 487);
            this.lblSelectDrink.Name = "lblSelectDrink";
            this.lblSelectDrink.Size = new System.Drawing.Size(117, 20);
            this.lblSelectDrink.TabIndex = 35;
            this.lblSelectDrink.Text = "Yes = 1, No = 2";
            // 
            // nudSoftDrink
            // 
            this.nudSoftDrink.Location = new System.Drawing.Point(165, 525);
            this.nudSoftDrink.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSoftDrink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoftDrink.Name = "nudSoftDrink";
            this.nudSoftDrink.Size = new System.Drawing.Size(120, 20);
            this.nudSoftDrink.TabIndex = 36;
            this.nudSoftDrink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAlberta
            // 
            this.lblAlberta.AutoSize = true;
            this.lblAlberta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlberta.Location = new System.Drawing.Point(573, 55);
            this.lblAlberta.Name = "lblAlberta";
            this.lblAlberta.Size = new System.Drawing.Size(361, 20);
            this.lblAlberta.TabIndex = 37;
            this.lblAlberta.Text = "1 = Alberta, Northwest Territories, Yukon, Nunavut";
            // 
            // lblSaskatchewan
            // 
            this.lblSaskatchewan.AutoSize = true;
            this.lblSaskatchewan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaskatchewan.Location = new System.Drawing.Point(575, 94);
            this.lblSaskatchewan.Name = "lblSaskatchewan";
            this.lblSaskatchewan.Size = new System.Drawing.Size(140, 20);
            this.lblSaskatchewan.TabIndex = 38;
            this.lblSaskatchewan.Text = "2 = Saskatchewan";
            // 
            // lblBritishColumbia
            // 
            this.lblBritishColumbia.AutoSize = true;
            this.lblBritishColumbia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBritishColumbia.Location = new System.Drawing.Point(575, 137);
            this.lblBritishColumbia.Name = "lblBritishColumbia";
            this.lblBritishColumbia.Size = new System.Drawing.Size(149, 20);
            this.lblBritishColumbia.TabIndex = 39;
            this.lblBritishColumbia.Text = "3 = British Columbia";
            // 
            // lblOntario
            // 
            this.lblOntario.AutoSize = true;
            this.lblOntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOntario.Location = new System.Drawing.Point(575, 184);
            this.lblOntario.Name = "lblOntario";
            this.lblOntario.Size = new System.Drawing.Size(161, 20);
            this.lblOntario.TabIndex = 40;
            this.lblOntario.Text = "4 = Ontario, Manitoba";
            // 
            // lblQuebec
            // 
            this.lblQuebec.AutoSize = true;
            this.lblQuebec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuebec.Location = new System.Drawing.Point(575, 230);
            this.lblQuebec.Name = "lblQuebec";
            this.lblQuebec.Size = new System.Drawing.Size(367, 20);
            this.lblQuebec.TabIndex = 41;
            this.lblQuebec.Text = "5 = Quebec, New Brunswick, Prince Edward Island,";
            // 
            // nudProvince
            // 
            this.nudProvince.Location = new System.Drawing.Point(804, 137);
            this.nudProvince.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudProvince.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProvince.Name = "nudProvince";
            this.nudProvince.Size = new System.Drawing.Size(120, 20);
            this.nudProvince.TabIndex = 42;
            this.nudProvince.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(441, 9);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(94, 26);
            this.lblDelivery.TabIndex = 43;
            this.lblDelivery.Text = "Delivery?";
            // 
            // lblSelectDelivery
            // 
            this.lblSelectDelivery.AutoSize = true;
            this.lblSelectDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDelivery.Location = new System.Drawing.Point(429, 47);
            this.lblSelectDelivery.Name = "lblSelectDelivery";
            this.lblSelectDelivery.Size = new System.Drawing.Size(117, 20);
            this.lblSelectDelivery.TabIndex = 44;
            this.lblSelectDelivery.Text = "Yes = 1, No = 2";
            // 
            // nudDelivery
            // 
            this.nudDelivery.Location = new System.Drawing.Point(426, 83);
            this.nudDelivery.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDelivery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelivery.Name = "nudDelivery";
            this.nudDelivery.Size = new System.Drawing.Size(120, 20);
            this.nudDelivery.TabIndex = 45;
            this.nudDelivery.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(441, 130);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(78, 26);
            this.lblTip.TabIndex = 46;
            this.lblTip.Text = "Tip? ($)";
            // 
            // nudTip
            // 
            this.nudTip.Location = new System.Drawing.Point(426, 174);
            this.nudTip.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTip.Name = "nudTip";
            this.nudTip.Size = new System.Drawing.Size(120, 20);
            this.nudTip.TabIndex = 47;
            this.nudTip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNovaScotia
            // 
            this.lblNovaScotia.AutoSize = true;
            this.lblNovaScotia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaScotia.Location = new System.Drawing.Point(601, 250);
            this.lblNovaScotia.Name = "lblNovaScotia";
            this.lblNovaScotia.Size = new System.Drawing.Size(303, 20);
            this.lblNovaScotia.TabIndex = 48;
            this.lblNovaScotia.Text = "Nova Scotia, Newfoundland and Labrador";
            // 
            // lblFinalSize
            // 
            this.lblFinalSize.AutoSize = true;
            this.lblFinalSize.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalSize.Location = new System.Drawing.Point(352, 340);
            this.lblFinalSize.Name = "lblFinalSize";
            this.lblFinalSize.Size = new System.Drawing.Size(0, 21);
            this.lblFinalSize.TabIndex = 49;
            // 
            // lblFinalToppings
            // 
            this.lblFinalToppings.AutoSize = true;
            this.lblFinalToppings.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalToppings.Location = new System.Drawing.Point(352, 372);
            this.lblFinalToppings.Name = "lblFinalToppings";
            this.lblFinalToppings.Size = new System.Drawing.Size(0, 21);
            this.lblFinalToppings.TabIndex = 50;
            // 
            // lblFinalDrink
            // 
            this.lblFinalDrink.AutoSize = true;
            this.lblFinalDrink.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDrink.Location = new System.Drawing.Point(352, 407);
            this.lblFinalDrink.Name = "lblFinalDrink";
            this.lblFinalDrink.Size = new System.Drawing.Size(0, 21);
            this.lblFinalDrink.TabIndex = 51;
            // 
            // lblFinalProvince1
            // 
            this.lblFinalProvince1.AutoSize = true;
            this.lblFinalProvince1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalProvince1.Location = new System.Drawing.Point(352, 439);
            this.lblFinalProvince1.Name = "lblFinalProvince1";
            this.lblFinalProvince1.Size = new System.Drawing.Size(0, 21);
            this.lblFinalProvince1.TabIndex = 52;
            // 
            // lblFinalDelivery
            // 
            this.lblFinalDelivery.AutoSize = true;
            this.lblFinalDelivery.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDelivery.Location = new System.Drawing.Point(352, 505);
            this.lblFinalDelivery.Name = "lblFinalDelivery";
            this.lblFinalDelivery.Size = new System.Drawing.Size(0, 21);
            this.lblFinalDelivery.TabIndex = 53;
            // 
            // lblFinalTip
            // 
            this.lblFinalTip.AutoSize = true;
            this.lblFinalTip.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTip.Location = new System.Drawing.Point(352, 535);
            this.lblFinalTip.Name = "lblFinalTip";
            this.lblFinalTip.Size = new System.Drawing.Size(0, 21);
            this.lblFinalTip.TabIndex = 54;
            // 
            // lblFinalDiscount
            // 
            this.lblFinalDiscount.AutoSize = true;
            this.lblFinalDiscount.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDiscount.Location = new System.Drawing.Point(351, 568);
            this.lblFinalDiscount.Name = "lblFinalDiscount";
            this.lblFinalDiscount.Size = new System.Drawing.Size(0, 21);
            this.lblFinalDiscount.TabIndex = 55;
            // 
            // lblFinalProvince2
            // 
            this.lblFinalProvince2.AutoSize = true;
            this.lblFinalProvince2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalProvince2.Location = new System.Drawing.Point(352, 460);
            this.lblFinalProvince2.Name = "lblFinalProvince2";
            this.lblFinalProvince2.Size = new System.Drawing.Size(0, 21);
            this.lblFinalProvince2.TabIndex = 56;
            // 
            // lblFinalProvince3
            // 
            this.lblFinalProvince3.AutoSize = true;
            this.lblFinalProvince3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalProvince3.Location = new System.Drawing.Point(352, 480);
            this.lblFinalProvince3.Name = "lblFinalProvince3";
            this.lblFinalProvince3.Size = new System.Drawing.Size(0, 21);
            this.lblFinalProvince3.TabIndex = 57;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 598);
            this.Controls.Add(this.lblFinalProvince3);
            this.Controls.Add(this.lblFinalProvince2);
            this.Controls.Add(this.lblFinalDiscount);
            this.Controls.Add(this.lblFinalTip);
            this.Controls.Add(this.lblFinalDelivery);
            this.Controls.Add(this.lblFinalProvince1);
            this.Controls.Add(this.lblFinalDrink);
            this.Controls.Add(this.lblFinalToppings);
            this.Controls.Add(this.lblFinalSize);
            this.Controls.Add(this.lblNovaScotia);
            this.Controls.Add(this.nudTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.nudDelivery);
            this.Controls.Add(this.lblSelectDelivery);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.nudProvince);
            this.Controls.Add(this.lblQuebec);
            this.Controls.Add(this.lblOntario);
            this.Controls.Add(this.lblBritishColumbia);
            this.Controls.Add(this.lblSaskatchewan);
            this.Controls.Add(this.lblAlberta);
            this.Controls.Add(this.nudSoftDrink);
            this.Controls.Add(this.lblSelectDrink);
            this.Controls.Add(this.lblSelectSize);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.picExtraLarge);
            this.Controls.Add(this.picLarge);
            this.Controls.Add(this.picMedium);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubT);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubD);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSelections);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.picCanada);
            this.Controls.Add(this.lblSoftDrink);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.picSoftDrink);
            this.Controls.Add(this.picToppings);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtraLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoftDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoftDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.PictureBox picToppings;
        private System.Windows.Forms.Label lblSoftDrink;
        private System.Windows.Forms.PictureBox picSoftDrink;
        private System.Windows.Forms.PictureBox picCanada;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblSelections;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubD;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picMedium;
        private System.Windows.Forms.PictureBox picLarge;
        private System.Windows.Forms.PictureBox picExtraLarge;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblSelectSize;
        private System.Windows.Forms.Label lblSelectDrink;
        private System.Windows.Forms.NumericUpDown nudSoftDrink;
        private System.Windows.Forms.Label lblAlberta;
        private System.Windows.Forms.Label lblSaskatchewan;
        private System.Windows.Forms.Label lblBritishColumbia;
        private System.Windows.Forms.Label lblOntario;
        private System.Windows.Forms.Label lblQuebec;
        private System.Windows.Forms.NumericUpDown nudProvince;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblSelectDelivery;
        private System.Windows.Forms.NumericUpDown nudDelivery;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.NumericUpDown nudTip;
        private System.Windows.Forms.Label lblNovaScotia;
        private System.Windows.Forms.Label lblFinalSize;
        private System.Windows.Forms.Label lblFinalToppings;
        private System.Windows.Forms.Label lblFinalDrink;
        private System.Windows.Forms.Label lblFinalProvince1;
        private System.Windows.Forms.Label lblFinalDelivery;
        private System.Windows.Forms.Label lblFinalTip;
        private System.Windows.Forms.Label lblFinalDiscount;
        private System.Windows.Forms.Label lblFinalProvince2;
        private System.Windows.Forms.Label lblFinalProvince3;
    }
}

