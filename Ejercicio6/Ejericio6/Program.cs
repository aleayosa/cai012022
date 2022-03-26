using System;

namespace Ejericio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = (num1 + num2)*(num1 - num2);

            Console.WriteLine("El resultado es: " + resultado);

        }
    }
}
