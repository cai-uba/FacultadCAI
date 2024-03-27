using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultadCAI
{
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente("Juan", "Perez", "320000001", "jPerez86", "activo"));
            clientes.Add(new Cliente("Carlos", "Gomez", "320000002", "cGomez86", "activo"));
            cargarListaObjetos(clientes);

        }


        private void cargarListaObjetos(List<Cliente> clientes)
        {
            cboClientes.DataSource = clientes;
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ValidadorUtils validadorUtils = new ValidadorUtils();
            try
            {
                validadorUtils.validarFormularioModificar(this);
            }
            catch (Exception ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cboClientes.SelectedItem;
            MessageBox.Show(cliente.datosCompletos());

        }
    }
}
