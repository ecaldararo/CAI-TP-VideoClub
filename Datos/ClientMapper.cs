using System;
using System.Collections.Generic;
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
            // IR A EL REPOSITORIO DE DATOS (bd, file, webservice)

            string json2 = WebHelper.Get("/cliente");

            List<Cliente> clientes = MappearLista(json2);

            return clientes;
        }

        private List<Cliente> MappearLista(string json)
        {
            List<Cliente> resultado = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return resultado;
        }
    }
}
