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
            _clientMapper = new ClientMapper();
            _clientes = new List<Cliente>();
        }
        public List<Cliente> TraerTodos()
        {
            _clientes = _clientMapper.TraerTodos();
            
            return _clientes;

        }
        public List<Cliente> TraerPorDNI(int dni)
        {
            _clientes = _clientMapper.TraerTodos();

            List<Cliente> _clientesFiltrados = new List<Cliente>();

            if (_clientes.Count() > 0)
            {
                _clientesFiltrados.AddRange(_clientes.Where(x => x.Dni == dni));
            }
            else
                throw new Exception("No hay clientes.");

            return _clientesFiltrados;

        }
    }
}
