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
        private Pelicula _pelicula;
        public AdmPelicula()
        {
            _peliculaMapper = new PeliculaMapper();
        }

        public void Alta(Pelicula pel)
        {
            _peliculaMapper.Insertar(pel);
        }

        public int AgregarCopia(Copia nuevaCopia)
        {
            TransactionResult rdo =_peliculaMapper.InsertarCopia(nuevaCopia);

            if (rdo.IsOk == true)
            {
                return 1;
            } else
            {
                return 0;
            }
            

        }

        //public void AgregarCopias(List<Copia> copias,int cantidad)
        //{
        //    if (_peliculaMapper.InsertarCopias(copias).IsOk == false)
        //    {
        //        throw new Exception("Error al agregar copia");
        //    }
        //}

        public List<Pelicula> TraerPeliculas()
        {
            return _peliculaMapper.TraerTodos();
        }

        public List<Copia> TraerCopias()
        {
            return _peliculaMapper.TraerCopias();
        }

        public TransactionResult Eliminar(Pelicula peliculaSeleccionado)
        {
            throw new NotImplementedException();
        }

        public object TraerTodosOrdenadosPorId()
        {
            throw new NotImplementedException();
        }

        public object TraerPorGenero(string text)
        {
            throw new NotImplementedException();
        }

        public object TraerPorTitulo(string text)
        {
            throw new NotImplementedException();
        }

        

        public object TraerPorCodigo(int v)
        {
            throw new NotImplementedException();
        }
    }
}
