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

        private Prestamo _prestamoSeleccionado;
        public FormPrestamos()
        {
            InitializeComponent();

            _admPrestamo = new AdmPrestamo();
            _admClientes = new AdmCliente();
            _admPeliculas = new AdmPelicula();

            _prestamos = new List<Prestamo>();
            _copias = new List<Copia>();
            _clientes = new List<Cliente>();

            _prestamoSeleccionado = new Prestamo();

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

                if (_prestamos.Count == 0)
                    MessageBox.Show("No hay prestamos disponibles");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btnId_Click(object sender, EventArgs e)
        {
            try
            {
                listPrestamos.DataSource = null;
                listPrestamos.DataSource = _admPrestamo.TraerPorId(Validaciones.ValidarInt(txtId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnTitulo_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarTitulo();
                listPrestamos.DataSource = null;
                listPrestamos.DataSource = _admPrestamo.TraerPorTitulo(Validaciones.ValidarInt(txtId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarTitulo()
        {
            if (txtTitulo.Text == "")
                throw new Exception("Debe ingresar un Titulo");
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                ValidarCliente();
                listPrestamos.DataSource = null;
                //listPrestamos.DataSource = _admPrestamo.TraerPorGenero(txtCliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarCliente()
        {
            if (txtCliente.Text == "")
                throw new Exception("Debe ingresar un Cliente");
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            AgregarModificarPrestamo frm = new AgregarModificarPrestamo(_prestamos);
            frm.Owner = this;
            frm.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            btnId_Click(sender, e);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            btnTitulo_Click(sender, e);
        }
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            btnCliente_Click(sender, e);
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
            DevolucionPrestamo frm = new DevolucionPrestamo(_prestamoSeleccionado);
            frm.Owner = this;
            frm.Show();
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

        private void listPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            _prestamoSeleccionado = (Prestamo)listPrestamos.SelectedValue;
        }

        //private void listPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        //{
            
        //}
    }
}
