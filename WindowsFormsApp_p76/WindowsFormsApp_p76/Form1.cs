using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_p76
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1, x2, y2;
        Pen pen = new Pen(Color.Black, 10);
        int figure;

        private void button1_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 10);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Yellow, 10);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            figure = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            figure = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            figure = 0;
        }

        private void btn_clean_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            Graphics g = CreateGraphics();

            if (figure == 0)
                g.DrawLine(pen, x1, y1, x2, y2);
            else if (figure == 1)
                g.DrawArc(pen, new Rectangle(x1, y1, (x2 - x1), (y2 - y1)), 0, 360);
            else
                g.DrawRectangle(pen, x1, y1,Math.Abs(x2 - x1),Math.Abs(y2 - y1));
        }
    }
}
