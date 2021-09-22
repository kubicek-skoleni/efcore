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

            BankContext context = new BankContext();

            var cnt = context.Clients.Count();
            Console.WriteLine($"Počet klientů v seznamu: {cnt}");
            Console.WriteLine();





            //context.SaveChanges();

            // LINQ

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
        }

    }
}
