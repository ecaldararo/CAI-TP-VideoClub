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
    public class PrestamoMapper
    {
        private List<Prestamo> _prestamos;
        public PrestamoMapper()
        {
            _prestamos = new List<Prestamo>();
        }

        public List<Prestamo> TraerTodos()
        {
            string json2 = WebHelper.Get("/videoclub/prestamos");

            List<Prestamo> prestamos = MappearLista(json2);

            return prestamos;
        }

        private List<Prestamo> MappearLista(string json)
        {
            List<Prestamo> resultado = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return resultado;
        }


        public TransactionResult Insertar(Prestamo nuevoPrestamo)
        {
            NameValueCollection obj = ReverseMap(nuevoPrestamo);

            string json = WebHelper.Post("/videoclub/prestamos", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }



        public TransactionResult Actualizar(Prestamo prestamoAModificar)
        {
            NameValueCollection obj = ReverseMap(prestamoAModificar);

            string json = WebHelper.Post("/videoclub/prestamos", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        public TransactionResult Eliminar(Prestamo prestamoAEliminar)
        {
            NameValueCollection obj = ReverseMap(prestamoAEliminar);

            string json = WebHelper.Delete("/videoclub/prestamos/" + prestamoAEliminar.Id, obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", prestamo.Id.ToString());
            n.Add("idCliente", prestamo.cliente.Id.ToString());
            n.Add("idCopia", prestamo.copia.Id.ToString());
            n.Add("plazo", prestamo.Plazo.ToString());
            n.Add("abierto", prestamo.Abierto.ToString());
            n.Add("fechaPrestamo", prestamo.FechaPrestamo.ToString("yyyy-MM-dd"));
            n.Add("fechaDevolucionTentativa", prestamo.FechaDevolucionTentativa.ToString("yyyy-MM-dd"));
            n.Add("fechaDevolucionReal", prestamo.FechaDevolucionReal.ToString("yyyy-MM-dd"));
            return n;
        }

        private NameValueCollection ReverseMapActualizar(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", prestamo.Id.ToString());
            n.Add("abierto", prestamo.Abierto.ToString());
            n.Add("fechaDevolucionReal", prestamo.FechaDevolucionReal.ToString("yyyy-MM-dd"));
            return n;
        }


    }
}
