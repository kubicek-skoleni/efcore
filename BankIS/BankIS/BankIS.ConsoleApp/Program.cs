﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Client.SaveClientsToFile(clients, file);

            var file = "allclients.txt";
            Console.WriteLine($"Načítám klienty z {file}");

            var clients = Client.LoadClients(file);

            var cnt = clients.Count;
            Console.WriteLine($"Počet klientů v seznamu: {cnt}");

            foreach(var client in clients)
            {
                client.Print();
            }

            // LINQ

            int age = 45;
            var result = clients.Where(client => client.Age > age).ToList();

            Console.WriteLine($"Over {age}:");
            foreach(var client in result)
            {
                client.Print();
            }
        }

    }
}
