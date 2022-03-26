using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un mes");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un dia");
            int dia = int.Parse(Console.ReadLine());

            DateTime fecha = new DateTime(año, mes, dia);
            DateTime hoy = DateTime.Now;

             ;

            Console.WriteLine("La diferencia de fechas es de " + (hoy - fecha).Days/365 + " días.");
        }
    }
}
