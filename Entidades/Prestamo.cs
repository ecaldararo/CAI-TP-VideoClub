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

        //private int idCliente;
        //private int idCopia;

        public Copia copia;
        public Cliente cliente;

        private int idCopia;
        private int idCliente;

        private int plazo;
        private bool abierto;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucionTentativa;
        private DateTime fechaDevolucionReal;
        private int id;

        public Prestamo()
        {
            copia = new Copia();
            cliente = new Cliente();
        }

        public int Plazo { get => plazo; set => plazo = value; }
        public bool Abierto { get => abierto; set => abierto = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucionTentativa { get => fechaDevolucionTentativa; set => fechaDevolucionTentativa = value; }
        public DateTime FechaDevolucionReal { get => fechaDevolucionReal; set => fechaDevolucionReal = value; }
        public int Id { get => id; set => id = value; }
        public int IdCopia { get => idCopia; set => idCopia = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }

        public override string ToString()
        {
            string estado;
            estado = "Cerrado";
            if (Abierto == true)
                estado = "Abierto";

            return $"ID{Id}) - Plazo:{Plazo} - Estado:{estado} - Fecha del Préstamo:{FechaPrestamo.ToString("yyyy-MM-dd")}";
        }
    }
}
