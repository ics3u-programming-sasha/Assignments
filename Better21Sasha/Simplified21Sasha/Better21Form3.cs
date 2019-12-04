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
            axWindowsMediaPlayer1.URL = "Instructions.mp4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Better21Form2 form2 = new Better21Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
