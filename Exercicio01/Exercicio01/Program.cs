﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string s = Console.ReadLine();
            Console.WriteLine($"Bem-vindo, sr. {s}");
            Console.WriteLine("Bem-vindo, {" + s + "}");
            Console.ReadKey();
        }
    }
}
