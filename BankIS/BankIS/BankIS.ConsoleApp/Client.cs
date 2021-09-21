using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class Client
    {
        public Client()
        {
            HomeAddress = new Address();
        }

        public Client(string street, string city, string jmeno = "nezadano", int age = -1)
        {
            HomeAddress = new Address();
            HomeAddress.Street = street;
            HomeAddress.City = city;
            Name = jmeno;
            Age = age;
        }

        public Client(Address address, string jmeno = "nezadano", int age = -1)
        {
            HomeAddress = address;
            Name = jmeno;
            Age = age;
        }

        /// <summary>
        /// Jméno klienta
        /// </summary>
        public string Name { get; set; }

        public int Age {  get; set; }

        public Address HomeAddress { get; set; }

        /// <summary>
        /// Vytiskne do konzole jmeno a adresu klienta
        /// </summary>
        public void Print()
        {
            Console.WriteLine(Name);

            if (HomeAddress != null)
            {
                HomeAddress.Print();
            }
            else
            {
                Console.WriteLine("Adresa je null");
            }
        }

        public void SaveToFile(string pathToFile)
        {
            File.WriteAllText(pathToFile, Name);
        }
    }
}
