using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    public class UserRepository
    {
        List<User> users = new List<User>();
        int id = 0;

       public void AddUser()
        {

            Console.WriteLine("Введите нужный ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите имя пользователя");
            string Name = Console.ReadLine();

            users.Add(new User() { UserName = Name, UserID = id });

            foreach (User aUser in users)
            {
                Console.WriteLine(aUser);
            }

        }

        public void GetUser()
        {
            Console.WriteLine("Введите номер записи, который вы хотите вывести");

            id = Convert.ToInt32(Console.ReadLine());
            User obj = users[id - 1];


            Console.WriteLine("Запись для вывода");
            Console.WriteLine(obj.ToString());
        }

        public void GetOrderedUser()
        {
            users.Sort(delegate (User a, User b)
            {
                return a.UserID.CompareTo(b.UserID);

            });

            foreach (User aUser in users)
            {
                Console.WriteLine(aUser);
            }
        }
    }
}
