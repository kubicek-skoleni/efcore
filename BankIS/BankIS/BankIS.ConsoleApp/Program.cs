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
            
            var file = "dataset_1.txt";
            Console.WriteLine($"Načítám klienty z {file}");

            var clients = Client.LoadClients(file);

            var cnt = clients.Count;
            Console.WriteLine($"Počet klientů v seznamu: {cnt}");
            Console.WriteLine();

            BankContext context = new BankContext();

            foreach(var client in clients)
            {
                context.Clients.Add(client);
            }

            context.SaveChanges();


            // LINQ

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
        }

    }
}
