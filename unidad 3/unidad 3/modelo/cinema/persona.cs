using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_3.modelo.cinema
{
    class persona
    {
        protected int _id;
        protected string _nombre;
        protected string _apellidos;
        protected string _domicilio;
        protected string _email;
        protected string _password;

        public persona()
        {
            _nombre = "Juanito";
            _apellidos = "Perez";
        }
        public persona(string nombre, string apellidos)
        {
            _nombre = nombre;
            _apellidos = apellidos;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    _nombre = value;
            }
        }
        public string apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    _apellidos = value;
            }
        }
        public string domicilio
        {
            get
            {
                return _domicilio;
            }
            set
            {
                _domicilio = value;
            }
        }
    }
}
