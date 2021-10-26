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

namespace Salary.Forms
{
    public partial class UsersForms : Form
    {
        private Bitmap bmp;
        public UsersForms()
        {
            InitializeComponent();
        }

        private void UsersForms_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void usersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(usersDataGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                DeleteUser(e);
            }

            if(usersDataGrid.Columns[e.ColumnIndex].Name == "Update")
            {

            }
        }

        private void RefreshDataBtn_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            new Users.AddUserForm().ShowDialog();
        }

        private void UpdateGrid()
        {
            Database db = new Database();

            db.OpenConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT users.id, full_name, login, roles.name, roles.salary  FROM `users` JOIN `roles` ON roles.id = users.role", db.GetConnection());

            adapter.Fill(table);
            usersDataGrid.DataSource = table;

            db.CloseConnection();
        }

        private void UpdateUser(DataGridViewCellEventArgs e)
        {
            int id;
            string fullName, login, role, password;
            id = (int) usersDataGrid.Rows[e.RowIndex].Cells["id"].Value;
            fullName = (string) usersDataGrid.Rows[e.RowIndex].Cells["FullName"].Value;
            login = (string) usersDataGrid.Rows[e.RowIndex].Cells["Login"].Value;
            role = (string)usersDataGrid.Rows[e.RowIndex].Cells["Role"].Value;
            password = (string)usersDataGrid.Rows[e.RowIndex].Cells["Password"].Value;

            

           
                Database db = new Database();
                db.OpenConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT users.id, full_name, login, roles.name, roles.salary  FROM `users`", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter();


                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Пользователь успешно удален!");
                        usersDataGrid.Refresh();
                        adapter.Update((DataTable)usersDataGrid.DataSource);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
        }

        private void DeleteUser(DataGridViewCellEventArgs e)
        {
            int id;
            string fullName;
            id = (int)usersDataGrid.Rows[e.RowIndex].Cells["id"].Value;
            fullName = (string)usersDataGrid.Rows[e.RowIndex].Cells["FullName"].Value;


            if (MessageBox.Show($"Удалить пользователя {fullName}?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Database db = new Database();
                db.OpenConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `users` WHERE id = @id", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    cmd.Parameters.AddWithValue("@id", id);


                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Пользователь успешно удален!");
                        usersDataGrid.Refresh();
                        adapter.Update((DataTable)usersDataGrid.DataSource);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void UsersForms_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            int height = usersDataGrid.Height;
            usersDataGrid.Height = usersDataGrid.RowCount * usersDataGrid.RowTemplate.Height * 2;
            bmp = new Bitmap(usersDataGrid.Width, usersDataGrid.Height);
            usersDataGrid.DrawToBitmap(bmp, new Rectangle(0, 0, usersDataGrid.Width, usersDataGrid.Height));
            usersDataGrid.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
