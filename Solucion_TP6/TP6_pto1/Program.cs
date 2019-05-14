using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_pto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;

            Console.WriteLine("Escriba el numero a invertir");
            a = Convert.ToInt32(Console.ReadLine());
            
            while (a != 0)
            {
                b *= 10;
                b += a % 10;
                a /= 10;
            }

            Console.WriteLine("Valor invertido");
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
