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
    public partial class FormPeliculas : Form
    {
        private AdmPelicula _admPelicula;
        private List<Pelicula> _peliculas;
        private Pelicula _pelicula;
        private Pelicula _peliculaSeleccionada;
        private List<Copia> _copias;
        public FormPeliculas()
        {
            InitializeComponent();

            _admPelicula = new AdmPelicula();
            _peliculas = new List<Pelicula>();
            _peliculaSeleccionada = new Pelicula();
            _copias = new List<Copia>();

        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            
            TraerTodos();

        }

        private void TraerTodos()
        {
            try
            {
                _copias.Clear();
                _peliculas.Clear();
                _copias = _admPelicula.TraerCopias();
                _peliculas = _admPelicula.TraerPeliculas();

                //foreach (Copia c in _copias)
                //{
                //    if (_peliculas.Exists(x => x.Id == c.IdPelicula))
                //        _peliculas.FirstOrDefault(x => x.Id == c.IdPelicula).copias.Add(c);
                //}

                foreach (Copia c in _copias)
                {
                    _peliculas.FirstOrDefault(x => x.Id == c.IdPelicula).copias.Add(c);
                }

                // mal, porque agrega 1 copia por pelicula
                //foreach (Pelicula p in _peliculas)
                //{
                //    p.copias.Add(_copias.FirstOrDefault(x => x.IdPelicula == p.Id));
                //}

                listPeliculas.DataSource = null;
                listPeliculas.DataSource = _peliculas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            _peliculaSeleccionada = (Pelicula)listPeliculas.SelectedValue;
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            try
            {
                listPeliculas.DataSource = null;
                listPeliculas.DataSource = _admPelicula.TraerPorCodigo(Validaciones.ValidarInt(txtCodigo.Text));
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
                listPeliculas.DataSource = null;
                listPeliculas.DataSource = _admPelicula.TraerPorTitulo(txtTitulo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarNombre()
        {
            if (txtTitulo.Text == "")
                throw new Exception("Debe ingresar un Nombre");
        }

        private void btnApellido_Click(object sender, EventArgs e)
        {
            
            try
            {
                ValidarApellido();
                listPeliculas.DataSource = null;
                listPeliculas.DataSource = _admPelicula.TraerPorGenero(txtGenero.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarApellido()
        {
            if (txtGenero.Text == "")
                throw new Exception("Debe ingresar un Apellido");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarModificarPelicula frm = new AgregarModificarPelicula();
            frm.Owner = this;
            frm.Show();
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
            btnApellido_Click(sender, e);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnDNI_Click(sender, e);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            btnNombre_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(listPeliculas.SelectedValue!=null)
            {
                _peliculaSeleccionada = (Pelicula)listPeliculas.SelectedValue;
                Form frm = new AgregarModificarPelicula(_peliculaSeleccionada);
                frm.Owner = this;
                frm.Show();
            } else
            {
                MessageBox.Show("No seleccionó un película a modificar.");
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listPeliculas.SelectedValue != null)
            {
                _peliculaSeleccionada = (Pelicula)listPeliculas.SelectedValue;

                TransactionResult resultado = _admPelicula.Eliminar(_peliculaSeleccionada);

                MessageBox.Show(resultado.Id.ToString());
            }
            else
            {
                MessageBox.Show("No seleccionó un pelicula a modificar.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                listPeliculas.DataSource = null;
                listPeliculas.DataSource = _admPelicula.TraerTodosOrdenadosPorId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarCopia_Click(object sender, EventArgs e)
        {
            AgregarModificarCopia frm = new AgregarModificarCopia(_peliculaSeleccionada);
            frm.Owner = this;
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
