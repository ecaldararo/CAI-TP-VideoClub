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
        public AdmPrestamo()
        {
            _prestamoMapper = new PrestamoMapper();
        }

        public void Alta(Prestamo pre)
        {
            _prestamoMapper.Insertar(pre);
        }

        public List<Prestamo> TraerPrestamos()
        {
            return _prestamoMapper.TraerTodos();
        }

        public List<Prestamo> TraerPrestamosAbiertos()
        {
            List<Prestamo> prestamosAbiertos = _prestamoMapper.TraerTodos().Where(x => x.Abierto == true).ToList();

            return prestamosAbiertos;
        }

        public List<Prestamo> TraerPorId(int id)
        {
            List<Prestamo> prestamos = _prestamoMapper.TraerTodos().Where(x => x.Id == id).ToList();

            return prestamos;
        }

        public List<Prestamo> TraerPorTitulo(int idPelicula)
        {
            List<Prestamo> prestamos = _prestamoMapper.TraerTodos().Where(x => x.copia.IdPelicula == idPelicula).ToList();

            return prestamos;
        }

        public void RegistrarDevolucion(Prestamo prestamoADevolver)
        {
            
            TransactionResult rdo = _prestamoMapper.Actualizar(prestamoADevolver);

            if (rdo.IsOk == false)
                throw new Exception("Error al registrar la devolucón");
        }
    }
}
