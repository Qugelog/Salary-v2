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

namespace Salary.Forms.Roles
{
    public partial class AddRoleForm : Form
    {
        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxRoleName.Text))
            {
                MessageBox.Show("Введите имя должности", null, MessageBoxButtons.OK);
            }

            if (numericUpDownSalary.Value < 0)
            {
                MessageBox.Show("Оклад введет некоректно!", null, MessageBoxButtons.OK);
            }

            if (isRoleExists()) return;

            Database db = new Database();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `roles`(name, salary) VALUES(@name, @salary)", db.GetConnection());
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxRoleName.Text.Trim();
            cmd.Parameters.Add("@salary", MySqlDbType.Int32).Value = numericUpDownSalary.Value;

            db.OpenConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Должность успешно добавлена!");
            }
            else
            {
                MessageBox.Show("Произошла ошибка при добавлении должности!");
            }

            db.CloseConnection();
        }

        public bool isRoleExists()
        {
            Database db = new Database();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `roles` WHERE `name` = @roleName", db.GetConnection());
            cmd.Parameters.Add("@roleName", MySqlDbType.VarChar).Value = textBoxRoleName.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Должность уже добавлена!");
                return true;
            }
            else
            {
                return false;
            }
        }



        private void AddRoleForm_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
