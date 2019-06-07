using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0607
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random();//←疑似乱数
                                                  //ランダムのシード(種)を指定して初期化したら
                                                  //それを使い続ける
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10, 11);

        int ux = rand.Next(-10, 11);
        int uy = rand.Next(-10, 11);

        int wx = rand.Next(-10, 11);
        int wy = rand.Next(-10, 11);

        public Form1()
        {
            InitializeComponent();
            
            //以下に、label1.Leftとlabel1.Topの座標をランダムで求めよ
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;


            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Left > ClientSize.Width - label1.Width) 
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top > ClientSize.Height - label1.Height)  
            {
                vy = -Math.Abs(vy);
            }

            label2.Left += ux;
            label2.Top += uy;
            if (label2.Left < 0)
            {
                ux = Math.Abs(ux);
            }
            if (label2.Top < 0)
            {
                uy = Math.Abs(uy);
            }
            if (label2.Left > ClientSize.Width - label2.Width)
            {
                ux = -Math.Abs(ux);
            }
            if (label2.Top > ClientSize.Height - label2.Height)
            {
                uy = -Math.Abs(uy);
            }

            label3.Left += wx;
            label3.Top += wy;
            if (label3.Left < 0)
            {
                wx = Math.Abs(wx);
            }
            if (label3.Top < 0)
            {
                wy = Math.Abs(wy);
            }
            if (label3.Left > ClientSize.Width - label3.Width)
            {
                wx = -Math.Abs(wx);
            }
            if (label3.Top > ClientSize.Height - label3.Height)
            {
                wy = -Math.Abs(wy);
            }
            //マウスと重なった時、タイマーを止める
            Point p = PointToClient(MousePosition);
            if  (  (p.X>=label1.Left)
                && (p.X<label1.Right)
                && (p.Y>=label1.Top)
                && (p.Y<label1.Bottom)
                )
            {
                timer1.Enabled=false;
            }

            Point q = PointToClient(MousePosition);
            if  (  (q.X >= label2.Left)
                && (q.X < label2.Right)
                && (q.Y >= label2.Top)
                && (q.Y < label2.Bottom)
                )
            {
                timer1.Enabled = false;
            }

            Point r = PointToClient(MousePosition);
            if  (  (r.X >= label3.Left)
                && (r.X < label3.Right)
                && (r.Y >= label3.Top)
                && (r.Y < label3.Bottom)
                )
            {
                timer1.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
