using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace WindowsFormsApp_p162
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;

            Turtle.Forward(100);
            Turtle.Rotate(135);
            Turtle.Forward(100);
            Turtle.Rotate(135);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }
    }
}
