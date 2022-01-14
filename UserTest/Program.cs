using System;
using System.Collections.Generic;
using UserTest;




public class example
{
    public static void Main()
    {

        int vib = 0;

        Console.WriteLine("Введите нужную функцию, 1-Добавить пользоваеля, 2-Пользователей, 4-Выход");

        while (vib != 4)
        {
            vib = Convert.ToInt32(Console.ReadLine());
            switch (vib)
            {
                case 1:
                    string inputText = Console.ReadLine();
                    DataAccess.AddData(inputText);
                    break;
                case 2:
                    

                    foreach (User aUser in DataAccess.GetData())
                    {
                        Console.WriteLine(aUser);
                    }

                    break;
                default:
                    Console.WriteLine("Такой функции нет");
                    break;
            }
        }
        Console.ReadKey();
    }
}



