using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hukusyu0607
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Random lx = new Random();
            //Random ly = new Random();
            //label1.Left = lx(0, ClientSize.Width);
            //label1.Left = ly(0, ClientSize.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left + label1.Width / 2 < 0)
            {
                Math.Abs(vx = -vx);
                //vx = -vx;
            }
            if (label1.Left + label1.Width / 2 > ClientSize.Width)
            {
                Math.Abs (vx = -vx);
                //vx = -vx;
            }
            if (label1.Top + label1.Height / 2 < 0)
            {
                Math.Abs(vy = -vy);
                //vy = -vy;
            }
            if (label1.Top + label1.Height / 2 > ClientSize.Height)
            {
                Math.Abs(vy = -vy);
                //vy = -vy;
            }
            int mx = MousePosition.X;//Form1の大きさの判定じゃない
            int my = MousePosition.Y;
            if (label1.Left<mx&&label1.Right>mx&&label1.Top<my&&label1.Bottom>my)
            {
                timer1.Enabled = false;
            }
            if (vx==-10&&vy==-10)
            {
                label1.Text = ("↖");
            }
            if (vx == -10 && vy == 10)
            {
                label1.Text = ("↙");
            }
            if (vx == 10 && vy == -10)
            {
                label1.Text = ("↗");
            }
            if (vx == 10 && vy == 10)
            {
                label1.Text = ("↘");
            }
        }
    }
}
