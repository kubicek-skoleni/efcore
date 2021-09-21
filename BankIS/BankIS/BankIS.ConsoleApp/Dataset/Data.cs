using BankIS.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.Dataset
{
    public class Data
    {
        public static List<Client> LoadFromXML(string file = @"C:\Users\Student\Documents\repos\efcore\BankIS\BankIS\BankIS.ConsoleApp\Dataset\Dataset.xml")
        {
            return Dataset.Serialization.DeSerialize<List<Client>>(file);
        }
    }
}
