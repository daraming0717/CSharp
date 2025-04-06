using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Nakov.TurtleGraphics;

namespace WindowsFormsApp_0404_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 800, sheight = 800;
            this.Text = "거북이 쇼";
            this.ClientSize = new Size(sheight, swidth);
            Turtle.Delay = 10;

            Random rnd = new Random();
            int turtleNumber = rnd.Next(50, 100);
            int[,] turtleary = new int[turtleNumber, 6];

            for (int i = 0; i < turtleNumber; i++)
            {
                turtleary[i, 0] = rnd.Next(-swidth / 2, swidth / 2);
                turtleary[i, 1] = rnd.Next(-sheight / 2, sheight / 2);
                turtleary[i, 2] = rnd.Next(1, 20);
                turtleary[i, 3] = rnd.Next(0, 256);
                turtleary[i, 4] = rnd.Next(0, 256);
                turtleary[i, 5] = rnd.Next(0, 256);
            }

            for(int i = 0; i < turtleNumber; i++)
            {
                Turtle.PenSize = turtleary[i, 2];
                Turtle.PenColor = Color.FromArgb(turtleary[i, 3], turtleary[i, 4], turtleary[i, 5]);
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.MoveTo(turtleary[i, 0], turtleary[i, 1]);

                int Angle = (int)(Math.Atan2(turtleary[i, 0], turtleary[i, 1]) * 180 / Math.PI);
                Turtle.RotateTo(Angle - 90);
                for(int k = 0; k < 9; k++)
                {
                    Turtle.Forward(turtleary[i, 2]);
                    Turtle.Rotate(40);
                }
            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            
        }
    }
}
