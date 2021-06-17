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
using Datos;

namespace VideoClubApp.Forms
{
    public partial class FormClientes : Form
    {
        private AdmCliente _admCliente;
        private List<Cliente> _clientes;
        private Cliente _cliente;
        private Cliente _clienteSeleccionado;
        public FormClientes()
        {
            InitializeComponent();

            _admCliente = new AdmCliente();
            _clientes = new List<Cliente>();
            _clienteSeleccionado = new Cliente();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }
        private void TraerTodos()
        {
            try
            {
                listClientes.DataSource = null;
                listClientes.DataSource = _admCliente.TraerTodos();
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
                listClientes.DataSource = _admCliente.TraerPorDNI(Validaciones.ValidarInt(txtDNI.Text));
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
                listClientes.DataSource = _admCliente.TraerPorNombre(txtNombre.Text);
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
                listClientes.DataSource = _admCliente.TraerPorApellido(txtApellido.Text);
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
            btnApellido_Click(sender, e);
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            btnDNI_Click(sender, e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnNombre_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(listClientes.SelectedValue!=null)
            {
                _clienteSeleccionado = (Cliente)listClientes.SelectedValue;
                Form frm = new AgregarModificarCliente(_clienteSeleccionado);
                frm.Owner = this;
                frm.Show();
            } else
            {
                MessageBox.Show("No seleccionó un cliente a modificar.");
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedValue != null)
            {
                _clienteSeleccionado = (Cliente)listClientes.SelectedValue;

                TransactionResult resultado = _admCliente.Eliminar(_clienteSeleccionado);

                MessageBox.Show(resultado.Id.ToString());
            }
            else
            {
                MessageBox.Show("No seleccionó un cliente a modificar.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                listClientes.DataSource = null;
                listClientes.DataSource = _admCliente.TraerTodosOrdenadosPorId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
