﻿namespace kapcha
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.authBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTxtB = new System.Windows.Forms.TextBox();
            this.AuthLabel = new System.Windows.Forms.Label();
            this.registrBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // authBtn
            // 
            this.authBtn.AutoSize = true;
            this.authBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authBtn.Depth = 0;
            this.authBtn.Location = new System.Drawing.Point(315, 328);
            this.authBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.authBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.authBtn.Name = "authBtn";
            this.authBtn.Primary = false;
            this.authBtn.Size = new System.Drawing.Size(168, 36);
            this.authBtn.TabIndex = 11;
            this.authBtn.Text = "Войти в аккаунт";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.Location = new System.Drawing.Point(258, 263);
            this.PasswordTxtB.MaxLength = 15;
            this.PasswordTxtB.Multiline = true;
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.PasswordChar = '*';
            this.PasswordTxtB.Size = new System.Drawing.Size(281, 39);
            this.PasswordTxtB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // LoginTxtB
            // 
            this.LoginTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxtB.Location = new System.Drawing.Point(258, 178);
            this.LoginTxtB.MaxLength = 70;
            this.LoginTxtB.Multiline = true;
            this.LoginTxtB.Name = "LoginTxtB";
            this.LoginTxtB.Size = new System.Drawing.Size(281, 39);
            this.LoginTxtB.TabIndex = 7;
            // 
            // AuthLabel
            // 
            this.AuthLabel.AutoSize = true;
            this.AuthLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AuthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLabel.Location = new System.Drawing.Point(309, 96);
            this.AuthLabel.Name = "AuthLabel";
            this.AuthLabel.Size = new System.Drawing.Size(178, 31);
            this.AuthLabel.TabIndex = 6;
            this.AuthLabel.Text = "Авторизация";
            // 
            // registrBtn
            // 
            this.registrBtn.AutoSize = true;
            this.registrBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrBtn.Depth = 0;
            this.registrBtn.Location = new System.Drawing.Point(294, 376);
            this.registrBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrBtn.Name = "registrBtn";
            this.registrBtn.Primary = false;
            this.registrBtn.Size = new System.Drawing.Size(210, 36);
            this.registrBtn.TabIndex = 12;
            this.registrBtn.Text = "Зарегистрироваться";
            this.registrBtn.UseVisualStyleBackColor = true;
            this.registrBtn.Click += new System.EventHandler(this.registrBtn_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrBtn);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTxtB);
            this.Controls.Add(this.AuthLabel);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton authBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTxtB;
        private System.Windows.Forms.Label AuthLabel;
        private MaterialSkin.Controls.MaterialFlatButton registrBtn;
    }
}

