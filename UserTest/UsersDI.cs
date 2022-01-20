using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    public class UsersDI
    {
        public IUserRepositroy _repositroy;
        public UsersDI(IUserRepositroy repositroy)
        {
            _repositroy = repositroy;
        }

        public void AddUser(int id, string name, string connectionString)
        {
            _repositroy.AddUser(id, name, connectionString);
        }

        public IEnumerable<User> GetOrderedUser( string connectionString)
        {
          return _repositroy.GetOrderedUser(connectionString);
        }

        public User GetUser(int IdGet, string connectionString)
        {
            return _repositroy.GetUser(IdGet, connectionString);
        }

    }
}
