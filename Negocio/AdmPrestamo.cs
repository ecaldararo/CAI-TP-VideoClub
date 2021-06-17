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

        public List<Prestamo> TraerPrestamos()
        {
            return _prestamoMapper.TraerTodos();
        }


    }
}
