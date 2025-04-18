namespace WindowsFormsApp_0416_1
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
            this.btn_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_change.Font = new System.Drawing.Font("나눔고딕", 15F);
            this.btn_change.Location = new System.Drawing.Point(37, 90);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(215, 50);
            this.btn_change.TabIndex = 0;
            this.btn_change.Text = "클릭!";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            this.btn_change.MouseEnter += new System.EventHandler(this.btn_change_MouseEnter);
            this.btn_change.MouseLeave += new System.EventHandler(this.btn_change_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_change);
            this.Name = "Form1";
            this.Text = "기본 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_change;
    }
}

