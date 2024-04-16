using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal class ValidadorUtils
    {

        public void validarTexto(String texto, String campo)
        {
            String msgError = "";
            msgError = msgError + validarVacio(texto, campo);
            msgError = msgError + validarLongitud(texto, campo);
            MessageBox.Show(msgError);
        }

        private String validarVacio(String texto, String campo)
        {
            if (texto.Length == 0)
            {
                //lblMsgError.Text = "El campo nombre no debe de ser vacio";
                //MessageBox.Show("El campo "+ campo + " no debe de ser vacio");
                return "El campo " + campo + " no debe de ser vacio";
            }
            return "";
        }

        private String validarLongitud(String texto, String campo)
        {
            if (texto.Length < 3)
            {
                //lblMsgError.Text = "El campo nombre como mínimo 3 caracteres.";
                //MessageBox.Show("El campo "+ campo + " como mínimo 3 caracteres.");
                return "El campo " + campo + " como mínimo 3 caracteres.";
            }
            return "";
        }

        public void validarFormularioModificar(Form form)
        {
            TextBox textNombre = (TextBox)form.Controls["txtNombre"];
            
            if(textNombre.Text.Length == 0)
            {
                throw new Exception("El nombre es un campo obligatorio");
            }

        }
    }
}
