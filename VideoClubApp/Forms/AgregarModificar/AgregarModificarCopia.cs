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

namespace VideoClubApp.Forms.AgregarModificar
{
    public partial class AgregarModificarCopia : Form
    {
        private Pelicula _pelicula;
        private AdmPelicula _admPelicula;
        private Copia _nuevaCopia;
        public AgregarModificarCopia(Pelicula peliculaSeleccionada)
        {
            InitializeComponent();
            _pelicula = peliculaSeleccionada;
            _admPelicula = new AdmPelicula();
        }

        private void AgregarModificarCopia_Load(object sender, EventArgs e)
        {
            txtPelicula.Text = _pelicula.Titulo;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCopias_Click(object sender, EventArgs e)
        {
            try
            {
                Copia nuevaCopia = new Copia();
                nuevaCopia.IdPelicula = _pelicula.Id;
                nuevaCopia.Observaciones = txtObservaciones.Text;
                nuevaCopia.FechaAlta = DateTime.Now;
                _pelicula.copias.Add(nuevaCopia);

                string rdo = _admPelicula.AgregarCopia(nuevaCopia);
                MessageBox.Show(rdo);

                //int cant = Validaciones.ValidarInt(txtCantidad.Text);
                //for (int i = 1; i < cant; i++)
                //{
                //    Copia nuevaCopia = new Copia();
                //    nuevaCopia.IdPelicula = _pelicula.Id;
                //    nuevaCopia.Observaciones = txtObservaciones.Text;
                //    nuevaCopia.FechaAlta = DateTime.Now;
                //    _pelicula.copias.Add(nuevaCopia);
                //}

                //foreach (Copia c in _pelicula.copias)
                //{
                //    _admPelicula.AgregarCopias(c, cant);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
