using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{

    public class IUserRepository : IUserRepositroy
    {
            List<User> users = new List<User>();



        public IEnumerable<User> GetOrderedUser()
        {
            users.Sort(delegate (User a, User b)
            {
                return a.UserID.CompareTo(b.UserID);

            });
            return users;
        }

        public void AddUser(int id, string name)
        {
            users.Add(new User() { UserName = name, UserID = id });
        }

        public User GetUser( int idGet)
        {
            User result = users.Find(
                delegate(User a)
                {
                    return a.UserID == idGet;
                } );
            return result;
        }
    }
}
