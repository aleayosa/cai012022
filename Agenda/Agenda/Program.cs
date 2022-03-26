using System;
using System.Collections.Generic;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda ag = new Agenda();
            MenuPrincipal(ag);
        }
        public static void MenuPrincipal(Agenda ag)
        {
            Console.WriteLine("Ingrese una opción:\n 1) Generar una Agenda.\n 2) Visualizar una Agenda Existente.");
            int opcion = int.Parse(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    MenuNueva();
                    MenuPrincipal(ag);
                    break;
                case 2:
                    Console.Clear();
                    MenuAgenda(ag);
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
            List<Contacto> contactos = new List<Contacto>();
            Agenda ag = new Agenda(cap, prop, tipo, contactos);            
        }
        public static void MenuAgenda(Agenda ag)
        {
            Console.WriteLine("¡Bienvenido "+ag.Propietario+" a tu agenda electrónica!\n\n¿Qué deseas hacer?\n1) Ver la Lista de Contactos\n2) Buscar un contacto\n3) Agregar un contacto\n4) Eliminar un contacto\n5) Salir");
            int opcion= int.Parse(Console.ReadLine());

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
                    ag.AgregarContacto(ag.ListaDeContactos);
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
    }
}
