using System;
using System.Text.RegularExpressions;

namespace TP6_pto5
{
    class Program
    {
        static void Main(string[] args)
        {
            string e1, e2, e3;


            e1 = "email@ejemplo.com";
            e2 = "email@ejemplo@.com";
            e3 = "email.ejemplo.com";

            emailValido(e1);
            emailValido(e2);
            emailValido(e3);

            Console.ReadKey();
        }

        public static void emailValido(string email)
        {
            string pattern = @"^\w+@[a-zA-Z]+?\.[a-zA-Z]{2,3}$";

            Regex rgx = new Regex(pattern);

            if (rgx.IsMatch(email))
            {
                Console.WriteLine("Es válido");
            }
            else
            {
                Console.WriteLine("Es inválido");
            }

        }
    }
}
