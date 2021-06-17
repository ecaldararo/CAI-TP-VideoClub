using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubApp.Forms;
using Negocio;
using Entidades;

namespace VideoClubApp
{
    public partial class FormPrincipal : Form
    {
        private Form formActivo;
        private Form formPeliculas;
        private Form formPrestamos;
        private Form formClientes;

        private AdmCliente _admCliente;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFormInteractivo(Form formHijo, object botonSender)
        {
            if(formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelInteraccion.Controls.Add(formHijo);
            this.panelInteraccion.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
            tituloPrincipal.Text = formHijo.Text;
        }

        private void botonPrestamos_Click(object sender, EventArgs e)
        {
            formPrestamos = new FormPrestamos();
            abrirFormInteractivo(formPrestamos, sender);
        }

        private void panelInteraccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonPeliculas_Click(object sender, EventArgs e)
        {
            formPeliculas = new FormPeliculas();
            abrirFormInteractivo(formPeliculas, sender);
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            formClientes = new FormClientes();
            abrirFormInteractivo(formClientes, sender);
        }

        private void tituloPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
