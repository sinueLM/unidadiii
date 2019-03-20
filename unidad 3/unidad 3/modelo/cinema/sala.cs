using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.cinema
{
    class sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estaLLena;

        private asiento[] asientos = new asiento[200];
        

        public sala()
        {
            _nombre = "A";
            for (int i=0; i <=199; i++)
            {
                asientos[i] = new asiento();
                asientos[i].Numero = i + 1;
            }
        }
        public int Capacidad { get; set; }

    }
}
