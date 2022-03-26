using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine().ToUpper();
            string[] usuarios = new string[5];

            usuarios[0] = "PATRICIO";
            usuarios[1] = "EMILIA";
            usuarios[2] = "JUANA";
            usuarios[3] = "MARTIN";
            usuarios[4] = "ALEJANDRA";
            int a = 0;

            foreach(var i in usuarios)
            {
                if(nombre == i)
                {
                    Console.WriteLine("¡Hola " + nombre + "!");
                    a = 1;
                }                
            }

            if(a == 0)
            {
                Console.WriteLine("No te conozco");
            }

            Console.ReadKey();
        }
    }
}
