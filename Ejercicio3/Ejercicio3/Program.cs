using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine().ToUpper();
            int i = palabra.Length;
            int letra = i - 1;
            string reversa = "";

            while (letra >= 0)
            {
                reversa += palabra[letra];
                letra--;
            }

            if (reversa == palabra)
                Console.WriteLine("Es palíndromo");
            else
                Console.WriteLine("No es palíndromo");

            Console.ReadKey();
        }
    }
}
