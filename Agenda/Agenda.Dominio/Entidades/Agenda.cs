using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    class Agenda
    {
        private int _capacidad;
        private List<Contacto> _listaContactos;
        private string _tipo;
        private string _propietario;

        public int Capacidad { get; set; }
        public List<Contacto> ListaDeContactos { get; set; }
        public string Propietario { get; set; }
        public string Tipo { get; set; }

        public Agenda()
        {
        }

        public Agenda(int capacidad, string propietario, string tipo, List<Contacto> contactos)
        {
            this._capacidad = capacidad;
            this._propietario = propietario;
            this._tipo = tipo;
            this._listaContactos = contactos;
        }

        public void AgregarContacto(List<Contacto> listaDeContactos)
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
            listaDeContactos.Add(nuevo);
        }


    }
}
