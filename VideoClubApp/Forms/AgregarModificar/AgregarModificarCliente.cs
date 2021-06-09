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
        public AgregarModificarCliente()
        {
            InitializeComponent();
            _admCliente = new AdmCliente();
        }

        public AgregarModificarCliente(Form cliente)
        {
            InitializeComponent();
            _admCliente = new AdmCliente();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // datos

            int dni = Validaciones.ValidarInt(txtDni.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNac = dateTimeNac.Value;

            // validaciones

            Cliente nuevoCliente = new Cliente(dni,nombre,apellido);

            TransactionResult resultado = _admCliente.Agregar(nombre, apellido, fechaNac);

        }
    }
}
