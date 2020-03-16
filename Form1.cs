using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bliker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            Random rn = new Random();
            int R, G, B;
            R = rn.Next(0, 255);
            B = rn.Next(0, 255);
            G = rn.Next(0, 255);

            // labelquotes.Text = "red " + R + " green " + G + " blue " + B;
            BackColor = Color.FromArgb(R, G, B);

        }
    }
}

