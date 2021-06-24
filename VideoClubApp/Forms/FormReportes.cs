using Entidades;
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

namespace VideoClubApp.Forms
{
    public partial class FormReportes : Form
    {
        AdmPrestamo _admPrestamo;
        List<Prestamo> _prestamosAbiertos;
        public FormReportes()
        {
            InitializeComponent();
            _admPrestamo = new AdmPrestamo();
            _prestamosAbiertos = new List<Prestamo>();


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPrestamosAbiertos_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPeliculasDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            _prestamosAbiertos = _admPrestamo.TraerPrestamosAbiertos();
            lstPrestamosAbiertos.DataSource = null;
            lstPrestamosAbiertos.DataSource = _prestamosAbiertos;
        }

        private void lstPrestamosAbiertos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPeliculasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
