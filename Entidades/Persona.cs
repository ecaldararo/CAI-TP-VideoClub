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
        protected int _dni;
        protected string _nombre;
        protected string _apellido;
        protected string _direccion;
        protected DateTime _fechaNacimiento;

        //[DataMember(Name = "DNI")]
        //protected int Dni { get => _dni; set => _dni = value; }

        //[DataMember(Name = "nombre")]
        //protected string Nombre { get => _nombre; set => _nombre = value; }

        //[DataMember(Name = "apellido")]
        //protected string Apellido { get => _apellido; set => _apellido = value; }

        //[DataMember(Name = "fechaNacimiento")]
        //protected DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
    }
}
