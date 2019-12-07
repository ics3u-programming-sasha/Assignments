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
    public partial class Better21Form3 : Form
    {
        public Better21Form3()
        {
            InitializeComponent();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // display the video 
            axWindowsMediaPlayer1.URL = "Instructions.mp4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // display the first form
            Better21Form2 form2 = new Better21Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}