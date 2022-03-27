using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoTablero.Entidades
{
    public class Tablero
    {
        private string _titulo;
        private string _descripcion;
        private List<Tarea> _tareas;
        private DateTime _fechaInicioProyecto;

        public Tablero(string titulo, string descr, DateTime fecha)
        {
            this._titulo = titulo;
            this._descripcion = descr;
            this._fechaInicioProyecto = fecha;
            this._tareas = new List<Tarea>();
        }

        public string Titulo
        {
            get => _titulo;
        }

        public string Descripcion
        {
            get => _descripcion;
        }

        public List<Tarea> Tareas
        {
            get => _tareas;
        }

        public DateTime FechaInicioProyecto
        {
            get => _fechaInicioProyecto;
        }

        public void AgregarTarea(Tarea t)
        {
            _tareas.Add(t);
        }

        public void CambiarEstado(int n, string e)
        {
            Tarea t = _tareas[n-1];
            t.CambiarEstado(e);
            Console.WriteLine("El estado fue modificado.");
        }

        public void MostrarListado(List<Tarea> listado)
        {
            foreach(var i in listado)
            {
                Console.WriteLine("Tarea "+i.Codigo+":\nDescripcion: "+i.Descripcion+"\nEstado: "+i.Estado+ "\nOrden: " + i.Orden +"\nFecha de Alta: " +i.FechaAlta+"\nFecha de Realizacion: "+i.FechaRealizacion+"\n\n\n");
            }
        }
    
        public List<Tarea> TraerTareas(string palabra)
        {
            List<Tarea> listado = new List<Tarea>();
            foreach(var i in _tareas)
            {
                if (i.Descripcion.Contains(palabra))
                {
                    listado.Add(i);
                }
            }

            return listado;
        }

        public void MostrarTarea(int cod)
        {
            Tarea i = _tareas[cod-1];
            Console.WriteLine("Tarea " + i.Codigo + ":\nDescripcion: " + i.Descripcion + "\nEstado: " + i.Estado + "\nOrden: " + i.Orden + "\nFecha de Alta: " + i.FechaAlta + "\nFecha de Realizacion: " + i.FechaRealizacion + "\n\n\n");
        }
    }
}
