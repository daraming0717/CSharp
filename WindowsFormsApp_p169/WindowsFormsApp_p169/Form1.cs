using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace WindowsFormsApp_p169
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 400, sheight = 400, exitcount = 0; //크기 400X400, 창 밖으로 나간 횟수
            int r, g, b, angle, dist; // 색, 각도, 거리 distance
            float curX, curY; // 좌표 currentX.Y

            this.Text = "거북이가 마음대로 다니기";
            this.ClientSize = new Size(sheight, swidth);

            Random rnd = new Random();
            Turtle.Delay = 200;

            while(true)
            {
                // 펜 색부터 red, green, blue
                r = rnd.Next(0, 256);
                g = rnd.Next(0, 256);
                b = rnd.Next(0, 256);
                Turtle.PenColor = Color.FromArgb(r, g, b);

                angle = rnd.Next(0, 360); //각도
                dist = rnd.Next(30, 100); //길이
                Turtle.Rotate(angle); //방향 전환
                Turtle.Forward(dist); //저벅저벅
                //좌표
                curX = Turtle.X;
                curY = Turtle.Y;

                //창 내에 있을 때
                if ((-swidth / 2 <= curX && curX <= swidth / 2) && (-sheight / 2 <= curY && curY <= sheight / 2))
                {
                }
                else { //창 밖으로 나갔을 때
                    Turtle.PenUp();
                    Turtle.MoveTo(0, 0);
                    Turtle.PenDown();

                    exitcount ++;
                    if (exitcount == 5)
                        break;
                }

            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }
    }
}
