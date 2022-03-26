using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            Console.WriteLine("Ingrese el primer numero");
            numeros[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numeros[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            numeros[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero");
            numeros[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto numero");
            numeros[4] = int.Parse(Console.ReadLine());

            int mayor = 0;
            int medio = 0;
            int menor = numeros[0];


            for(var i=0; i < numeros.Length; i++)
            {
                
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
                else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }else if(numeros[i]> menor && numeros[i] < mayor)
                {
                    medio = numeros[i];
                }
            }

            Console.WriteLine("El numero mayor es: " + mayor + "\nEl número menor es: " + menor + "\nEl número intermedio es: " + medio);
            Console.ReadKey();
        }
    }
}
