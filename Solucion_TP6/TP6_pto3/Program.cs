using System;

namespace TP6_pto3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Escriba el primer numero");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor absoluto:" + Math.Abs(a));
            Console.WriteLine("Cuadrado:" + Math.Pow(a, 2));
            Console.WriteLine("Seno:" + Math.Sin(a));
            Console.WriteLine("Coseno:" + Math.Cos(a));
            Console.WriteLine("Parte entera:" + Math.Truncate(a));

            Console.WriteLine("Escriba el segundo numero");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el tercer numero");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Maximo:" + Math.Max(b, c));
            Console.WriteLine("Minimo:" + Math.Min(b, c));

            Console.ReadLine();
        }
    }
}
