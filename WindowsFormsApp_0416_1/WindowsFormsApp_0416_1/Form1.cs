using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_0416_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_change.BackColor = Color.DeepSkyBlue;
            btn_change.ForeColor = Color.White;
            btn_change.Size = new Size(215, 50);
            btn_change.Location = new Point(50, 50);
            btn_change.Text = "개굴개굴";
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            this.Text = "버튼을 눌렀어요";
            this.BackColor = Color.Black;
            btn_change.Hide();
            MessageBox.Show("버튼이 없어졌어요");
        }

        private void btn_change_MouseEnter(object sender, EventArgs e)
        {
            btn_change.Text = "우와 마우스다";
            btn_change.BackColor = Color.SkyBlue;
        }

        private void btn_change_MouseLeave(object sender, EventArgs e)
        {
            btn_change.Text = "마우스 어디갓지 ㅜ";
            btn_change.BackColor = Color.DarkBlue;
        }
    }
}
