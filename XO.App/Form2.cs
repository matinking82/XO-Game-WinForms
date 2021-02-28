using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO.App
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtXPlayer.Text != "")
            {
                Form1.XName = txtXPlayer.Text;
            }
            else
            {
                Form1.XName = "X";
            }

            if (txtOPlayer.Text != "")
            {
                Form1.OName = txtOPlayer.Text;
            }
            else
            {
                Form1.OName = "O";
            }

            DialogResult = DialogResult.OK;
        }

        private void btnPlayWithComputer_Click(object sender, EventArgs e)
        {
            Form1.XName = "Player";
            Form1.OName = "Computer";
            DialogResult = DialogResult.OK;
        }
    }
}
