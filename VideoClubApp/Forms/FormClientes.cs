using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace VideoClubApp.Forms
{
    public partial class FormClientes : Form
    {
        private AdmCliente _admClientes;
        private List<Cliente> _clientes;
        private Cliente _cliente;
        private Cliente _clienteSeleccionado;
        public FormClientes()
        {
            InitializeComponent();

            _admClientes = new AdmCliente();
            _clientes = new List<Cliente>();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            listClientes.DataSource = null;
            listClientes.DataSource = _admClientes.TraerTodos();
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clienteSeleccionado = (Cliente)listClientes.SelectedValue;
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            try
            {
                listClientes.DataSource = null;
                listClientes.DataSource = _admClientes.TraerPorDNI(Validaciones.ValidarInt(txtDNI.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Form frm = new Form(
              //  _clienteSeleccionado.Dni
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
