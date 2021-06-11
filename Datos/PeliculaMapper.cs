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
        private List<Copia> _copias;
        public PeliculaMapper()
        {
            _peliculas = new List<Pelicula>();
            _copias = new List<Copia>();
        }

        public List<Pelicula> TraerTodos()
        {
            string json2 = WebHelper.Get("/videoclub/pelicula");

            List<Pelicula> peliculas = MappearLista(json2);

            return peliculas;
        }

        public List<Copia> TraerCopias()
        {
            string json2 = WebHelper.Get("/videoclub/copia");

            List<Copia> copias = MappearListaCopias(json2);

            return copias;
        }

        public TransactionResult InsertarCopia(Copia copia)
        {
            NameValueCollection obj = ReverseMapCopia(copia);

            string json = WebHelper.Post("/videoclub/copia", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private List<Pelicula> MappearLista(string json)
        {
            List<Pelicula> resultado = JsonConvert.DeserializeObject<List<Pelicula>>(json);
            return resultado;
        }

        private List<Copia> MappearListaCopias(string json)
        {
            List<Copia> resultado = JsonConvert.DeserializeObject<List<Copia>>(json);
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

        private NameValueCollection ReverseMapCopia(Copia copia)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", copia.Id.ToString());
            n.Add("idPelicula", copia.IdPelicula.ToString());
            n.Add("observaciones", copia.Observaciones);
            n.Add("fechaAlta", "2020-01-01" ); //copia.FechaAlta.ToString("yyyy-MM-dd")
            n.Add("precio", "100" );//copia.Precio.ToString()
            return n;
        }
    }
}
