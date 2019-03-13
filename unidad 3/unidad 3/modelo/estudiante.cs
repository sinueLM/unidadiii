using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_de_clase.modelo
{
    class estudiante
    {
        //propiedades del la clase
        public string nombre;
        public byte edad;
        public char genero;
        public int numeroControl;
        //metodos getter´s y setter´s de las propiedades

        public string Nombre { get; set; }
        public byte Edad { get; set; }
        public char Genero { get; set; }
        public long NumeroControl { get; set; }

        public void Estudiar(string tema)
        {
            return;
        }
        //public void (string tema)
    }
}
