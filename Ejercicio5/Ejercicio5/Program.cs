using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de 5 cifras");
            string num = Console.ReadLine();
            int cant = num.Length;
            int digito = cant - 1;

            string nuevoNum = "";

            do
            {
                nuevoNum += num[digito];
                digito--;
            } while (digito >= 0);

            Console.WriteLine("El número inverdito es: " + nuevoNum);
            Console.ReadKey();

        }
    }
}
