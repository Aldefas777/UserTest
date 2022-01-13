using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{

    public class UserRepository : IUserRepositroy
    {
            List<User> users = new List<User>();
            int id = 0;



        public IEnumerable<User> GetOrderedUser()
        {
            users.Sort(delegate (User a, User b)
            {
                return a.UserID.CompareTo(b.UserID);

            });
            return users;
        }

        public void AddUser(User Item)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            string Name = Console.ReadLine();

            users.Add(new User() { UserName = Name, UserID = id });
        }

        public User GetUser()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            User result = users.Find(
                delegate(User a)
                {
                    return a.UserID == id;
                } );
            return result;
        }
        
        public void Dispose()
        {
            Console.ReadKey();
        }
    }
}
