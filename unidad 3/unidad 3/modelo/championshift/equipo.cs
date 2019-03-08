using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.championshift
{
    class equipo
    {
        //propiedad de la clase 
        protected int id;
        protected string nombre;
        protected string entrenador;
        protected DateTime comunidad;

        //Enlace con jugador
        private List<jugador> jugadores = new List<jugador>();
        //metodo getter´s  y setter´s
        public int _Id { get; set; }
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public string Comunidad { get; set; }

    }
}
