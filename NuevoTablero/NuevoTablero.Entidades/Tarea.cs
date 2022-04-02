using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoTablero.Entidades
{
    public class Tarea
    {
        private static int contador = 0;
        private int _codigo;
        private string _descripcion;
        private string _estado;
        private int _orden;
        private DateTime _fechaAlta;
        private DateTime _fechaRealizacion;

        public Tarea(string desc, string estado, int orden, DateTime date)
        {
            contador++;
            this._codigo = contador; 
            this._descripcion = desc;
            this._estado = estado;
            this._orden = orden;
            this._fechaAlta = date;
        }
        public int Codigo
        {
            get => _codigo;
        }
        public int Orden
        {
            get => _orden;
        }
        public string Descripcion
        {
            get => _descripcion;
        }
        public string Estado
        {
            get => _estado;
        }
        public DateTime FechaAlta
        {
            get => _fechaAlta;
        }
        public DateTime FechaRealizacion
        {
            get => _fechaRealizacion;
        }
        public void CambiarEstado(string e)
        {
            _estado = e;            
        }
        public void CambiarFechaRealizacion(DateTime d)
        {
            _fechaRealizacion = d;
        }
        public bool IsFinalizada()
        {
            bool final=false;
            if(FechaAlta < FechaRealizacion)
            {
                final = true;
            }
            return final;
        }
    }
}
