using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoTablero.Entidades
{
    public class TareaComun : Tarea
    {
        private string _responsable;

        public TareaComun(int codigo, string desc, string estado, int orden, DateTime date, string responsable)
            : base(codigo, desc, estado, orden, date)
        {
            _tipo = "Comun";
            _responsable = responsable;
        }

        public string Responsable
        {
            get => _responsable;
        }
        
    }
}