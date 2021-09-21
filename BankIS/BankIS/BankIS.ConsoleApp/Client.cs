using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class Client
    {
        /// <summary>
        /// Jméno klienta
        /// </summary>
        public string FirstName { get; set; }

        public int Age {  get; set; }

        public Address HomeAddress { get; set; }

        /// <summary>
        /// Vytiskne do konzole jmeno a adresu klienta
        /// </summary>
        public void Print()
        {
            Console.WriteLine(FirstName);

            if (HomeAddress != null)
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
