using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los últimos 3 números de su nro de registro");
            int registro = int.Parse(Console.ReadLine());

            if (registro <= 99)
            {
                registro += 100;
            }

            for (var i = 1; i <= registro; i++)
            {
                if (i % 3 == 0 && Program.EsPrimo(i))
                {
                    Console.WriteLine(i + " Es divisible por 3 y es primo");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Es divisible por 3");
                }
                else if (Program.EsPrimo(i))
                {
                    Console.WriteLine(i + " Es primo");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static bool EsPrimo(int registro)
        {
            int primo = 0;
            int a = 1;

            bool resultado;
            do
            {

                if (registro % a == 0)
                {
                    primo++;
                }
                a++;

            } while (primo == 3 || registro >= a);

            if (primo == 2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }
    }
}
