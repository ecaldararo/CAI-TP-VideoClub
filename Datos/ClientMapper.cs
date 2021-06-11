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
    public class ClientMapper
    {
        private List<Cliente> _clientes;
        public ClientMapper()
        {
            _clientes = new List<Cliente>();
        }

        public List<Cliente> TraerTodos()
        {
            
            string json2 = WebHelper.Get("/cliente");

            List<Cliente> clientes = MappearLista(json2);

            return clientes;
        }

        private List<Cliente> MappearLista(string json)
        {
            List<Cliente> resultado = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return resultado;
        }

        public TransactionResult Insertar(Cliente nuevoCliente)
        {
            NameValueCollection obj = ReverseMap(nuevoCliente);

            string json = WebHelper.Post("/cliente", obj);
                
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        public TransactionResult Actualizar(Cliente clienteAModificar)
        {
            NameValueCollection obj = ReverseMapActualizar(clienteAModificar);

            string json = WebHelper.Put("/cliente/"+ clienteAModificar.Id.ToString(), obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        public TransactionResult Eliminar(Cliente clienteSeleccionado)
        {
            NameValueCollection obj = ReverseMap(clienteSeleccionado);

            string json = WebHelper.Delete("/cliente/" + clienteSeleccionado.Id, obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            //n.Add("id", cliente.id.ToString());
            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Apellido); //cliente.Apellido
            n.Add("direccion", cliente.Direccion);
            n.Add("DNI", cliente.Dni.ToString());//cliente.Dni.ToString()
            n.Add("fechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));//cliente.FechaNacimiento.ToString("yyyy-MM-dd")
            n.Add("activo", cliente.Activo.ToString());
            n.Add("usuario", "825551");
            return n;
        }

        private NameValueCollection ReverseMapActualizar(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.id.ToString());
            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Apellido); //cliente.Apellido
            n.Add("direccion", cliente.Direccion);
            n.Add("DNI", cliente.Dni.ToString());//cliente.Dni.ToString()
            n.Add("fechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));//cliente.FechaNacimiento.ToString("yyyy-MM-dd")
            n.Add("activo", cliente.Activo.ToString());
            return n;
        }


    }
}
