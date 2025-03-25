using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_p179
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 800, sheight = 300;
            float curX, curY;
            int num;
            string binary;

            this.Text = "거북이로 2진수 표현하기";
            this.ClientSize = new Size(swidth, sheight);

            num = int.Parse(tb_num.Text.ToString()); // 정수도 받음
            binary = Convert.ToString(num, 2); // 2진수로 변환
            curX = swidth / 2 - 50; // (350) 오른쪽 끝에서 왼쪽으로 50 띄워서 그림
            curY = -50; // 밑으로 50 내려서 그림

            Turtle.Delay = 200;
            for (int i = 0; i < binary.Length; i++)
            {
                Turtle.PenUp();
                Turtle.MoveTo(curX, curY);
                Turtle.PenDown();
                if((num & 1) == 1) // (중요) 비트 연산자
                                   // num과 1의 비트를 비교해서 마지막 자리 수가 같으면 1 같지 않으면 0
                                   // 10 = 1010 != 0001 = 1 -> 0
                                   // 11 = 1011 = 0001 = 1 -> 1 
                {
                    Turtle.PenColor = Color.Blue;
                    Turtle.PenSize = 10;
                    Turtle.Forward(80);
                } else
                {
                    Turtle.PenColor = Color.Red;
                    Turtle.PenSize = 5;
                    Turtle.Forward(40);
                }
                curX -= 50;
                num >>= 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_init_Click(object sender, EventArgs e)
        {

            Turtle.Init();
        }

        private void tb_num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
