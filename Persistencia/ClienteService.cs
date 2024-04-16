using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class ClienteService
    {
        public List<Cliente> getClientes()
        {
            HttpResponseMessage response = WebHelper.Get("/api/Cliente/GetClientes");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
            else
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Cliente> listadoClientes = JsonConvert.DeserializeObject<List<Cliente>>(contentStream);
                return listadoClientes;
            }
        }
    }
}
