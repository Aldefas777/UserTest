using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using Windows.Storage;

namespace UserTest
{
    public static class DataAccess
    {
        public static void AddData(string inputText)
        {
            string dbpath = "D:/Users.db";
            using (SqliteConnection db = 
              new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                
                insertCommand.CommandText = "INSERT INTO User VALUES (NULL, @Entry);";
                insertCommand.Parameters.AddWithValue("@Entry", inputText);
                insertCommand.ExecuteReader();

                db.Close();
            }

        }

        public static List<User> GetData()
        {
            List<User> entries = new List<User>();

            string dbpath = "D:/Users.db";
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
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
    }
}
