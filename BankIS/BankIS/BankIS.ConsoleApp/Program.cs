﻿using Microsoft.EntityFrameworkCore;
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

            using (BankContext context = new BankContext())
            {
                //context.Clients.FromSqlRaw("SELECT * ");

                var cnt = context.Clients.Count();
                Console.WriteLine($"Počet klientů v seznamu: {cnt}");
                Console.WriteLine();

                //seskupit podle mesta

                var result = context.Clients
                    .Where(x => x.Age > 50)
                    //.Where(c => string.IsNullOrWhiteSpace(c.Name))
                    .ToList()
                    .Where(c => Client.CheckName(c))
                    .ToList()
                    ;

                //foreach (var group in groupped)
                //{
                //    Console.WriteLine($"podle veku:  {group.Key} - pocet: ");

                //    //foreach (var client in group.Clients)
                //    //{
                //    //    Console.WriteLine("    " + client);
                //    //}
                //}

                Console.WriteLine("x");

                //context.Remove(oldest);
                //context.SaveChanges();

                //context.SaveChanges();

                // LINQ

                //foreach (var item in result)
                //{
                //    Console.WriteLine($"{item}");
                //}
            }
        }

    }
}
