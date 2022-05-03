
namespace Timer
{
    partial class Form_Alam_Child
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtxt_alamSetting = new System.Windows.Forms.MaskedTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxt_alamSetting
            // 
            this.mtxt_alamSetting.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mtxt_alamSetting.Location = new System.Drawing.Point(42, 55);
            this.mtxt_alamSetting.Mask = "90시90분";
            this.mtxt_alamSetting.Name = "mtxt_alamSetting";
            this.mtxt_alamSetting.ResetOnSpace = false;
            this.mtxt_alamSetting.Size = new System.Drawing.Size(421, 50);
            this.mtxt_alamSetting.TabIndex = 0;
            this.mtxt_alamSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_alamSetting.ValidatingType = typeof(System.DateTime);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("경기천년제목 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_save.Location = new System.Drawing.Point(250, 124);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(213, 42);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "저장";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("경기천년제목 Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(42, 124);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(202, 42);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form_Alam_Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 215);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.mtxt_alamSetting);
            this.Name = "Form_Alam_Child";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_alamSetting;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}