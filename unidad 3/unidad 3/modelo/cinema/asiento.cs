using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.cinema
{
    class asiento
    {
        private int _numero;
        private bool _estaDisponible;

        public asiento()
        {
            _numero = 10;
        }
        public int Numero { get; set; }
        public string EstaDisponible { get; set; }

    }
}
