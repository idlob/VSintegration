using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VSintegration
{
    public partial class Form1 : Form
    {
        private int upDown;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 40;
            upDown = -4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel3.Size.Height > 57 || panel3.Size.Height < 34) upDown *= -1;
            panel3.Size = new Size(panel3.Size.Width, panel3.Size.Height + upDown);
        }
    }
}
