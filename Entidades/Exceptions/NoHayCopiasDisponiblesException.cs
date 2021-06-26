using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class NoHayCopiasDisponiblesException : Exception
    {
        public NoHayCopiasDisponiblesException() : base("No hay copias disponibles de la película seleccionada.")
        {

        }
    }
}
