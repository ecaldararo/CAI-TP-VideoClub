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
        public int id;
        private int _idCliente;
        private string _estado;
        private DateTime _fechaAlta;
        private string _direccion;

        public Cliente()
        {
            // Cliente sin parámetros para hacer el post?
        }

        public Cliente(int dni, string nombre, string apellido, DateTime fechaNac)
        {
            //id += 1;
            Id = id;
            IdCliente = id;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            _estado = "Activo";
            _fechaAlta = DateTime.Now;
            FechaNacimiento = fechaNac;
        }

        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }

        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        
        [DataMember(Name = "direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }
        

        public override string ToString()
        {
            return $"{Id})  {Apellido}, {Nombre} (DNI:{Dni}) - Estado: {_estado} - Fecha Alta: {_fechaAlta}";
        }
    }
}
