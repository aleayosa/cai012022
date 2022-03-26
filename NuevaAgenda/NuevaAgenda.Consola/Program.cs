using NuevaAgenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevaAgenda.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda ag = new Agenda(10,"Alejandra", "Digital");
            AgregarContactos(ag);
        }

        public static void AgregarContactos(Agenda ag)
        {
            bool seguir = true;
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
                if (opcion == 2)
                {
                    seguir = false;
                }

            } while (seguir);
        }
    }
}
