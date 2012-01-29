using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VSintegration
{
    public partial class Form2 : Form
    {
        Graphics g;
        Bitmap bmp;
        Pen p;

        public Form2()
        {
            InitializeComponent();
            p = new Pen(Brushes.Black);
            bmp = new Bitmap(256, 256);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.DrawLine(p, 0, 128, 256, 128);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            p = new Pen(Brushes.Black);
            bmp = new Bitmap(256, 256);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.DrawLine(p, 0, 128, 256, 128);

            g.DrawLine(p, new Point(128,128), e.Location);

            g.DrawString((Math.Atan2(128 - e.Location.Y, e.Location.X - 128) * (180 / 3.14)).ToString(), new Font("Arial", 8), Brushes.Black, 0, 0);
        }


    }
}
