using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Cliente : Persona
    {
        private static int id;
        private int _idCliente;
        private string _estado;
        private DateTime _fechaAlta;

        public Cliente(int dni, string nombre, string apellido)
        {
            id += 1;
            _idCliente = id;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            _estado = "Activo";
            _fechaAlta = DateTime.Now;
        }

        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idCliente;  }

        public override string ToString()
        {
            return $"{IdCliente})  {Apellido}, {Nombre} (DNI:{Dni}) - Estado: {_estado} - Fecha Alta: {_fechaAlta}";
        }
    }
}
