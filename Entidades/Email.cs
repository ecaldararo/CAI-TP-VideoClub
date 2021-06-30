using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Email
    {
        string _para;
        string _asunto;
        string _mensaje;

        public Email(string para,string asunto,string mensaje)
        {
            _para = para;
            _asunto = asunto;
            _mensaje = mensaje;
        }

        public string Para { get => _para;  }
        public string Asunto { get => _asunto;  }
        public string Mensaje { get => _mensaje; }
    }
}
