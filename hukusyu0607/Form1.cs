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
        //int vx = rand.Next(-10,11);
        //int vy = rand.Next(-10,11);
        //int vx2 = rand.Next(-10,11);
        //int vy2 = rand.Next(-10,11);
        //int vx3 = rand.Next(-10, 11);
        //int vy3 = rand.Next(-10, 11);

        int time = 500;

        int[] velx = new int[3];
        int[] vely = new int[3];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3;i++ )
            {
                velx[i] = rand.Next(-10, 11);
                vely[i] = rand.Next(-10, 11);
            }

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
            label1.Left += velx[0];
            label1.Top += vely[0];

            if (label1.Left + label1.Width / 2 < 0)
            {
                //Math.Abs(vx = -vx);
                velx[0] = Math.Abs(velx[0]);
                //vx = -vx;
            }
            if (label1.Left + label1.Width / 2 > ClientSize.Width)
            {
                velx[0] = -Math.Abs(velx[0]);
                //Math.Abs (vx = -vx);
                //vx = -vx;
            }
            if (label1.Top + label1.Height / 2 < 0)
            {
                vely[0] = Math.Abs(vely[0]);
                //Math.Abs(vy = -vy);
                //vy = -vy;
            }
            if (label1.Top + label1.Height / 2 > ClientSize.Height)
            {
                vely[0] = -Math.Abs(vely[0]);
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

            if (velx[0] < 0 && vely[0] < 0)
            {
                label1.Text = ("↖");
            }
            if (velx[0] < 0 && vely[0] > 0)
            {
                label1.Text = ("↙");
            }
            if (velx[0] > 0 && vely[0] < 0)
            {
                label1.Text = ("↗");
            }
            if (velx[0] > 0 && vely[0] > 0)
            {
                label1.Text = ("↘");
            }
            if (velx[0] == 0 && vely[0] < 0)
            {
                label1.Text=("↑");
            }
            if (velx[0] == 0 && vely[0] > 0)
            {
                label1.Text=("↓");
            }
            if (velx[0] < 0 && vely[0] == 0)
            {
                label1.Text=("←");
            }
            if (velx[0] > 0 && vely[0] == 0)
            {
                label1.Text=("→");
            }

            //以下 ラベルのあれ　コピペ
            label2.Left += velx[1];
            label2.Top += vely[1];
            if (label2.Left + label2.Width / 2 < 0)
            {
                velx[1] = Math.Abs(velx[1]);
            }
            if (label2.Left + label2.Width / 2 > ClientSize.Width)
            {
                velx[1] = -Math.Abs(velx[1]);
            }
            if (label2.Top + label2.Height / 2 < 0)
            {
                vely[1] = Math.Abs(vely[1]);
            }
            if (label2.Top + label2.Height / 2 > ClientSize.Height)
            {
                vely[1] = -Math.Abs(vely[1]);
            }
            if (velx[1] < 0 && vely[1] < 0)
            {
                label2.Text = ("↖");
            }
            if (velx[1] < 0 && vely[1] > 0)
            {
                label2.Text = ("↙");
            }
            if (velx[1] > 0 && vely[1] < 0)
            {
                label2.Text = ("↗");
            }
            if (velx[1] > 0 && vely[1] > 0)
            {
                label2.Text = ("↘");
            }
            if (velx[1] == 0 && vely[1] < 0)
            {
                label2.Text = ("↑");
            }
            if (velx[1] == 0 && vely[1] > 0)
            {
                label2.Text = ("↓");
            }
            if (velx[1] < 0 && vely[1] == 0)
            {
                label2.Text = ("←");
            }
            if (velx[1] > 0 && vely[1] == 0)
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
            label3.Left += velx[2];
            label3.Top += vely[2];
            if (label3.Left + label3.Width / 2 < 0)
            {
                velx[2] = Math.Abs(velx[2]);
            }
            if (label3.Left + label3.Width / 2 > ClientSize.Width)
            {
                velx[2] = -Math.Abs(velx[2]);
            }
            if (label3.Top + label3.Height / 2 < 0)
            {
                vely[2] = Math.Abs(vely[2]);
            }
            if (label3.Top + label3.Height / 2 > ClientSize.Height)
            {
                vely[2] = -Math.Abs(vely[2]);
            }
            if (velx[2] < 0 && vely[2] < 0)
            {
                label3.Text = ("↖");
            }
            if (velx[2] < 0 && vely[2] > 0)
            {
                label3.Text = ("↙");
            }
            if (velx[2] > 0 && vely[2] < 0)
            {
                label3.Text = ("↗");
            }
            if (velx[2] > 0 && vely[2] > 0)
            {
                label3.Text = ("↘");
            }
            if (velx[2] == 0 && vely[2] < 0)
            {
                label3.Text = ("↑");
            }
            if (velx[2] == 0 && vely[2] > 0)
            {
                label3.Text = ("↓");
            }
            if (velx[2] < 0 && vely[2] == 0)
            {
                label3.Text = ("←");
            }
            if (velx[2] > 0 && vely[2] == 0)
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
