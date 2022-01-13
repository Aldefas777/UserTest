using System;
using System.Collections.Generic;
using UserTest;


public class User : IEquatable<User>
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

interface IUserRepositroy
{
    IEnumerable<User> GetOrderedUser();

    void AddUser(User Item);

    User GetUser();
}

public class example
{
    public static void Main()
    {
        UserRepository repository = new UserRepository();
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Введите ID и имя пользователя");
            repository.AddUser(new User());
        }


        foreach (User aUser in repository.GetOrderedUser())
        {
            Console.WriteLine(aUser);
        }

        
        Console.Write("Наберите номер записи нужного пользователя  ");
        Console.WriteLine(repository.GetUser());

        Console.ReadKey();
    }
}



