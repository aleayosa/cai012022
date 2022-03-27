using NuevoTablero.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoTablero.InterfazConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            //Se desea hacer un Tablero de tareas donde:
            //. Se debe poder dar de alta una tarea. LISTO
            //. El tablero asigna el codigo de tarea de forma correlativa autómaticamente. LISTO
            //. Se debe poder traer las tareas por estado (si el estado es null or empty trae todos) en base al orden.
            //. Se debe poder preguntar si una tarea está finalizada
            //. Se debe poder Consultar la tarea más antigua.
            //. Se debe poder cambiar el estado de una tarea. LISTO

            //Extra: divididas en tareas comunes y tareas especiales

            Tablero tab = new Tablero("Cocina nueva", "Listado de cosas que necesito para hacer una nueva cocina", DateTime.Now);
            Tarea tar1 = new Tarea(1, "Comprar mesada", "Pendiente", 1);
            tab.AgregarTarea(tar1);
            Tarea tar2 = new Tarea(2, "Comprar bajomesada y altomesada", "Pendiente", 2);
            tab.AgregarTarea(tar2);
            Tarea tar3 = new Tarea(3, "Comprar griferia", "Pendiente", 3);
            tab.AgregarTarea(tar3);
            Tarea tar4 = new Tarea(4, "Comprar azulejos", "Pendiente", 4);
            tab.AgregarTarea(tar4);

            Console.WriteLine("¿Qué desea hacer?\n1) Ver el listado de Tareas\n2) Agregar una tarea\n3) Buscar una tarea\n4) Cambiar Estado");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tab.MostrarListado(tab.Tareas);
                    Console.ReadKey();
                    break;
                case 2:
                    int codi = tab.Tareas.Count() + 1;
                    Console.WriteLine("Ingrese la descripcion de la tarea");
                    string desc = Console.ReadLine();
                    Console.WriteLine("Ingrese el estado");
                    string est = Console.ReadLine();
                    Console.WriteLine("Ingrese el numero de orden");
                    int ord = int.Parse(Console.ReadLine());
                    Tarea nueva = new Tarea(codi, desc, est, ord);

                    tab.AgregarTarea(nueva);

                    Console.Clear();
                    tab.MostrarListado(tab.Tareas);
                    Console.ReadKey();

                    break;
                case 3:
                    Console.WriteLine("Ingrese una referencia para buscar la tarea");
                    string palabra = Console.ReadLine();

                    tab.MostrarListado(tab.TraerTareas(palabra));
                    Console.ReadKey();
                    break;
                case 4:                    
                    tab.MostrarListado(tab.Tareas);
                    Console.WriteLine("¿Qué tarea desea modificar?");
                    int cod = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿Cuál es el nuevo estado?");
                    string nuevo = Console.ReadLine();
                    tab.CambiarEstado(cod, nuevo);
                    tab.MostrarTarea(cod);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
