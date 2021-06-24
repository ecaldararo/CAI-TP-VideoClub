using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pelicula
    {

        //anio integer($int32)
        //duracion integer($int32)
        //titulo string
        //nullable: true
        //director string
        //nullable: true
        //productora string
        //nullable: true
        //genero string
        //nullable: true
        //id integer($int32)

        private int anio;
        private int duracion;
        private string titulo;
        //nullable: true
        private string director;
        //nullable: true
        private string productora;
        //nullable: true
        private string genero;
        //nullable: true
        private int id;
        public List<Copia> copias;

        public Pelicula()
        {
            copias = new List<Copia>();
        }

        public int Anio { get => anio; set => anio = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Director { get => director; set => director = value; }
        public string Productora { get => productora; set => productora = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"ID:{Id} \tTítulo:{Titulo}Año:{Anio}-Duración: {Duracion}-Cantidad de Copias:{copias.Count()}";
        }

        public string DescripcionCombo
        {
            get => $"ID:{Id} \tTítulo:{Titulo}-Cantidad de Copias:{copias.Count}";
            
            //mostrar copias disponibles (del listado de prestamos, aquellas cuya copia.idPelicula = this.id y de ese listado, filtrar las abiertas, para restarlas en count totales).
        }

        
    }
}
