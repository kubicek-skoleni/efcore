﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankIS.ConsoleApp
{
    public class Client
    {
        public string Name { get; set; }

        public int Age {  get; set; }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
