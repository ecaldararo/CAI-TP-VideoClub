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

            if (_clientes == null)
                throw new Exception("No hay clientes.");

            return _clientes;

        }
        public List<Cliente> TraerTodosOrdenadosPorId()
        {
            //_clientes = TraerTodos(); // Consulta al servidor al cargar el formulario, y lo guarda y trabaja sobre ese.

            List<Cliente> clientesOrdenadosPorId = new List<Cliente>();

            clientesOrdenadosPorId = _clientes.OrderByDescending(x => x.Id).ToList();

            return clientesOrdenadosPorId;

        }
        public List<Cliente> TraerPorDNI(int dni)
        {
            //_clientes = _clientMapper.TraerTodos(); // Consulta al servidor al cargar el formulario, y lo guarda y trabaja sobre ese.

            List<Cliente> _clientesFiltrados = new List<Cliente>();

            if (_clientes.Count() > 0)
            {
                _clientesFiltrados.AddRange(_clientes.Where(x => x.Dni == dni));
            }
            else
                throw new Exception("No hay clientes.");

            return _clientesFiltrados;

        }

        public List<Cliente> TraerPorApellido(string apellido)
        {
            // _clientes = _clientMapper.TraerTodos(); // Consulta al servidor al cargar el formulario, y lo guarda y trabaja sobre ese.

            List<Cliente> _clientesFiltrados = new List<Cliente>();

            if (_clientes.Count() > 0)
            {
                _clientesFiltrados.AddRange(_clientes.Where(x => x.Apellido == apellido));
            }
            else
                throw new Exception("No hay clientes.");

            return _clientesFiltrados;

        }

        public TransactionResult Agregar(int dni,string nombre, string apellido,string direccion, DateTime fechaNac, bool activo)
        {
            Cliente nuevoCliente = new Cliente(dni,nombre,apellido,direccion,fechaNac);
            //nuevoCliente.Dni = dni;
            //nuevoCliente.Nombre = nombre;
            //nuevoCliente.Apellido = apellido;   
            //nuevoCliente.Direccion = direccion;
            //nuevoCliente.FechaNacimiento = fechaNac;
            nuevoCliente.Activo = activo;

            return _clientMapper.Insertar(nuevoCliente);
        }

        public TransactionResult Modificar(Cliente clienteAModificar)
        {
            return _clientMapper.Actualizar(clienteAModificar);
        }

        public object TraerPorNombre(string nombre)
        {
            _clientes = _clientMapper.TraerTodos();

            List<Cliente> _clientesFiltrados = new List<Cliente>();

            if (_clientes.Count() > 0)
            {
                _clientesFiltrados.AddRange(_clientes.Where(x => x.Nombre == nombre));
            }
            else
                throw new Exception("No hay clientes.");

            return _clientesFiltrados;
        }

        public TransactionResult Eliminar(Cliente clienteSeleccionado)
        {
            return _clientMapper.Eliminar(clienteSeleccionado);
        }
    }
}
