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
                case 2:
                    string inputText = Console.ReadLine();
                    DataAccess.AddData(inputText);
                    break;
                case 3:
                    DataAccess.GetData();
                    break;
                default:
                    Console.WriteLine("Такой функции нет");
                    break;
            }
        }
        Console.ReadKey();
    }
}



