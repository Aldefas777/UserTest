using System;
using System.Collections.Generic;
using UserTest;




public class example
{
    public static void Main()
    {
        IUserRepositroy repository = new UserRepository();
        int vib = 0;

        Console.WriteLine("Введите нужную функцию, 1-Добавить пользоваеля, 2-Вывести нужную функцию, 3-Вывести отсортированный список пользователей, 4-Выход");

        while (vib != 4)
        {
            vib = Convert.ToInt32(Console.ReadLine());
            switch (vib)
            {
                case 1:
                    Console.Write("Введите ID ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите Имя ");
                    string name = Console.ReadLine();
                    repository.AddUser(id, name);
                    break;
                case 2:
                    Console.Write("Наберите id нужного пользователя ");
                    int idGet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(repository.GetUser(idGet));
                    break;
                case 3:
                    foreach (User aUser in repository.GetOrderedUser())
                    {
                        Console.WriteLine(aUser);
                    }
                    break;
                case 4: Console.WriteLine("Вы вышли из приложения");
                    break;
                default:
                    Console.WriteLine("Такой функции нет");
                    break;
            }
        }
        Console.ReadKey();
    }
}



