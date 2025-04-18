using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_0416_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
            }
            else
            {
                if (tb_id.Text == "gyuri" && tb_pass.Text =="123")
                {
                    MessageBox.Show(tb_id.Text + "님 환영합니다. 창을 닫습니다.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("아이디와 비밀번호를 다시 확인하세요.");
                    tb_id.Text = "";
                    tb_pass.Text = "";
                    tb_id.Focus();
                }
            }
        }
    }
}
