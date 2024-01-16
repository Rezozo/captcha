﻿namespace captcha
{
    partial class Registration
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
            this.createAccBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.RegistLabel = new System.Windows.Forms.Label();
            this.backBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // createAccBtn
            // 
            this.createAccBtn.AutoSize = true;
            this.createAccBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createAccBtn.Depth = 0;
            this.createAccBtn.Location = new System.Drawing.Point(317, 355);
            this.createAccBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createAccBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createAccBtn.Name = "createAccBtn";
            this.createAccBtn.Primary = false;
            this.createAccBtn.Size = new System.Drawing.Size(175, 36);
            this.createAccBtn.TabIndex = 17;
            this.createAccBtn.Text = "Создать аккаунт";
            this.createAccBtn.UseVisualStyleBackColor = true;
            this.createAccBtn.Click += new System.EventHandler(this.createAccBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(255, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пароль";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(260, 270);
            this.PasswordTxt.MaxLength = 15;
            this.PasswordTxt.Multiline = true;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(281, 39);
            this.PasswordTxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(255, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин";
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(260, 185);
            this.LoginTxt.MaxLength = 70;
            this.LoginTxt.Multiline = true;
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(281, 39);
            this.LoginTxt.TabIndex = 13;
            // 
            // RegistLabel
            // 
            this.RegistLabel.AutoSize = true;
            this.RegistLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistLabel.Location = new System.Drawing.Point(311, 103);
            this.RegistLabel.Name = "RegistLabel";
            this.RegistLabel.Size = new System.Drawing.Size(174, 31);
            this.RegistLabel.TabIndex = 12;
            this.RegistLabel.Text = "Регистрация";
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.Depth = 0;
            this.backBtn.Location = new System.Drawing.Point(13, 85);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.backBtn.Name = "backBtn";
            this.backBtn.Primary = false;
            this.backBtn.Size = new System.Drawing.Size(90, 36);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "<- Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createAccBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.RegistLabel);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton createAccBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Label RegistLabel;
        private MaterialSkin.Controls.MaterialFlatButton backBtn;
    }
}