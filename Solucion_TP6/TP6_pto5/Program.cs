using System;
using System.Text.RegularExpressions;

namespace TP6_pto5
{
    class Program
    {
        static void Main(string[] args)
        {
            string e1, e2, e3, p1, p2, p3;


            e1 = "email@ejemplo.com";
            e2 = "email@ejemplo@.com";
            e3 = "email.ejemplo.com";

            p1 = "www.pagina.com";
            p2 = "wwwpagina.com";
            p3 = "www.com";

            emailValido(e1);
            emailValido(e2);
            emailValido(e3);

            paginaValida(p1);
            paginaValida(p2);
            paginaValida(p3);

            Console.ReadKey();
        }

        public static void emailValido(string email)
        {
            string pattern = @"^\w+@[a-zA-Z]+?\.[a-zA-Z]{2,3}$";

            Regex rgx = new Regex(pattern);

            if (rgx.IsMatch(email))
            {
                Console.WriteLine("{0} es email válido", email);
            }
            else
            {
                Console.WriteLine("{0} es email inválido", email);
            }

        }

        public static void paginaValida(string pagina)
        {
            string pattern = @"^www\.\w+\.com";

            Regex rgx = new Regex(pattern);

            if (rgx.IsMatch(pagina))
            {
                Console.WriteLine("{0} es pagina válida", pagina);
            }
            else
            {
                Console.WriteLine("{0} es pagina inválida", pagina);
            }

        }
    }
}
