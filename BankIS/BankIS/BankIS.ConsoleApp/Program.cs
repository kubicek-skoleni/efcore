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

            var c1 = new Client(city: "Brno", street: "Kopečná 23", jmeno: "Martin Novák", age: 55);
            var c2 = new Client("Tovární 13", "Ostrava", "Martina Veselá", 33);
            var c3 = new Client("Česká 1", "Brno", "Karel Novotný", 30);
            var c4 = new Client("Poštovní 3", "Praha", "Jitka", 43);
            var c5 = new Client("Hluchá 13", "Plzeň", "Jiří Ondra", 53);

            // vytvořte list klientů a přiřaďte všech 5
            // klientů do listu

            List<Client> clients = new List<Client>();

            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);
            clients.Add(c4);
            clients.Add(c5);

            var cnt = clients.Count;

            Console.WriteLine($"Počet klientů v seznamu: {cnt}");

            foreach(var client in clients)
            {
                client.Print();
            }


        }

    }
}
