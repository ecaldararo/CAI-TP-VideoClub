using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmPelicula
    {
        private PeliculaMapper _peliculaMapper;
        public AdmPelicula()
        {
            _peliculaMapper = new PeliculaMapper();
        }

        public void Alta(Pelicula pel)
        {
            _peliculaMapper.Insertar(pel);
        }
    }
}
