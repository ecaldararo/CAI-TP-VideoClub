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

                _prestamos = _admPrestamo.TraerPrestamos();

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

        public void ValidarId()
        {
            if (txtId.Text == "")
                throw new Exception("Debe ingresar un Id");
        }

        private void btnIdPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarIdPelicula();
                listPrestamos.DataSource = null;
                listPrestamos.DataSource = _admPrestamo.TraerPorIdPelicula(Validaciones.ValidarInt(txtIdPelicula.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarIdPelicula()
        {
            if (txtIdPelicula.Text == "")
                throw new Exception("Debe ingresar un ID de una Película");
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                ValidarIdCliente();
                listPrestamos.DataSource = null;
                listPrestamos.DataSource = _admPrestamo.TraerPorIdCliente(Validaciones.ValidarInt(txtCliente.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ValidarIdCliente()
        {
            if (txtCliente.Text == "")
                throw new Exception("Debe ingresar un ID de un Cliente");
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            AgregarModificarPrestamo frm = new AgregarModificarPrestamo(_prestamos);
            frm.Owner = this;
            frm.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //btnId_Click(sender, e);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            //btnTitulo_Click(sender, e);
        }
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            //btnCliente_Click(sender, e);
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

        private void Limpiar()
        {
            txtId.Text = "";
            txtIdPelicula.Text = "";
            txtCliente.Text = "";
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
                //listPrestamos.DataSource = null;
                //listPrestamos.DataSource = _admPrestam/*o.TraerTodosOrdenadosPorId();*/
                throw new NotImplementedException();
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

    }
}
