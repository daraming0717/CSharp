namespace WindowsFormsApp_p76
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
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_Black = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Yellow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Line = new System.Windows.Forms.RadioButton();
            this.btn_Circle = new System.Windows.Forms.RadioButton();
            this.btn_Square = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_clean.Location = new System.Drawing.Point(28, 21);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(108, 38);
            this.btn_clean.TabIndex = 0;
            this.btn_clean.Text = "화면 초기화";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click_1);
            // 
            // btn_Black
            // 
            this.btn_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Black.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_Black.ForeColor = System.Drawing.Color.White;
            this.btn_Black.Location = new System.Drawing.Point(167, 16);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(86, 48);
            this.btn_Black.TabIndex = 1;
            this.btn_Black.Text = "Black";
            this.btn_Black.UseVisualStyleBackColor = false;
            this.btn_Black.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_Red.ForeColor = System.Drawing.Color.White;
            this.btn_Red.Location = new System.Drawing.Point(263, 16);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(86, 48);
            this.btn_Red.TabIndex = 2;
            this.btn_Red.Text = "Red";
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Blue
            // 
            this.btn_Blue.BackColor = System.Drawing.Color.Blue;
            this.btn_Blue.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_Blue.ForeColor = System.Drawing.Color.White;
            this.btn_Blue.Location = new System.Drawing.Point(361, 16);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(86, 48);
            this.btn_Blue.TabIndex = 3;
            this.btn_Blue.Text = "Blue";
            this.btn_Blue.UseVisualStyleBackColor = false;
            this.btn_Blue.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Yellow
            // 
            this.btn_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_Yellow.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_Yellow.ForeColor = System.Drawing.Color.Black;
            this.btn_Yellow.Location = new System.Drawing.Point(461, 16);
            this.btn_Yellow.Name = "btn_Yellow";
            this.btn_Yellow.Size = new System.Drawing.Size(86, 48);
            this.btn_Yellow.TabIndex = 4;
            this.btn_Yellow.Text = "Yellow";
            this.btn_Yellow.UseVisualStyleBackColor = false;
            this.btn_Yellow.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Square);
            this.groupBox1.Controls.Add(this.btn_Line);
            this.groupBox1.Controls.Add(this.btn_Circle);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕", 9F);
            this.groupBox1.Location = new System.Drawing.Point(571, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도형";
            // 
            // btn_Line
            // 
            this.btn_Line.AutoSize = true;
            this.btn_Line.Checked = true;
            this.btn_Line.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_Line.Location = new System.Drawing.Point(13, 21);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(42, 23);
            this.btn_Line.TabIndex = 6;
            this.btn_Line.TabStop = true;
            this.btn_Line.Text = "선";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_Circle
            // 
            this.btn_Circle.AutoSize = true;
            this.btn_Circle.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_Circle.Location = new System.Drawing.Point(67, 21);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(42, 23);
            this.btn_Circle.TabIndex = 7;
            this.btn_Circle.Text = "원";
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btn_Square
            // 
            this.btn_Square.AutoSize = true;
            this.btn_Square.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.btn_Square.Location = new System.Drawing.Point(120, 21);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(72, 23);
            this.btn_Square.TabIndex = 8;
            this.btn_Square.Text = "사각형";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Yellow);
            this.Controls.Add(this.btn_Blue);
            this.Controls.Add(this.btn_Red);
            this.Controls.Add(this.btn_Black);
            this.Controls.Add(this.btn_clean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_Black;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Yellow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_Line;
        private System.Windows.Forms.RadioButton btn_Circle;
        private System.Windows.Forms.RadioButton btn_Square;
    }
}

