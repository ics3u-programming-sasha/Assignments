﻿using System;
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
    public partial class Simplified21Form2 : Form
    {
        // play music
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        

        public Simplified21Form2()
        {
            InitializeComponent();
            player.URL = "Music.mp3";
            player.controls.play();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // display the second form
            Simplified21Form1 form1 = new Simplified21Form1(ref player);
            this.Hide();
            form1.ShowDialog();
        }
    }
}
