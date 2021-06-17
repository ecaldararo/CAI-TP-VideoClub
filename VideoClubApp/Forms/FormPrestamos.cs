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
    public partial class FormPrestamos : Form
    {
        private AdmPrestamo _admPrestamo;
        private List<Prestamo> _prestamos;

        private AdmPelicula _admPeliculas;
        private List<Copia> _copias;

        private AdmCliente _admClientes;
        private List<Cliente> _clientes;

        //private Pelicula _pelicula;
        public FormPrestamos()
        {
            InitializeComponent();

            _admPrestamo = new AdmPrestamo();
            _admClientes = new AdmCliente();
            _admPeliculas = new AdmPelicula();

            _prestamos = new List<Prestamo>();
            _copias = new List<Copia>();
            _clientes = new List<Cliente>();

        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            
            TraerTodos();

        }

        private void TraerTodos()
        {
            try
            {
                _prestamos.Clear();
                _copias.Clear();
                _clientes.Clear();

                _prestamos = _admPrestamo.TraerPrestamos();
                _clientes = _admClientes.TraerTodos();
                _copias = _admPeliculas.TraerCopias();

                foreach (Copia c in _copias)
                {
                    if(_prestamos.Exists(x => x.IdCopia == c.Id))
                        _prestamos.FirstOrDefault(x => x.IdCopia == c.Id).copia = c;
                }

                foreach (Cliente cl in _clientes)
                {
                    if(_prestamos.Exists(x => x.IdCliente == cl.Id))
                        _prestamos.FirstOrDefault(x => x.IdCliente == cl.Id).cliente = cl;
                }


                listPrestamos.DataSource = null;
                listPrestamos.DataSource = _prestamos;

                if (_prestamos.SingleOrDefault() is null)
                    MessageBox.Show("No hay prestamos disponibles");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_peliculaSeleccionada = (Pelicula)listPrestamos.SelectedValue;
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            try
            {
                listPrestamos.DataSource = null;
                //listPrestamos.DataSource = _admPrestamo.TraerPorCodigo(Validaciones.ValidarInt(txtCodigo.Text));
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
                listPrestamos.DataSource = null;
                //listPrestamos.DataSource = _admPrestamo.TraerPorTitulo(txtTitulo.Text);
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
                listPrestamos.DataSource = null;
                //listPrestamos.DataSource = _admPrestamo.TraerPorGenero(txtCliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarApellido()
        {
            if (txtCliente.Text == "")
                throw new Exception("Debe ingresar un Apellido");
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            AgregarModificarPrestamo frm = new AgregarModificarPrestamo();
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
            if(listPrestamos.SelectedValue!=null)
            {
                //_peliculaSeleccionada = (Pelicula)listPrestamos.SelectedValue;
                //Form frm = new AgregarModificarPelicula(_peliculaSeleccionada);
                //frm.Owner = this;
                //frm.Show();
            } else
            {
                MessageBox.Show("No seleccionó un película a modificar.");
            }
            
        }

        private void btnRecibirPrestamo_Click(object sender, EventArgs e)
        {
            //AgregarModificarPrestamo frm = new AgregarModificarPrestamo();
            //frm.Owner = this;
            //frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            TraerTodos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listPrestamos.SelectedValue != null)
            {
                //_peliculaSeleccionada = (Pelicula)listPrestamos.SelectedValue;

                //TransactionResult resultado = _admPrestamo.Eliminar(_peliculaSeleccionada);

                //MessageBox.Show(resultado.Id.ToString());
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
                listPrestamos.DataSource = null;
                //listPrestamos.DataSource = _admPrestam/*o.TraerTodosOrdenadosPorId();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
