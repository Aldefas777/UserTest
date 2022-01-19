using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    interface IUserRepositroy
    {
        IEnumerable<User> GetOrderedUser(string connectionString);

        void AddUser(int id, string name, string connconnectionString);

        User GetUser(int idGet, string connectionString);
    }
}
