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
        // 疑似乱数
        // ランダムのシード(種)を指定して初期化したら、
        // それを使い続ける。
        private static Random rand = new Random();
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);
        int vx2 = rand.Next(-10,11);
        int vy2 = rand.Next(-10,11);
        int vx3 = rand.Next(-10, 11);
        int vy3 = rand.Next(-10, 11);

        int time = 500;

        public Form1()
        {
            InitializeComponent();
            label1.Left = rand.Next(0, ClientSize.Width);
            label1.Top = rand.Next(0, ClientSize.Height);
            label2.Left = rand.Next(0, ClientSize.Width);
            label2.Top = rand.Next(0, ClientSize.Height);
            label3.Left = rand.Next(0, ClientSize.Width);
            label3.Top = rand.Next(0, ClientSize.Height);

            //以下　授業前
            /*
            Random lx = new Random();
            Random ly = new Random();
            label1.Left = lx.Next(0, ClientSize.Width);
            label1.Top = ly.Next(0, ClientSize.Height);

            Random ho = new Random();
            int hou = ho.Next(1, 5);
            switch (hou)
            {
                case 1:
                    vx = -10;
                    vy = -10;
                    break;
                case 2:
                    vx = 10;
                    vy = -10;
                    break;
                case 3:
                    vx = -10;
                    vy = 10;
                    break;
                case 4:
                    vx = 10;
                    vy = 10;
                    break;
            }*/
            //以上　授業前

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left + label1.Width / 2 < 0)
            {
                //Math.Abs(vx = -vx);
                vx = Math.Abs(vx);
                //vx = -vx;
            }
            if (label1.Left + label1.Width / 2 > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
                //Math.Abs (vx = -vx);
                //vx = -vx;
            }
            if (label1.Top + label1.Height / 2 < 0)
            {
                vy = Math.Abs(vy);
                //Math.Abs(vy = -vy);
                //vy = -vy;
            }
            if (label1.Top + label1.Height / 2 > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
                //Math.Abs(vy = -vy);
                //vy = -vy;
            }
            //int mx = MousePosition.X;//Form1の大きさの判定じゃない
            //int my = MousePosition.Y;
            Point p = PointToClient(MousePosition);
            if (label3.Left<p.X&&label3.Right>p.X&&label3.Top<p.Y&&label3.Bottom>p.Y)
            {
                //label3.ForeColor = Color.Yellow;
                //timer1.Enabled = false;
                label3.Visible = false;
            }
            if (label2.Left<p.X&&label2.Right>p.X&&label2.Top<p.Y&&label2.Bottom>p.Y)
            {
                label2.Visible = false;
            }
            if (label1.Left < p.X && label1.Right > p.X && label1.Top < p.Y && label1.Bottom > p.Y)
            {
                label1.Visible = false;
            }
            if (label1.Visible==false&&label2.Visible==false&&label3.Visible==false)
            {
                timer1.Enabled = false;
            }
            
            if (vx < 0 && vy < 0)
            {
                label1.Text = ("↖");
            }
            if (vx < 0 && vy >0)
            {
                label1.Text = ("↙");
            }
            if (vx > 0 && vy < 0)
            {
                label1.Text = ("↗");
            }
            if (vx > 0 && vy > 0)
            {
                label1.Text = ("↘");
            }
            if (vx == 0 && vy < 0)
            {
                label1.Text=("↑");
            }
            if (vx == 0 && vy > 0)
            {
                label1.Text=("↓");
            }
            if (vx < 0 && vy == 0)
            {
                label1.Text=("←");
            }
            if (vx > 0 && vy == 0)
            {
                label1.Text=("→");
            }

            //以下 ラベルのあれ　コピペ
            label2.Left += vx2;
            label2.Top += vy2;
            if (label2.Left + label2.Width / 2 < 0)
            {
                vx2 = Math.Abs(vx2);
            }
            if (label2.Left + label2.Width / 2 > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx2);
            }
            if (label2.Top + label2.Height / 2 < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            if (label2.Top + label2.Height / 2 > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy2);
            }
            if (vx2 < 0 && vy2 < 0)
            {
                label2.Text = ("↖");
            }
            if (vx2 < 0 && vy2 > 0)
            {
                label2.Text = ("↙");
            }
            if (vx2 > 0 && vy2 < 0)
            {
                label2.Text = ("↗");
            }
            if (vx2 > 0 && vy2 > 0)
            {
                label2.Text = ("↘");
            }
            if (vx2 == 0 && vy2 < 0)
            {
                label2.Text = ("↑");
            }
            if (vx2 == 0 && vy2 > 0)
            {
                label2.Text = ("↓");
            }
            if (vx2 < 0 && vy2 == 0)
            {
                label2.Text = ("←");
            }
            if (vx2 > 0 && vy2 == 0)
            {
                label2.Text = ("→");
            }

            //ぶつかったら
            /*
            if (label1.Left<label2.Right&&label1.Top<label2.Bottom&&label1.Right>label2.Left&&label1.Bottom>label2.Top)
            {
                label1.Visible = false;
                label2.Visible = false;
            }*/

            //ラベル3
            label3.Left += vx3;
            label3.Top += vy3;
            if (label3.Left + label3.Width / 2 < 0)
            {
                vx3 = Math.Abs(vx3);
            }
            if (label3.Left + label3.Width / 2 > ClientSize.Width)
            {
                vx3 = -Math.Abs(vx3);
            }
            if (label3.Top + label3.Height / 2 < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            if (label3.Top + label3.Height / 2 > ClientSize.Height)
            {
                vy3 = -Math.Abs(vy3);
            }
            if (vx3 < 0 && vy3 < 0)
            {
                label3.Text = ("↖");
            }
            if (vx3 < 0 && vy3 > 0)
            {
                label3.Text = ("↙");
            }
            if (vx3 > 0 && vy3 < 0)
            {
                label3.Text = ("↗");
            }
            if (vx3 > 0 && vy3 > 0)
            {
                label3.Text = ("↘");
            }
            if (vx3 == 0 && vy3 < 0)
            {
                label3.Text = ("↑");
            }
            if (vx3 == 0 && vy3 > 0)
            {
                label3.Text = ("↓");
            }
            if (vx3 < 0 && vy3 == 0)
            {
                label3.Text = ("←");
            }
            if (vx3 > 0 && vy3 == 0)
            {
                label3.Text = ("→");
            }

            time--;
            counter.Text=("time: "+time);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void counter_Click(object sender, EventArgs e)
        {

        }
    }
}
