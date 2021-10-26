using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary.Forms.Users
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id, name FROM roles", db.GetConnection());

            db.OpenConnection();
            DataSet ds = new DataSet();
            adapter.Fill(ds);

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id, name FROM roles", db.GetConnection());

            db.OpenConnection();
            DataSet ds = new DataSet();
            adapter.Fill(ds);



            roleComboBox.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                roleComboBox.Items.Add(row.ItemArray[0] + " - " + row.ItemArray[1]);

            }


        }

        private void RefreshDataBtn_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBoxFullName.Text)|| string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text)) return;

            ToolTip toolTip = new ToolTip();

            if (string.IsNullOrEmpty(FullNameTextBox.Text))
            {
                toolTip.SetToolTip(FullNameTextBox, "Заполните Ф.И.О");
                return;
            }

            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                toolTip.SetToolTip(loginTextBox, "Введите логин");
                return;
            }

            if (string.IsNullOrEmpty(PasswordoTextBox.Text))
            {
                toolTip.SetToolTip(PasswordoTextBox, "Введите пароль");
                return;
            }

            if(string.IsNullOrEmpty(roleComboBox.SelectedItem.ToString()))
            {
                toolTip.SetToolTip(PasswordoTextBox, "Выберите должность сотрудника");
                return;
            }

            if (isUserExists()) return;

            Database db = new Database();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users`(full_name, login, password, role) VALUES(@fullName, @login, @password, @role)", db.GetConnection());
            cmd.Parameters.Add("@fullName", MySqlDbType.VarChar).Value = FullNameTextBox.Text.Trim();
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginTextBox.Text.Trim();
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordoTextBox.Text.Trim();
            cmd.Parameters.Add("@role", MySqlDbType.Int32).Value = roleComboBox.SelectedItem.ToString().Split('-')[0].Trim();

            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешная регистрация нового сотрудника!");
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
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginTextBox.Text;

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

    }
}
