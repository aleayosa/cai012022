using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Entidades
{
    public class Contacto
    {
        public static int id = 1;
        private string _nombre;
        private string _direccion;
        private int _telefono;
        private DateTime _fechaNacimiento;
        private string _mail;


        public Contacto()
        {
        }

        public Contacto(string nombre, string direccion, int telefono, DateTime cumple, string mail)
        {
            id++;
            this._nombre = nombre;
            this._direccion = direccion;
            this._telefono = telefono;
            this._fechaNacimiento = cumple;
            this._mail = mail;

        }

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Mail { get; set; }
        public int Id { get; }

        public static int Edad(Contacto con)
        {
            int edad = (DateTime.Now - con._fechaNacimiento).Days / 365;
            return edad;
        }

        public void Mostrar(Contacto con)
        {
            Console.WriteLine("Nombre: " + con._nombre + "\n Direccion: " + con._direccion + "\n Teléfono: " + con._telefono + "\n Mail: " + con._mail);
        }


    }
}
