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
        public int _id;
        private int _idCliente;
        private string _estado;
        private DateTime _fechaAlta;
        private bool _activo;

        private string _email;

        public Cliente()
        {
            // Cliente sin parámetros para hacer el post?
        }

        public Cliente(int dni, string nombre, string apellido, string dir, DateTime fechaNac)
        {
            //id += 1;
            Id = _id;
            _idCliente = _id;
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = dir;
            _estado = "Activo";
            _fechaAlta = DateTime.Now;
            _fechaNacimiento = fechaNac;
        }

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        [DataMember(Name = "idCliente")]
        public int IdCliente { get => _idCliente;  }
        
        [DataMember(Name = "direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }
        
        [DataMember(Name = "activo")]
        public bool Activo { get => _activo; set => _activo = value; }

        [DataMember(Name = "DNI")]
        public int Dni { get => _dni; set => _dni = value; }

        [DataMember(Name = "nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember(Name = "apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember(Name = "fechaNacimiento")]
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public override string ToString()
        {
            string activo = "Inactivo";
            if (_activo == true)
                activo = "Activo";

            return $"Id:{Id})  {Apellido}, {Nombre} (DNI:{Dni}) - Nac: {FechaNacimiento.ToString("yyyy-MM-dd")} - Fecha Alta: {_fechaAlta.ToString("yyyy-MM-dd")} - Estado: {activo}";
        }

        public string DescripcionCombo
        {
            get => $"Id:{Id})  {Apellido}, {Nombre}";
        }
        public string Email { get => _email; set => _email = value; }
    }
}
