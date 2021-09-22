using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var file = "allclients.txt";
            Console.WriteLine($"Načítám klienty z {file}");

            var clients = Client.LoadClients(file);

            var cnt = clients.Count;
            Console.WriteLine($"Počet klientů v seznamu: {cnt}");

            foreach(var client in clients)
            {
                client.Print();
            }

            //Client.SaveClientsToFile(clients, file);

        }

    }
}
