﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.cinema
{
    class Cliente : persona
    {
        private string _celular;

        public Cliente() : base()
        {
            _celular = "4181102345"
        }
        public string Celular
        {
            get
            {
                return _celular;
            }
            set
            {
                _celular = value;
            }
        }
    }
}
