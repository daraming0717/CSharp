﻿namespace WindowsFormsApp_p179
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_draw = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(12, 49);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(93, 37);
            this.btn_draw.TabIndex = 0;
            this.btn_draw.Text = "그리기";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(12, 95);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(93, 37);
            this.btn_init.TabIndex = 1;
            this.btn_init.Text = "초기화";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(12, 11);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(93, 25);
            this.tb_num.TabIndex = 2;
            this.tb_num.TextChanged += new System.EventHandler(this.tb_num_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.btn_draw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.TextBox tb_num;
    }
}

