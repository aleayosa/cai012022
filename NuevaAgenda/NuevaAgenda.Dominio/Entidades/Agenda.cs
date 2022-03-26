using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevaAgenda.Dominio.Entidades
{
    public class Agenda
    {
        private int _capacidad;
        private List<Contacto> _listaContactos;
        private string _tipo;
        private string _propietario;

        public int Capacidad
        {
            get => _capacidad;
        }
        public List<Contacto> ListaDeContactos
        {
            get => _listaContactos;
        }
        public string Propietario
        {
            get => _propietario;
        }
        public string Tipo
        {
            get => _tipo;
        }

        public Agenda()
        {
        }
        public Agenda(int capacidad, string propietario, string tipo)
        {
            this._capacidad = capacidad;
            this._propietario = propietario;
            this._tipo = tipo;
            this._listaContactos = new List<Contacto>();
        }
        public int CantidadContactos()
        {
            return _listaContactos.Count;
        }
        public void AgregarContacto(Contacto nuevo)
        {
            if (CantidadContactos() < _capacidad)
            {
                _listaContactos.Add(nuevo);
            }
            else
            {
                Console.WriteLine("No se ha agergador el contacto porque superó la capacidad de almacenamiento");
            }
        }
        public void EliminarContacto(int id)
        {
            _listaContactos.Remove(_listaContactos[id - 1]);
        }

    }
}
