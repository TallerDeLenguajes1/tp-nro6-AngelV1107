using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_pto2
{
    class Program
    {
        static void Main(string[] args)
        {
            calculadora();

            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadLine();
        }

        public static void calculadora()
        {
            char operacion;
            int a, b;
            char retry;

            
            do
            {
                operacion = '+';
                do
                {
                    if (!((operacion == '+') || (operacion == '-') || (operacion == '*') || (operacion == '/')))
                    {
                        Console.WriteLine("Entrada invalida");
                    }

                    Console.WriteLine("Escriba la operacion");
                    Console.WriteLine("(+, -, *, /)");
                    operacion = Convert.ToChar(Console.ReadLine());

                } while ( !( (operacion == '+') || (operacion == '-') || (operacion == '*') || (operacion == '/') ) );


                Console.WriteLine("Escriba el primer número");
                a = Convert.ToInt32(Console.ReadLine());

                b = 1;

                do
                {
                    if (b == 0 && operacion == '/')
                    {
                        Console.WriteLine("El denominador no puede ser cero");
                    }

                    Console.WriteLine("Escriba el segundo número");
                    b = Convert.ToInt32(Console.ReadLine());

                } while (b == 0);

                Console.WriteLine("Resultado");
                switch (operacion)
                {
                    case '+':
                        Console.WriteLine(a + b);
                        break;
                    case '-':
                        Console.WriteLine(a - b);
                        break;
                    case '*':
                        Console.WriteLine(a * b);
                        break;
                    case '/':
                        Console.WriteLine(a / b);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

                retry = 'Y';
                do
                {
                    if ((retry != 'Y') && (retry != 'N'))
                    {
                        Console.WriteLine("Entrada invalida");
                    }

                    Console.WriteLine("Intentar otra operacion? Y/N");
                    retry = Convert.ToChar(Console.ReadLine());
                    retry = Char.ToUpper(retry);
                } while ((retry != 'Y') && (retry != 'N'));

            } while (retry == 'Y');

        }
    }
}
