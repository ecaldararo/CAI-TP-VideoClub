using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClubApp
{
    public partial class FormPrincipal : Form
    {
        private Form formActivo;
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

        }
    }
}
