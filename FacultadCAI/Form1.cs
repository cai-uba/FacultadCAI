using Datos;
using FacultadCAI;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private ClienteNegocio clienteNegocio = new ClienteNegocio();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
        private void txtModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;

            Guid idCliente = clienteSeleccionado.Id;
            String direccion = txtDireccion.Text;
            String telefono = txtTelefono.Text;
            String email = txtMail.Text;

            clienteNegocio.modificarCliente(idCliente,direccion, telefono, email);

            cargarClientes();
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text; 
            int dni = Int32.Parse(txtDni.Text);
            String direccion = txtDireccion.Text;   
            String telefono = txtTelefono.Text;
            String email = txtMail.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            clienteNegocio.agregarCliente(nombre, apellido, dni, direccion, telefono, email, fechaNacimiento);

            cargarClientes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            txtNombre.Text = clienteSeleccionado.Nombre;
            txtApellido.Text = clienteSeleccionado.Apellido;
            txtDni.Text = clienteSeleccionado.Dni.ToString();
            txtDireccion.Text = clienteSeleccionado.Direccion;
            txtTelefono.Text = clienteSeleccionado.Telefono;
            txtMail.Text = clienteSeleccionado.Email;
            dtpFechaNacimiento.Value = clienteSeleccionado.FechaNacimiento;
            
        }

        private void txtBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].DataBoundItem;
            Guid idCliente = clienteSeleccionado.Id;

            clienteNegocio.borrarCliente(idCliente);

            cargarClientes();
        }

        private void cargarClientes()
        {
            List<Cliente> clientes = clienteNegocio.listarClientes();

            var bindingList = new BindingList<Cliente>(clientes);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["fechaBaja"].Visible = false;
        }
    }
}
