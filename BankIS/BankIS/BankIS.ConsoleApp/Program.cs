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

            //najit nejmladsiho a nejstarsiho z olomouce
            var result = clients
                .Where(x => x.HomeAddress.City == "Olomouc")
                .OrderBy(x => x.Age);

            var oldest = result.Last();
            var youngest = result.First();
            

            Console.WriteLine($"nejmladsi {youngest} {Environment.NewLine}nejstarsi: {oldest}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
        }

    }
}
