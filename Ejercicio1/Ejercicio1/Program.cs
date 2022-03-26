using System;

namespace Ejercicio1
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

            for (var i = 0; i <= registro; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " - FooBar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - Foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " - Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
