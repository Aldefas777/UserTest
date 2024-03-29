﻿using System;
using System.Collections.Generic;
using UserTest;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

public class example
{

    public static void Main(string[] args)
    {

        

        IUserRepositroy repository = new UserRepasitorySQlite();

        int vib = 0;

        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("MySQliteConnect.json");
        var config = builder.Build();
        string connectionString = config.GetConnectionString("DefaultConnection");

        Console.WriteLine("Введите нужную функцию, 1-Добавить пользоваеля, 2-Пользователей, 3-Найти пользователя, 4-Выход");

        while (vib != 4)
        {
            vib = Convert.ToInt32(Console.ReadLine());
            switch (vib)
            {
                case 1:
                    Console.WriteLine("Введите ID");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите Имя");
                    string name = Console.ReadLine();
                    repository.AddUser(id, name, connectionString);
                    break;
                case 2:
                    foreach (User aUser in repository.GetOrderedUser(connectionString))
                    {
                        Console.WriteLine(aUser);
                    }

                    break;

                case 3:
                    Console.WriteLine("Введите ID");
                    int idGet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(repository.GetUser(idGet, connectionString));
                    break;
                case 4: 
                    Console.WriteLine("Вы вышли из приложения");
                    break;
                default:
                    Console.WriteLine("Такой функции нет");
                    break;
            }
        }
    }
}



