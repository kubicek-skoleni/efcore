using System;
using System.IO;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Address ostrava = new Address("Ostrava", "Tovární 13");
            //ostrava.City = "Ostrava";
            //ostrava.Street = "Tovární 14";

            Client c1;
            c1 = new Client("Kolejní 22","Brno");
            c1.Name = "Jan Novák";
            c1.Age = 31;
            

            //Client c2;
            //c2 = c1;
            //c2.Name = "Martina Veselá";
            //c2.Age = 33;
            //c2.HomeAddress = ostrava;
            

            c1.Print();
            Console.WriteLine();
            //c2.Print();
            
        }

    }
}
