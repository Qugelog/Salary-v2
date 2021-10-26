
namespace Salary.Forms
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.accountExist = new System.Windows.Forms.Label();
            this.loginAccountLabel = new System.Windows.Forms.Label();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.panelLoginBar = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(28, 95);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(63, 23);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Ф.И.О";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullName.Location = new System.Drawing.Point(31, 115);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(216, 28);
            this.textBoxFullName.TabIndex = 2;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(31, 172);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 28);
            this.textBoxLogin.TabIndex = 4;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(31, 340);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(216, 35);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "СОЗДАТЬ АККАУНТ";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.clearBtn.Location = new System.Drawing.Point(31, 402);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(216, 35);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "ОЧИСТИТЬ";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // accountExist
            // 
            this.accountExist.AutoSize = true;
            this.accountExist.Location = new System.Drawing.Point(70, 453);
            this.accountExist.Name = "accountExist";
            this.accountExist.Size = new System.Drawing.Size(179, 23);
            this.accountExist.TabIndex = 7;
            this.accountExist.Text = "Уже есть аккаунт?";
            // 
            // loginAccountLabel
            // 
            this.loginAccountLabel.AutoSize = true;
            this.loginAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.loginAccountLabel.Location = new System.Drawing.Point(106, 480);
            this.loginAccountLabel.Name = "loginAccountLabel";
            this.loginAccountLabel.Size = new System.Drawing.Size(67, 23);
            this.loginAccountLabel.TabIndex = 8;
            this.loginAccountLabel.Text = "Войти";
            this.loginAccountLabel.Click += new System.EventHandler(this.loginAccountLabel_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonExit.IconColor = System.Drawing.Color.DarkGray;
            this.iconButtonExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExit.IconSize = 16;
            this.iconButtonExit.Location = new System.Drawing.Point(248, 0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(38, 35);
            this.iconButtonExit.TabIndex = 9;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // panelLoginBar
            // 
            this.panelLoginBar.BackColor = System.Drawing.Color.Transparent;
            this.panelLoginBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginBar.Location = new System.Drawing.Point(0, 0);
            this.panelLoginBar.Name = "panelLoginBar";
            this.panelLoginBar.Size = new System.Drawing.Size(285, 35);
            this.panelLoginBar.TabIndex = 10;
            this.panelLoginBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoginBar_MouseDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(31, 230);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(216, 28);
            this.textBoxPassword.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пароль";
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordConfirm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(31, 288);
            this.textBoxPasswordConfirm.Multiline = true;
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.PasswordChar = '*';
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(216, 28);
            this.textBoxPasswordConfirm.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Подтвердите пароль";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButtonExit);
            this.Controls.Add(this.loginAccountLabel);
            this.Controls.Add(this.accountExist);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLoginBar);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label accountExist;
        private System.Windows.Forms.Label loginAccountLabel;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Panel panelLoginBar;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.Label label5;
    }
}