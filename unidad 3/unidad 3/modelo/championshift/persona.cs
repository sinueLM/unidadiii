using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.championshift
{
    class persona
    {
        //propiedad de la clase 
        protected int id;
        protected string nombre;
        protected string apellidos;
        protected DateTime fechaNacimiento;

        //metodo getter´s  y setter´s
        public int _Id { get; set; }
        public string Nombre { get; set; } 
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }


    }
}
