using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using Windows.Storage;
using Microsoft.Extensions.Configuration;

namespace UserTest
{
    public class UserRepasitorySQlite : IUserRepositroy
    {

        public void AddUser(int id, string name)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("MySQliteConnect.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            using (SqliteConnection db =
              new SqliteConnection(connectionString))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;


                insertCommand.CommandText = "INSERT INTO User VALUES (@Id, @Entry);";
                insertCommand.Parameters.AddWithValue("@Id", id);
                insertCommand.Parameters.AddWithValue("@Entry", name);
                insertCommand.ExecuteReader();

                db.Close();
            }
        }

        public IEnumerable<User> GetOrderedUser()
        {
            List<User> entries = new List<User>();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("MySQliteConnect.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            using (SqliteConnection db =
               new SqliteConnection(connectionString))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Name from User", db);

                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    Console.WriteLine(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }

        public User GetUser(int idGet)
        {
            List<User> entries = new List<User>();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("MySQliteConnect.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            using (SqliteConnection db =
               new SqliteConnection(connectionString))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand();
                selectCommand.Connection = db;


                selectCommand.CommandText = "SELECT Name FROM User WHERE Id = @Id;";
                selectCommand.Parameters.AddWithValue("@Id", idGet);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    Console.WriteLine(query.GetString(0));
                }
            }

            return null;
        }
    }
}
