using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.cinema
{
    class Taquillero : persona
    {
        private int _numeroEmpleado;
        private string _tipo;

        public Taquillero() : base()
        {
            _numeroEmpleado = 100;
        }
        public int NumeroEmpleado { get; set; }
        public string Tipo { get; set; }
    }
}
