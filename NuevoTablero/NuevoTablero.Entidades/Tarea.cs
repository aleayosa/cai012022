using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoTablero.Entidades
{
    public abstract class Tarea
    {
        protected int _codigo;
        protected string _descripcion;
        protected string _estado;
        protected int _orden;
        protected DateTime _fechaAlta;
        protected DateTime _fechaRealizacion;
        protected string _tipo;

        public Tarea(int codigo, string desc, string estado, int orden, DateTime date)
        {
            this._codigo = codigo;
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
        public string Tipo
        {
            get => _tipo;
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
            bool final = false;
            if (FechaAlta < FechaRealizacion)
            {
                final = true;
            }
            return final;
        }
    }


}
