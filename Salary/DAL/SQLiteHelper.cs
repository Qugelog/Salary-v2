using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary.DAL
{
    class SQLiteHelper
    {
        internal static List<User> GetUsers()
        {
            try
            {
                using (var connection = new SQLiteConnection(@"Data Source = \salaries.sqlite;Version=3;"))
                {
                    connection.Open();
                    using (var cmd = new SQLiteCommand(@"
                            SELECT * FROM users;
                        "))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            List<User> users = new List<User>();
                            while(reader.Read())
                            {
                                users.Add(new User { 
                                    Id = reader.GetInt32(0),
                                    FullName = reader.GetString(1),
                                    Role = reader.GetInt32(2)
                                
                                });;
                            }

                            return users;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
