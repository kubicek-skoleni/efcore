using System;
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

            var file = "dataset_1.txt";
            Console.WriteLine($"Načítám klienty z {file}");

            var clients = Client.LoadClients(file);

            var cnt = clients.Count;
            Console.WriteLine($"Počet klientů v seznamu: {cnt}");
            Console.WriteLine();

            // LINQ

            //z olomouce, pouze vek mezi 20-40, seradit podle veku
            var result = clients
              .Where(c => c.HomeAddress.City == "Olomouc")
              .Where(c => c.Age > 20 && c.Age < 40)
              .OrderBy(c => c.Age)
              .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
        }

    }
}
