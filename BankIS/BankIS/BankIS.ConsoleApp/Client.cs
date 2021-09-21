using System;
using System.Collections.Generic;
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

        public Client(string street, string city)
        {
            HomeAddress = new Address();
            HomeAddress.Street = street;
            HomeAddress.City = city;
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

            if (HomeAddress != null && !string.IsNullOrEmpty(HomeAddress.Street))
            {
                Console.WriteLine(HomeAddress.Street);
                Console.WriteLine(HomeAddress.City);
            }
            else
            {
                Console.WriteLine("Adresa nezadána");
            }
        }
    }
}
