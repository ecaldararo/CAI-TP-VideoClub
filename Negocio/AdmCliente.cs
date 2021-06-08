using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class AdmCliente
    {
        private ClientMapper _clientMapper;
        private List<Cliente> _clientes;

        public AdmCliente()
        {
            
            
        }
        public List<Cliente> TraerTodos()
        {
            _clientes = _clientMapper.TraerTodos();
            
            return _clientes;

        }
        public List<Cliente> TraerPorDNI(int dni)
        {
            //_clientes = _clientMapper.TraerTodos();

            if (_clientes.Count() > 0)
                _clientes.Where(x => x.Dni == dni);
            else
                throw new Exception("No hay clientes.");

            return _clientes;

        }
    }
}
