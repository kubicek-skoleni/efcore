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


        }

    }
}
