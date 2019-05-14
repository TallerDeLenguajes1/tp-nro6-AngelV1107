using System;

namespace TP6_pto4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, concat, busqueda, str2, fecha, ecuacion;
            string [] datos_fecha;
            bool formato_invalido, ecValida;

            Console.WriteLine("Escriba una cadena de texto");
            str = Console.ReadLine();

            Console.WriteLine("Primer caracter de la cadena: " + str[0]);
            Console.WriteLine("Tercer caracter de la cadena: " + str[2]);
            Console.WriteLine("Ultimo caracter de la cadena: " + str[str.Length - 1]);
            Console.WriteLine("Longitud de la cadena: " + str.Length);

            concat = " cadena2";
            Console.WriteLine("Concatenada con " + concat + " : " + str + concat);

            Console.WriteLine("Subcadena: " + str.Substring(2));

            Console.WriteLine("\nCalculadora:");
            calculadora();

            Console.WriteLine("Escribiendo cada elemento de la cadena con ciclo foreach:");
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            busqueda = "palabra";
            if (str.Contains(busqueda))
            {
                Console.WriteLine("La palabra \"" + busqueda + "\" aparece en la busqueda");
            }
            else
            {
                Console.WriteLine("La palabra \"" + busqueda + "\" no aparece en la busqueda");
            }


            Console.WriteLine("Cadena en mayúsculas: " + str.ToUpper());

            Console.WriteLine("Cadena en minúsculas: " + str.ToLower());

            Console.WriteLine("Escriba una segunda cadena de texto");
            str2 = Console.ReadLine();

            Console.WriteLine("Comparando ambas cadenas con ==");
            Console.WriteLine(str == str2);

            Console.WriteLine("Comparando ambas cadenas con !=");
            Console.WriteLine(str != str2);

            Console.WriteLine("Comparando ambas cadenas con CompareTo()");
            Console.WriteLine(str.CompareTo(str2));

            Console.WriteLine("Comparando ambas cadenas con Compare()");
            Console.WriteLine(string.Compare(str, str2));

            formato_invalido = false;
            do
            {
                if (formato_invalido)
                {
                    Console.WriteLine("Formato inválido");
                }

                Console.WriteLine("Escriba la fecha actual con el siguiente formato");
                Console.WriteLine("dd/mm/aaaa");

                fecha = Console.ReadLine();

                if (fecha.Length == 10)
                {
                    if (fecha[2] == '/' && fecha[5] == '/')
                    {
                        formato_invalido = false;
                    }
                    else
                    {
                        formato_invalido = true;
                    }
                }
                else
                {
                    formato_invalido = true;
                }

            } while (formato_invalido);

            datos_fecha = fecha.Split('/');

            Console.WriteLine("Día: {0}", datos_fecha[0]);
            Console.WriteLine("Mes: {0}", datos_fecha[1]);
            Console.WriteLine("Año: {0}", datos_fecha[2]);

            ecValida = true;
            do
            {
                if (ecValida == false)
                {
                    Console.WriteLine("Ecuacion invalida");
                }

                Console.WriteLine("Escriba una ecuacion");
                Console.WriteLine("Ejemplo: 582+2");

                ecuacion = Console.ReadLine();

                ecValida = validarEcuacion(ecuacion);
            } while (ecValida == false);



            Console.WriteLine("Resultado: {0}", calculadora2(ecuacion));

            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadLine();
        }

        public static void calculadora()
        {
            char operacion;
            int a, b, resultado;
            char retry;
            string cadena;


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

                } while (!((operacion == '+') || (operacion == '-') || (operacion == '*') || (operacion == '/')));


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

                cadena = "La ";

                switch (operacion)
                {
                    case '+':
                        resultado = a + b;
                        cadena = cadena + "suma ";
                        break;
                    case '-':
                        resultado = a - b;
                        cadena = cadena + "resta ";
                        break;
                    case '*':
                        resultado = a * b;
                        cadena = cadena + "multiplicación ";
                        break;
                    case '/':
                        resultado = a / b;
                        cadena = cadena + "división ";
                        break;
                    default:
                        Console.WriteLine("Error");
                        resultado = -999;
                        break;
                }

                cadena = cadena + "de " + a + " y " + b + " es igual a: " + resultado;

                Console.WriteLine(cadena);

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

        public static int calculadora2(string ecuacion)
        {
            string[] array_str;

            if (ecuacion.Contains(Convert.ToString('+')))
            {
                array_str = ecuacion.Split('+');
                return Convert.ToInt32(array_str[0]) + Convert.ToInt32(array_str[1]);
            }
            else if (ecuacion.Contains(Convert.ToString('-')))
            {
                array_str = ecuacion.Split('-');
                return Convert.ToInt32(array_str[0]) - Convert.ToInt32(array_str[1]);
            }
            else if (ecuacion.Contains(Convert.ToString('*')))
            {
                array_str = ecuacion.Split('*');
                return Convert.ToInt32(array_str[0]) * Convert.ToInt32(array_str[1]);
            }
            else if (ecuacion.Contains(Convert.ToString('/')))
            {
                array_str = ecuacion.Split('/');
                return Convert.ToInt32(array_str[0]) / Convert.ToInt32(array_str[1]);
            }
            else
            {
                return -9999;
            }
        }

        public static bool validarEcuacion (string ecuacion)
        {
            string[] array_str;
            int a, b;

            if (ecuacion.Contains(Convert.ToString('+')))
            {
                array_str = ecuacion.Split('+');
            }
            else if (ecuacion.Contains(Convert.ToString('-')))
            {
                array_str = ecuacion.Split('-');
            }
            else if (ecuacion.Contains(Convert.ToString('*')))
            {
                array_str = ecuacion.Split('*');
            }
            else if (ecuacion.Contains(Convert.ToString('/')))
            {
                array_str = ecuacion.Split('/');

                if ( Convert.ToInt32(array_str[1]) == 0 )
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            if (int.TryParse(array_str[0], out a) == false)
            {
                return false;
            }
            else
            {
                if (int.TryParse(array_str[1], out a) == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
