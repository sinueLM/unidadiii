using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.championshift
{
    class jugador:persona
    {
        //Atributos
        private int numero;
        private string equipo;
        private string posicion;

        //Enlace con la clase equipo
        
        private equipo _equipe;
        //metodos Getter`s y setter`s
        public int Numero { get; set; }
        public string Equipe { get; set; }
        public string Posicion { get; set; }

    }
}
