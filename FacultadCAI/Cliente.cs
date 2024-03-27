using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadCAI
{
    internal class Cliente
    {
        String _nombre;
        String _apellido;
        String _nroDocumento;
        String _usuario;
        String _estado;

        public Cliente(string nombre, string apellido, string nroDocumento, string usuario, string estado)
        {
            _nombre = nombre;
            _apellido = apellido;
            _nroDocumento = nroDocumento;
            _usuario = usuario;
            _estado = estado;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NroDocumento { get => _nroDocumento; set => _nroDocumento = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Estado { get => _estado; set => _estado = value; }

        override
        public String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.NroDocumento + ")";
        }

        public String datosCompletos()
        {
            return this.Nombre + ", " + this.Nombre + "(" + this.NroDocumento + ") " + this.Usuario + " " + this.Estado;
        }
    }
}
