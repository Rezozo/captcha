namespace kapcha
{
    partial class CaptchaForm
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
            this.checkKapcha = new MaterialSkin.Controls.MaterialFlatButton();
            this.CaptchaTxtB = new System.Windows.Forms.TextBox();
            this.captchaBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkKapcha
            // 
            this.checkKapcha.AutoSize = true;
            this.checkKapcha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkKapcha.Depth = 0;
            this.checkKapcha.Location = new System.Drawing.Point(152, 237);
            this.checkKapcha.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkKapcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkKapcha.Name = "checkKapcha";
            this.checkKapcha.Primary = false;
            this.checkKapcha.Size = new System.Drawing.Size(113, 36);
            this.checkKapcha.TabIndex = 13;
            this.checkKapcha.Text = "Проверить";
            this.checkKapcha.UseVisualStyleBackColor = true;
            this.checkKapcha.Click += new System.EventHandler(this.checkCapcha_Click);
            // 
            // CaptchaTxtB
            // 
            this.CaptchaTxtB.Location = new System.Drawing.Point(120, 189);
            this.CaptchaTxtB.MaxLength = 6;
            this.CaptchaTxtB.Multiline = true;
            this.CaptchaTxtB.Name = "CaptchaTxtB";
            this.CaptchaTxtB.Size = new System.Drawing.Size(178, 39);
            this.CaptchaTxtB.TabIndex = 12;
            // 
            // captchaBox
            // 
            this.captchaBox.Location = new System.Drawing.Point(132, 120);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.Size = new System.Drawing.Size(150, 50);
            this.captchaBox.TabIndex = 14;
            this.captchaBox.TabStop = false;
            // 
            // CaptchaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 331);
            this.Controls.Add(this.captchaBox);
            this.Controls.Add(this.checkKapcha);
            this.Controls.Add(this.CaptchaTxtB);
            this.Name = "CaptchaForm";
            this.Text = "Капча";
            this.Load += new System.EventHandler(this.CaptchaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton checkKapcha;
        private System.Windows.Forms.TextBox CaptchaTxtB;
        private System.Windows.Forms.PictureBox captchaBox;
    }
}