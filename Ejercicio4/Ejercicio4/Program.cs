using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra1 = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese otra palabra");
            string palabra2 = Console.ReadLine().ToLower();
            int i = palabra2.Length;
            int letra = i - 1;
            string reversa = "";

            if (palabra1.Length != i)
            {
                Console.WriteLine("No son Anagramas");
            }
            else
            {                
                while (letra >= 0)
                {
                    reversa += palabra2[letra];
                    letra--;
                }
                if(reversa == palabra1)
                {
                    Console.WriteLine("Son anagramas");
                }
                else
                {
                    Console.WriteLine("No son anagramas");
                }
            }
            Console.ReadKey();
        }
    }
}
