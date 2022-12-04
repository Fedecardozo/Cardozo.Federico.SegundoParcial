using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IJson
    {
        public bool DeserializarJson<T>(string path, out List<T> listJson);

        public bool SerializarJson<T>(string path, List<T> listaJson);

    }
}
