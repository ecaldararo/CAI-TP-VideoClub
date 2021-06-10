using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class PeliculaMapper
    {
        private List<Pelicula> _peliculas;
        public PeliculaMapper()
        {
            _peliculas = new List<Pelicula>();
        }

        public List<Pelicula> TraerTodos()
        {
            // IR A EL REPOSITORIO DE DATOS (bd, file, webservice)

            string json2 = WebHelper.Get("/videoclub/pelicula");

            List<Pelicula> peliculas = MappearLista(json2);

            return peliculas;
        }

        private List<Pelicula> MappearLista(string json)
        {
            List<Pelicula> resultado = JsonConvert.DeserializeObject<List<Pelicula>>(json);
            return resultado;
        }

        public TransactionResult Insertar(Pelicula nuevoPelicula)
        {
            NameValueCollection obj = ReverseMap(nuevoPelicula);

            string json = WebHelper.Post("/videoclub/pelicula", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        public TransactionResult Actualizar(Pelicula peliculaAModificar)
        {
            NameValueCollection obj = ReverseMapActualizar(peliculaAModificar);

            string json = WebHelper.Put("/videoclub/pelicula/" + peliculaAModificar.Id.ToString(), obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        public TransactionResult Eliminar(Pelicula peliculaSeleccionado)
        {
            NameValueCollection obj = ReverseMap(peliculaSeleccionado);

            string json = WebHelper.Delete("/videoclub/pelicula/" + peliculaSeleccionado.Id, obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Pelicula pelicula)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", pelicula.Id.ToString());
            n.Add("anio", pelicula.Anio.ToString());
            n.Add("duracion", pelicula.Duracion.ToString());
            n.Add("titulo", pelicula.Titulo);
            n.Add("director", pelicula.Director);
            n.Add("productora", pelicula.Productora);
            n.Add("genero", pelicula.Genero);
            return n;
        }

        private NameValueCollection ReverseMapActualizar(Pelicula pelicula)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", pelicula.Id.ToString());
            n.Add("anio", pelicula.Anio.ToString());
            n.Add("duracion", pelicula.Duracion.ToString());
            n.Add("titulo", pelicula.Titulo);
            n.Add("director", pelicula.Director);
            n.Add("productora", pelicula.Productora);
            n.Add("genero", pelicula.Genero);
            return n;
        }
    }
}
