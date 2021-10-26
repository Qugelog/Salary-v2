using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Drag Form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelLoginBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loginAccountLabel_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginForm().ShowDialog();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(textBoxFullName.Text)|| string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text)) return;

            ToolTip toolTip = new ToolTip();

            if(string.IsNullOrEmpty(textBoxFullName.Text))
            {
                toolTip.SetToolTip(textBoxFullName, "Заполните Ф.И.О");
                return;
            }

            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                toolTip.SetToolTip(textBoxLogin, "Введите логин");
                return;
            }

            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                toolTip.SetToolTip(textBoxLogin, "Введите пароль");
                return;
            }


            if (textBoxPassword.Text != textBoxPasswordConfirm.Text) 
            { 
                toolTip.SetToolTip(textBoxPassword, "Пароли не совпадают!"); 
                toolTip.SetToolTip(textBoxPasswordConfirm, "Пароли не совпадают!");
                return;
            }
            if (isUserExists()) return;

            Database db = new Database();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users`(full_name, login, password) VALUES(@fullName, @login, @password)", db.GetConnection());
            cmd.Parameters.Add("@fullName", MySqlDbType.VarChar).Value = textBoxFullName.Text.Trim();
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLogin.Text.Trim();
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBoxPassword.Text.Trim();

            db.OpenConnection();

            if(cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешная регистрация!");
                Hide();
                new MainForm().ShowDialog();
            } 
            else
            {
                MessageBox.Show("Произошла ошибка при создании аккаунта!");
            }

            db.CloseConnection();

        }

        public bool isUserExists()
        {

            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login", db.GetConnection());
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxLogin.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже зарегистрирован!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxPasswordConfirm.Text = "";
        }
    }
}
