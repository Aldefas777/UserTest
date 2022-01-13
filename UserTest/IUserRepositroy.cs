using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    interface IUserRepositroy
    {
        IEnumerable<User> GetOrderedUser();

        void AddUser(int id, string name);

        User GetUser(int idGet);
    }
}
