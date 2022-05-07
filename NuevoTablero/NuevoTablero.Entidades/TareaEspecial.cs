using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoTablero.Entidades
{
    public class TareaEspecial : Tarea
    {
        private DateTime _fechaLimite;
        public TareaEspecial(int codigo, string desc, string estado, int orden, DateTime date, DateTime limite)
            : base(codigo, desc, estado, orden, date)
        {
            _tipo = "Especial";
            _fechaLimite = limite;
        }

        public DateTime FechaLimite
        {
            get => _fechaLimite;
        }
    }
}
