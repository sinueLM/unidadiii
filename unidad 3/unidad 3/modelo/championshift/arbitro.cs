using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.championshift
{
    class arbitro:persona
    {
        //Atributos
        private int aniosExperiencia;
        private bool tieneGafete;

        //metodos Getter`s y setter`s
        public int AniosExperiencia { get; set; }
        public int TieneGafete { get; set; }
    }
}
