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
using Datos;

namespace VideoClubApp.Forms.AgregarModificar
{
    
    public partial class AgregarModificarCliente : Form
    {
        private AdmCliente _admCliente;
        private Cliente _clienteSeleccionado;
        public AgregarModificarCliente()
        {
            InitializeComponent();
            _admCliente = new AdmCliente();
            btnModificar.Hide();
        }

        public AgregarModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            _admCliente = new AdmCliente();
            btnAgregar.Hide();
            Cargar(cliente);
            _clienteSeleccionado = cliente;


        }
        public void Cargar(Cliente cliente)
        {
            txtDni.Text = cliente.Dni.ToString();
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDireccion.Text = cliente.Direccion;
            txtId.Text = cliente.Id.ToString();
            dateTimeNac.Value = cliente.FechaNacimiento;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // datos
            try
            {
                int dni = Validaciones.ValidarInt(txtDni.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string direccion = txtDireccion.Text;
                DateTime fechaNac = dateTimeNac.Value;
                bool activo = chbActivo.Checked;

                // validaciones

                TransactionResult resultado = _admCliente.Agregar(dni, nombre, apellido, direccion, fechaNac, activo);

                MessageBox.Show(resultado.Id.ToString());

                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // datos

            _clienteSeleccionado.id = Validaciones.ValidarInt(txtId.Text);
            _clienteSeleccionado.Dni = Validaciones.ValidarInt(txtDni.Text);
            _clienteSeleccionado.Nombre = txtNombre.Text;
            _clienteSeleccionado.Apellido = txtApellido.Text;
            _clienteSeleccionado.Direccion = txtDireccion.Text;
            _clienteSeleccionado.FechaNacimiento = dateTimeNac.Value;
            _clienteSeleccionado.Activo = chbActivo.Checked;

            // validaciones

            TransactionResult resultado = _admCliente.Modificar(_clienteSeleccionado);

            MessageBox.Show("Cliente " + resultado.Id.ToString() + " modificado");
            this.Hide();
        }
    }
}
