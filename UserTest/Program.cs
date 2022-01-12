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


public class Example
{
    public static User obj { get; set; }

    

    public static void Main()
    {
        UserRepository repository = new UserRepository();
        int vib = 0;

        Console.WriteLine("Введите нужную функцию, 1-Добавить пользоваеля, 2-Вывести нужную функцию, 3-Вывести отсортированный список пользователей, 4-Выход");

        while(vib != 4)
        {
            vib = Convert.ToInt32(Console.ReadLine());
            switch (vib)
            {
                case 1:
                    repository.AddUser();
                    break;
                case 2:
                    repository.GetUser();
                    break;
                case 3:
                    repository.GetOrderedUser();
                    break;
                default:
                    Console.WriteLine("Такой функции нет");
                    break;
            }

        }
        



        Console.ReadKey();
    }
}
