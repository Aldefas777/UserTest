using System;
using System.Collections.Generic;

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


public class Example
{
    public static User obj { get; set; }

    public static void Main()
    {
        List<User> users = new List<User>();
        int id = 0;

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Введите нужный ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите имя пользователя");
            string Name = Console.ReadLine();

            users.Add(new User() { UserName = Name, UserID = id });
        }

        Console.WriteLine("Введите номер записи, который вы хотите вывести");

        id = Convert.ToInt32(Console.ReadLine());
        obj = users[id-1];


        Console.WriteLine();


        foreach (User aUser in users)
        {
            Console.WriteLine(aUser);
        }
        Console.WriteLine("Запись для вывода");
        Console.WriteLine(obj.ToString());

        Console.WriteLine("Отсортированная запись");

       users.Sort(delegate(User a, User b)
        {
            return a.UserID.CompareTo(b.UserID);

        });

        foreach (User aUser in users)
        {
            Console.WriteLine(aUser);
        }

        Console.ReadKey();
    }
}
