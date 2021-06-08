using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public abstract class Persona
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        protected string _direccion;

        [DataMember(Name = "DNI")]
        public int Dni { get => _dni; set => _dni = value; }
        [DataMember(Name = "nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember(Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }
    }
}
