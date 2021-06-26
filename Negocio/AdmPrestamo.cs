using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class AdmPrestamo
    {
        private PrestamoMapper _prestamoMapper;
        private AdmPelicula _admPelicula;
        private AdmCliente _admCliente;
        public AdmPrestamo()
        {
            _prestamoMapper = new PrestamoMapper();
            _admCliente = new AdmCliente();
            _admPelicula = new AdmPelicula();

        }

        public void Alta(Prestamo pre)
        {
            _prestamoMapper.Insertar(pre);
        }

        public List<Prestamo> TraerPrestamos()
        {
            List<Prestamo> prestamos = _prestamoMapper.TraerTodos();

            List<Copia> _copias = _admPelicula.TraerCopias();
            List<Cliente> _clientes = _admCliente.TraerTodos();

            prestamos = prestamos.Where(x => x.IdCliente != 0).ToList();

            foreach (Prestamo p in prestamos)
            {
                p.copia = _copias.FirstOrDefault(x => x.Id == p.IdCopia);
                p.cliente = _clientes.FirstOrDefault(x => x.Id == p.IdCliente);
            }

            return prestamos;
        }

        public List<Prestamo> TraerPrestamosAbiertos()
        {
            List<Prestamo> prestamosAbiertos = _prestamoMapper.TraerTodos().Where(x => x.Abierto == true).ToList();

            List<Copia> _copias = _admPelicula.TraerCopias();
            List<Cliente> _clientes = _admCliente.TraerTodos();

            prestamosAbiertos = prestamosAbiertos.Where(x => x.IdCliente != 0).ToList();

            foreach (Prestamo p in prestamosAbiertos)
            {
                p.copia = _copias.FirstOrDefault(x => x.Id == p.IdCopia);
                p.cliente = _clientes.FirstOrDefault(x => x.Id == p.IdCliente);
            }

            return prestamosAbiertos;
        }

        public List<Prestamo> TraerPorId(int id)
        {
            List<Prestamo> prestamos = _prestamoMapper.TraerTodos().Where(x => x.Id == id).ToList();

            return prestamos;
        }

        public List<Prestamo> TraerPorIdPelicula(int idPelicula)
        {
            List<Prestamo> prestamos = _prestamoMapper.TraerTodos();

            List<Copia> _copias = _admPelicula.TraerCopias();
            List<Cliente> _clientes = _admCliente.TraerTodos();

            prestamos = prestamos.Where(x => x.IdCliente != 0).ToList();

            foreach (Prestamo p in prestamos)
            {
                p.copia = _copias.FirstOrDefault(x => x.Id == p.IdCopia);
                p.cliente = _clientes.FirstOrDefault(x => x.Id == p.IdCliente);
            }

            return prestamos.Where(x => x.copia.IdPelicula == idPelicula).ToList();
        }

        public List<Prestamo> TraerPorIdCliente(int idCliente)
        {
            List<Prestamo> prestamos = _prestamoMapper.TraerTodos();

            List<Copia> _copias = _admPelicula.TraerCopias();
            List<Cliente> _clientes = _admCliente.TraerTodos();

            prestamos = prestamos.Where(x => x.IdCliente != 0).ToList();

            foreach (Prestamo p in prestamos)
            {
                p.copia = _copias.FirstOrDefault(x => x.Id == p.IdCopia);
                p.cliente = _clientes.FirstOrDefault(x => x.Id == p.IdCliente);
            }

            return prestamos.Where(x => x.cliente.Id == idCliente).ToList();
        }

        public void RegistrarDevolucion(Prestamo prestamoADevolver)
        {
            
            TransactionResult rdo = _prestamoMapper.Actualizar(prestamoADevolver);

            if (rdo.IsOk == false)
                throw new Exception("Error al registrar la devolucón");
        }
    }
}
