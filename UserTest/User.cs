using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    public class User
    {
        public string UserName { get; set; }
        public int UserID{ get; set; }
        public override string ToString()
        {
            return "ID: " + UserId + " Name: " + UserName;
        }
    }
}
