
namespace Salary.Forms
{
    partial class LoginForm
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
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.accountNotExist = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLoginBar = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.panelLoginBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.labelCreateAccount.Location = new System.Drawing.Point(87, 387);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(137, 23);
            this.labelCreateAccount.TabIndex = 19;
            this.labelCreateAccount.Text = "Создайте его";
            this.labelCreateAccount.Click += new System.EventHandler(this.labelCreateAccount_Click);
            // 
            // accountNotExist
            // 
            this.accountNotExist.AutoSize = true;
            this.accountNotExist.Location = new System.Drawing.Point(73, 364);
            this.accountNotExist.Name = "accountNotExist";
            this.accountNotExist.Size = new System.Drawing.Size(183, 23);
            this.accountNotExist.TabIndex = 18;
            this.accountNotExist.Text = "Ещё нет аккаунта?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.button1.Location = new System.Drawing.Point(34, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "ОЧИСТИТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(34, 251);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(216, 35);
            this.LoginBtn.TabIndex = 16;
            this.LoginBtn.Text = "ВОЙТИ";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(34, 202);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(216, 28);
            this.textBoxPassword.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(34, 145);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 28);
            this.textBoxLogin.TabIndex = 13;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(31, 125);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(65, 23);
            this.labelLogin.TabIndex = 12;
            this.labelLogin.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Вход в аккаунт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelLoginBar
            // 
            this.panelLoginBar.BackColor = System.Drawing.Color.Transparent;
            this.panelLoginBar.Controls.Add(this.iconButtonExit);
            this.panelLoginBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginBar.Location = new System.Drawing.Point(0, 0);
            this.panelLoginBar.Name = "panelLoginBar";
            this.panelLoginBar.Size = new System.Drawing.Size(285, 35);
            this.panelLoginBar.TabIndex = 20;
            this.panelLoginBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoginBar_Paint);
            this.panelLoginBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoginBar_MouseDown);
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
            this.iconButtonExit.Location = new System.Drawing.Point(244, 0);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(38, 35);
            this.iconButtonExit.TabIndex = 10;
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.accountNotExist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLoginBar);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panelLoginBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Label accountNotExist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLoginBar;
        private FontAwesome.Sharp.IconButton iconButtonExit;
    }
}