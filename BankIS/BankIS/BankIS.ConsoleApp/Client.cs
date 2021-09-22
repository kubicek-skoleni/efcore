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
        /// <summary>
        /// Jméno klienta
        /// </summary>
        public string FirstName { get; set; }

        public string LastName {  get; set; }

        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        public DateTime DateOfBirth { get; set; }

        public Address Address { get; set; }

        /// <summary>
        /// Vytiskne do konzole jmeno a adresu klienta
        /// </summary>
        public void Print()
        {
            Console.WriteLine(FirstName);

            if (Address != null)
            {
                Console.WriteLine(Address.Street);
                Console.WriteLine(Address.City);
            }
            else
            {
                Console.WriteLine("Adresa nezadána");
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName};{Age};{Address.Street};{Address.City}";
        }

        public static void SaveClientsToFile(IEnumerable<Client> clients, string file)
        {
            foreach (var client in clients)
            {
                var clientWithNewLine = client.ToString() + Environment.NewLine;
                File.AppendAllText(file, clientWithNewLine);
            }
        }
    }
}
