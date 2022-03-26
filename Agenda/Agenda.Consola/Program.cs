using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Dominio.Entidades;


namespace Agenda.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaContactos ag = new AgendaContactos();
            AgregarContactos(ag);
        }
        public static void MenuPrincipal()
        {
            Console.WriteLine("Ingrese una opción:\n 1) Generar una Agenda.\n 2) Visualizar una Agenda Existente.");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    MenuNueva();
                    MenuPrincipal();
                    break;
                case 2:
                    Console.Clear();
                    MenuAgenda();
                    break;
                default:
                    Console.WriteLine("Opcion Inválida");
                    Console.ReadKey();
                    break;
            }
        }
        public static void MenuNueva()
        {
            Console.WriteLine("Ingrese la capacidad que debe tener la agenda");
            int cap = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del propietario de la agenda");
            string prop = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese el tipo de Agenda: 'Digital', 'Cuaderno' o 'Rolodex");
            string tipo = Console.ReadLine();
            AgendaContactos ag = new AgendaContactos(cap, prop, tipo);
        }
        public static void MenuAgenda()
        {
            Console.WriteLine("¡Bienvenido a tu agenda electrónica!\n\n¿Qué deseas hacer?\n1) Ver la Lista de Contactos\n2) Buscar un contacto\n3) Agregar un contacto\n4) Eliminar un contacto\n5) Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    AgregarContactos();
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Opcion Inválida");
                    Console.ReadKey();
                    break;
            }
        }
    
        public static void AgregarContactos(AgendaContactos ag)
        {
            bool seguir=true;
            do
            {
                Console.WriteLine("Ingrese el nombre del contacto");
                string nombre = Console.ReadLine().ToUpper();
                Console.WriteLine("Ingrese la direccion del contacto");
                string direccion = Console.ReadLine().ToUpper();
                Console.WriteLine("Ingrese el teléfono del contacto");
                int telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el correo electrónico del contacto");
                string mail = Console.ReadLine().ToUpper();
                Console.WriteLine("Ingrese la fecha de nacimiento del contacto");
                DateTime cumple = DateTime.Parse(Console.ReadLine());
                Contacto nuevo = new Contacto(nombre, direccion, telefono, cumple, mail);
                ag.AgregarContacto(nuevo);

                Console.WriteLine("¿Desea agregar otro contacto?");
                int opcion = int.Parse(Console.ReadLine());
                if(opcion == 2)
                {
                    seguir = false;
                }

            } while(seguir);            
        }
    }
}
