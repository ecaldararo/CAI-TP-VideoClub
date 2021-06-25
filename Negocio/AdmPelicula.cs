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
        private List<Pelicula> _peliculas;
        public AdmPelicula()
        {
            _peliculaMapper = new PeliculaMapper();
            _peliculas = new List<Pelicula>();
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

        public List<Pelicula> TraerTodosOrdenadosPorTitulo()
        {
            _peliculas = TraerPeliculas();

            List<Pelicula> _peliculasOrdenadas = new List<Pelicula>();
            
            _peliculasOrdenadas = _peliculas.OrderBy(x => x.Titulo).ToList();

            return _peliculasOrdenadas;

        }

        public List<Pelicula> TraerPorGenero(string text)
        {
            _peliculas = TraerPeliculas();

            List<Pelicula> _peliculasSeleccionadas = new List<Pelicula>();

            _peliculasSeleccionadas = _peliculas.Where(x => x.Genero == text).ToList();

            return _peliculasSeleccionadas;
        }

        public List<Pelicula> TraerPorTitulo(string text)
        {
            _peliculas = TraerPeliculas();

            List<Pelicula> _peliculasSeleccionadas = new List<Pelicula>();

            _peliculasSeleccionadas = _peliculas.Where(x => x.Titulo == text).ToList();

            return _peliculasSeleccionadas;
        }

        public List<Pelicula> TraerPorCodigo(int cod)
        {
            _peliculas = TraerPeliculas();

            List<Pelicula> _peliculasSeleccionadas = new List<Pelicula>();

            _peliculasSeleccionadas = _peliculas.Where(x => x.Id == cod).ToList();

            return _peliculasSeleccionadas;
        }
    }
}
