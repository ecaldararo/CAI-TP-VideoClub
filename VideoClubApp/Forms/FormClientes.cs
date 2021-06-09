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
using VideoClubApp.Forms.AgregarModificar;

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

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                listClientes.DataSource = null;
                listClientes.DataSource = _admClientes.TraerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnNombre_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarNombre();
                listClientes.DataSource = null;
                listClientes.DataSource = _admClientes.TraerPorNombre(txtNombre.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarNombre()
        {
            if (txtNombre.Text == "")
                throw new Exception("Debe ingresar un Nombre");
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            
            try
            {
                ValidarApellido();
                listClientes.DataSource = null;
                listClientes.DataSource = _admClientes.TraerPorApellido(txtApellido.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarApellido()
        {
            if (txtApellido.Text == "")
                throw new Exception("Debe ingresar un Apellido");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarModificarCliente frm = new AgregarModificarCliente();
            frm.Owner = this;
            frm.Show();
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
