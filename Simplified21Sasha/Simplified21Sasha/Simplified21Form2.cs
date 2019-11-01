﻿/*
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
    public partial class Simplified21Form2 : Form
    {
        // declare variable
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        

        public Simplified21Form2()
        {
            InitializeComponent();

            // play music
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