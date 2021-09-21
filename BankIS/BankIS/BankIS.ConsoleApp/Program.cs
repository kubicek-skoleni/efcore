﻿using System;
using System.IO;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Address ostrava = new Address();
            ostrava.City = "Ostrava";
            ostrava.Street = "Tovární 13";
                
            Client c1 = new Client();
            c1.Name = "Jan Novák";
            c1.Age = 31;
            c1.HomeAddress = ostrava;

            Client c2 = new Client();
            c2.Name = "Martina Veselá";
            c2.Age = 33;
            c2.HomeAddress = new Address();
            c2.HomeAddress.Street = "Vinohradská 16";
            c2.HomeAddress.City = "Praha";


            c1.Print();

            
        }
    }
}