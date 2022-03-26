using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
   class Contacto
    {
        public static int id=1;
        private string nombre;
        private string direccion;
        private int telefono;
        private DateTime fechaNacimiento;
        private string mail;
    

        public Contacto() { 
        }

        public Contacto(string nombre, string direccion, int telefono, DateTime cumple, string mail)
        {
            id++;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaNacimiento = cumple;
            this.mail = mail;

        }

        public string Nombre{ get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Mail { get; set; }
        public int Id { get; }

        public static int Edad(Contacto con)
        {            
            int edad = (DateTime.Now - con.fechaNacimiento).Days/365;
            return edad;
        }

        public void Mostrar(Contacto con)
        {
            Console.WriteLine("Nombre: " + con.nombre+"\n Direccion: " + con.direccion + "\n Teléfono: " + con.telefono + "\n Mail: "+con.mail);
        }

        
    }
}
