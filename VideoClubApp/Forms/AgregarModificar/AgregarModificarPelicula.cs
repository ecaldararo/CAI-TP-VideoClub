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
    public partial class AgregarModificarPelicula : Form
    {
        private FormPeliculas formPeliculas;
        private AdmPelicula _admPelicula;

        public AgregarModificarPelicula()
        {
            InitializeComponent();
        }

        public AgregarModificarPelicula(FormPeliculas formPeliculas)
        {
            InitializeComponent();
            this.formPeliculas = formPeliculas;
            _admPelicula = new AdmPelicula();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();
                Pelicula pel = new Pelicula();
                pel.Anio = Validaciones.ValidarInt(txtAnio.Text);
                pel.Duracion = Validaciones.ValidarInt(txtDuracion.Text);
                pel.Titulo = txtTitulo.Text;
                pel.Director = txtDirector.Text;
                pel.Productora = txtProductora.Text;
                pel.Genero = txtGenero.Text;
                _admPelicula.Alta(pel);
                MessageBox.Show(pel.Titulo + " agregada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Validar()
        {
            if (txtAnio.Text == "")
                throw new Exception("Año Vacío");
            if (txtDuracion.Text == "")
                throw new Exception("Duración Vacío");
            //if (txtTitulo.Text == "")
            //    throw new Exception("Título Vacío");
            //if (txtDirector.Text == "")
            //    throw new Exception("Director Vacío");
            //if (txtProductora.Text == "")
            //    throw new Exception("Productora Vacío");
            //if (txtGenero.Text == "")
            //    throw new Exception("Genero Vacío");
            //if (txtId.Text == "")
            //    throw new Exception("Id Vacío");
        }
    }
}
