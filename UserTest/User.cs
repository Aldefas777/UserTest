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
        public int UserID { get; set; }
        public override string ToString()
        {
            return "ID: " + UserID + " Name: " + UserName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            User objAsUser = obj as User;
            if (objAsUser == null) return false;
            else return Equals(objAsUser);
        }
        public override int GetHashCode()
        {
            return UserID;
        }

        public bool Equals(User other)
        {
            if (other == null) return false;
            return (this.UserID.Equals(other.UserID));
        }
    }
}
