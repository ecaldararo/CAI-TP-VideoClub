using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        //idCliente integer($int32)
        //idCopia integer($int32)
        //plazo integer($int32)
        //abierto boolean
        //fechaPrestamo string ($date-time)
        //fechaDevolucionTentativa string ($date-time)
        //fechaDevolucionReal string ($date-time)
        //id integer($int32)

        private int idCliente;
        private int idCopia;
        private int plazo;
        private bool abierto;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucionTentativa;
        private DateTime fechaDevolucionReal;
        private int id;




    }
}
