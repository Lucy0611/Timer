
namespace Timer
{
    partial class Form_Time_Main
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
            this.components = new System.ComponentModel.Container();
            this.txt_realTime = new System.Windows.Forms.TextBox();
            this.btn_Alam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tmr_display = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_realTime
            // 
            this.txt_realTime.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_realTime.Location = new System.Drawing.Point(27, 25);
            this.txt_realTime.Name = "txt_realTime";
            this.txt_realTime.Size = new System.Drawing.Size(652, 63);
            this.txt_realTime.TabIndex = 0;
            this.txt_realTime.Text = "2020.05.02 14:44:59.214";
            this.txt_realTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Alam
            // 
            this.btn_Alam.Font = new System.Drawing.Font("나눔고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Alam.Location = new System.Drawing.Point(27, 216);
            this.btn_Alam.Name = "btn_Alam";
            this.btn_Alam.Size = new System.Drawing.Size(224, 56);
            this.btn_Alam.TabIndex = 1;
            this.btn_Alam.Text = "알람";
            this.btn_Alam.UseVisualStyleBackColor = true;
            this.btn_Alam.UseWaitCursor = true;
            this.btn_Alam.Click += new System.EventHandler(this.btn_Alam_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(254, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "스톱워치";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("나눔고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(464, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "타이머";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // tmr_display
            // 
            this.tmr_display.Interval = 1;
            this.tmr_display.Tick += new System.EventHandler(this.tmr_display_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Alam);
            this.Controls.Add(this.txt_realTime);
            this.Name = "Form1";
            this.Text = "Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_realTime;
        private System.Windows.Forms.Button btn_Alam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer tmr_display;
    }
}

