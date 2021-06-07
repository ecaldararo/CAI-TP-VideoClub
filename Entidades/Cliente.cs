using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int _clienteId;
        private string _estado;
        private DateTime _fechaAlta;

        public override string ToString()
        {
            return $"{_clienteId})_{_apellido}, {_nombre}";
        }
    }
}
