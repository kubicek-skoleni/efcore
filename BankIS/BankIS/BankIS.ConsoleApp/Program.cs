using System;
using System.IO;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Client c1 = new Client(city: "Brno", street: "Kopečná 23", jmeno: "Martin Novák", age: 55);

            Address ostrava = new Address("Ostrava", "Tovární 13");
            Client c2 = new Client(ostrava, "Martina Veselá", 33);


            // připravte metodu "SaveToFile(string filePath) na klientovi

            c1.Age = 15;
            Console.WriteLine(c1.Age);

            c1.Print();
            Console.WriteLine();
            c2.Print();

            c1.SaveToFile("klient1.txt");
            c2.SaveToFile("klient2.txt");
            
        }

    }
}
