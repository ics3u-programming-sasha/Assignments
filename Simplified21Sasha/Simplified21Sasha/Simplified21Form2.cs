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
        public Simplified21Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Simplified21Form1 f1 = new Simplified21Form1();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
