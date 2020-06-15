using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1805
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
             
            int a1 = int.Parse(entrada[0]);
            int an = int.Parse(entrada[1]);
            double n = an - a1 + 1;
            double soma = (a1 + an) * n / 2.0;
            Console.WriteLine($"{soma:0}");
            Console.ReadKey();
        }
    }
}
