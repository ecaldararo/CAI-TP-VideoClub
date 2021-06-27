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

        private List<Prestamo> _consultaPrestamos;
        public AdmPrestamo()
        {
            _prestamoMapper = new PrestamoMapper();
            _admCliente = new AdmCliente();
            _admPelicula = new AdmPelicula();

            _consultaPrestamos = new List<Prestamo>();

            _consultaPrestamos = TraerPrestamos();

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
            List<Pelicula> _peliculas = _admPelicula.TraerPeliculas();

            prestamos = prestamos.Where(x => x.IdCliente != 0).ToList();

            foreach (Prestamo p in prestamos)
            {
                p.copia = _copias.FirstOrDefault(x => x.Id == p.IdCopia);
                p.cliente = _clientes.FirstOrDefault(x => x.Id == p.IdCliente);
                p.pelicula = _peliculas.FirstOrDefault(x => x.Id == p.copia.IdPelicula);
            }

            return prestamos;
        }

        public List<Prestamo> TraerPrestamosAbiertos()
        {
            List<Prestamo> prestamosAbiertos = _consultaPrestamos.Where(x => x.Abierto == true).ToList();

            return prestamosAbiertos;
        }

        public List<Prestamo> TraerPorId(int id)
        {
            List<Prestamo> prestamos = _consultaPrestamos.Where(x => x.Id == id).ToList();

            return prestamos;
        }

        public List<Prestamo> TraerPorIdPelicula(int idPelicula)
        {
            List<Prestamo> prestamos = _consultaPrestamos;

            return prestamos.Where(x => x.copia.IdPelicula == idPelicula).ToList();
        }

        public List<Prestamo> TraerPorIdCliente(int idCliente)
        {
            List<Prestamo> prestamos = _consultaPrestamos;

            prestamos = prestamos.Where(x => x.IdCliente != 0).ToList();

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
