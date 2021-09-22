using System;
using System.IO;

namespace BankIS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var clients = Dataset.Data.LoadFromXML();

            Client.SaveClientsToFile(clients, "dataset_1.txt");
            
        }
    }
}
