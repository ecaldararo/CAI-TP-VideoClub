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
                Copia nuevaCopia = new Copia(txtObservaciones.Text);
                nuevaCopia.IdPelicula = _pelicula.Id;
                //nuevaCopia.FechaAlta = DateTime.Now;

                int rdo = 0;
                int cant = Validaciones.ValidarInt(txtCantidad.Text);
                if (cant < 1)
                    throw new Exception("Cantidad de copias menor a 1");

                for (int i = 1; i <= cant; i++)
                {
                   _pelicula.copias.Add(nuevaCopia); // no tiene utilidad
                    rdo += _admPelicula.AgregarCopia(nuevaCopia);
                }

                if(rdo==0)
                    MessageBox.Show("Error al agregar las copias");
                else
                    MessageBox.Show("Se agregaron "+rdo+" copias exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
