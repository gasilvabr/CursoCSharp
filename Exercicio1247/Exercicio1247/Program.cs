using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1247
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] entrada;
            double d, vf, vg, tf, tg, sg;
            
            do
            {
                entrada = str.Split();
                d = Double.Parse(entrada[0]);
                vf = Double.Parse(entrada[1]);
                vg = Double.Parse(entrada[2]);
                tf = 12.0 / vf;
                sg = Math.Sqrt(12.0 * 12.0 + d * d);
                tg = sg / vg;
                if (tg <= tf) Console.WriteLine("S");
                else Console.WriteLine("N");

                // Proximos Dados
                str = Console.ReadLine();
            } while (!string.IsNullOrEmpty(str));
        }
    }
}
