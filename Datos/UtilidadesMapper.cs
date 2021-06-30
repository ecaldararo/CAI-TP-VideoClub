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
    public class UtilidadesMapper
    {
        public TransactionResult Insertar(Email email)
        {
            NameValueCollection obj = ReverseMap(email);

            string json = WebHelper.Post("/utilidades", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);

            return resultado;
        }

        private NameValueCollection ReverseMap(Email email)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("para", email.Para);
            n.Add("asunto", email.Asunto);
            n.Add("mensaje", email.Mensaje.ToString());
            return n;
        }
    }
}
