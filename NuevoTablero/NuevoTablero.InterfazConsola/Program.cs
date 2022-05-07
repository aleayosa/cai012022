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
            //. Se debe poder preguntar si una tarea está finalizada LISTO
            //. Se debe poder Consultar la tarea más antigua. LISTO
            //. Se debe poder cambiar el estado de una tarea. LISTO

            //Extra: divididas en tareas comunes y tareas especiales LISTO

            Tablero tab = new Tablero("Cocina nueva", "Listado de cosas que necesito para hacer una nueva cocina", DateTime.Now);
            try
            {

                MenuPrincipal(tab);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void MenuPrincipal(Tablero tab)
        {
            Console.WriteLine("¿Qué desea hacer?" +
                "\n1) Ver el listado de Tareas" +
                "\n2) Agregar una tarea" +
                "\n3) Buscar una tarea" +
                "\n4) Cambiar Estado" +
                "\n5) Tarea finalizada" +
                "\n6) Tarea más antigua");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    tab.MostrarListado(tab.Tareas);
                    Console.ReadKey();
                    MenuPrincipal(tab);
                    break;
                case 2:
                    AgregarTarea(tab);
                    MenuPrincipal(tab);
                    break;
                case 3:
                    BuscadorTarea(tab);
                    MenuPrincipal(tab);
                    break;
                case 4:
                    ModificarTarea(tab);
                    MenuPrincipal(tab);
                    break;
                case 5:
                    MostrarEstado(tab);
                    MenuPrincipal(tab);
                    break;
                case 6:
                    MostrarUltimo(tab);
                    MenuPrincipal(tab);
                    break;
                default:
                    break;
            }

        }
        public static void AgregarTarea(Tablero tab)
        {
            Console.Clear();


            Console.WriteLine("Ingrese la descripcion de la tarea");
            string desc = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese el estado");
            string est = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese el numero de orden");
            int ord = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de alta");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("¿Qué tipo de tarea es? 1) Especial 2) Comun");
            int tipo = int.Parse(Console.ReadLine());
            if (tipo == 2)
            {
                string resp = Console.ReadLine().ToUpper();
                Console.WriteLine("Ingrese el responsable");
                tab.AgregarTareaComun(desc, est, ord, fecha, resp);
            }
            else
            {
                Console.WriteLine("Ingrese la fecha límite");
                DateTime lim = DateTime.Parse(Console.ReadLine());
                tab.AgregarTareaEspecial(desc, est, ord, fecha, lim);
            }
                        
            Console.Clear();
            tab.MostrarListado(tab.Tareas);
            Console.ReadKey();
        }
        public static void BuscadorTarea(Tablero tab)
        {
            Console.Clear();
            Console.WriteLine("Ingrese una referencia para buscar la tarea");
            string palabra = Console.ReadLine().ToUpper();
            tab.MostrarListado(tab.TraerTareas(palabra));
            Console.ReadKey();
        }
        public static void ModificarTarea(Tablero tab)
        {
            Console.Clear();
            tab.MostrarListado(tab.Tareas);
            Console.WriteLine("¿Qué tarea desea modificar?");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuál es el nuevo estado?");
            string nuevo = Console.ReadLine().ToUpper();
            tab.CambiarEstado(cod, nuevo);
            tab.MostrarTarea(cod);
            Console.ReadKey();
        }
        public static void MostrarEstado(Tablero tab)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el código de la tarea");
            int cod = int.Parse(Console.ReadLine());

            tab.PreguntarFinalizacion(cod);

            Console.ReadKey();
        }
        public static void MostrarUltimo(Tablero tab)
        {
            Console.Clear();

            Tarea r = tab.MostrarUltimo();
            tab.MostrarTarea(r.Codigo);
            Console.ReadKey();
        }
    }
}
