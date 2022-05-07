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
        private int _ultimaTarea;

        public Tablero(string titulo, string descr, DateTime fecha)
        {
            _ultimaTarea = 0;
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
        private int AsignarCodigoTarea()
        {
            _ultimaTarea++;
            return _ultimaTarea;
        }
        public void AgregarTareaComun(string desc, string estado, int orden, DateTime date, string resp)
        {
            TareaComun nueva = new TareaComun(AsignarCodigoTarea(), desc, estado, orden, date, resp);
            _tareas.Add(nueva);
        }
        public void AgregarTareaEspecial(string desc, string estado, int orden, DateTime date, DateTime resp)
        {
            TareaEspecial nueva = new TareaEspecial(AsignarCodigoTarea(), desc, estado, orden, date, resp);
            _tareas.Add(nueva);
        }

        public void CambiarEstado(int n, string e)
        {
            Tarea t = _tareas[n - 1];
            t.CambiarEstado(e);
            if (e == "FINALIZADO")
            {
                Console.WriteLine("Ingrese la fecha de realizacion");
                DateTime date = DateTime.Parse(Console.ReadLine());
                t.CambiarFechaRealizacion(date);
            }
            Console.Clear();
            Console.WriteLine("El estado fue modificado.");
        }

        public void MostrarListado(List<Tarea> listado)
        {
            if (listado != null)
            {
                foreach (var i in listado)
                {
                    Console.WriteLine("Tarea " + i.Codigo + ":\nDescripcion: " + i.Descripcion + "\nEstado: " + i.Estado + "\nOrden: " + i.Orden + "\nFecha de Alta: " + i.FechaAlta + "\nFecha de Realizacion: " + i.FechaRealizacion + "\nTipo de tarea: "  + i.Tipo);
                    if(i.Tipo == "Comun")
                    {
                        TareaComun a = (TareaComun)i;
                        Console.WriteLine("Responsable: " + a.Responsable+ "\n\n\n");
                    }
                    else
                    {
                        TareaEspecial b = (TareaEspecial)i;
                        Console.WriteLine("Fecha Limite: " + b.FechaLimite+ "\n\n\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontró tarea");
            }

        }

        public List<Tarea> TraerTareas(string palabra)
        {
            List<Tarea> listado = new List<Tarea>();
            foreach (var i in _tareas)
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
            Tarea i = _tareas[cod - 1];
            Console.WriteLine("Tarea " + i.Codigo + ":\nDescripcion: " + i.Descripcion + "\nEstado: " + i.Estado + "\nOrden: " + i.Orden + "\nFecha de Alta: " + i.FechaAlta + "\nFecha de Realizacion: " + i.FechaRealizacion + "\nTipo de tarea: " + i.Tipo);
            if (i.Tipo == "Comun")
            {
                TareaComun a = (TareaComun)i;
                Console.WriteLine("Responsable: " + a.Responsable + "\n\n\n");
            }
            else
            {
                TareaEspecial b = (TareaEspecial)i;
                Console.WriteLine("Fecha Limite: " + b.FechaLimite + "\n\n\n");
            }
        }

        public Tarea MostrarUltimo()
        {
            Tarea t = _tareas.OrderBy(d => d.FechaAlta).FirstOrDefault();
            return t;
        }
        public void PreguntarFinalizacion(int cod)
        {
            Tarea i = _tareas[cod - 1];
            if (i.IsFinalizada())
                Console.WriteLine("La tarea se encuentra finalizada");
            else
                Console.WriteLine("La tarea aún no finalizó");
        }
    }
}
