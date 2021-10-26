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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void panelLoginBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterForm().ShowDialog();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = textBoxPassword.Text.Trim();


            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @login AND `password` = @password ", db.GetConnection());
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Hide();
                new MainForm().ShowDialog();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Неверный логин или пароль", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
