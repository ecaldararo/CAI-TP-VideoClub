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
    public partial class AgregarModificarPrestamo : Form
    {
        private AdmPrestamo _admPrestamo;
        private AdmPelicula _admPeliculas;
        private AdmCliente _admClientes;
        private List<Prestamo> _listaPrestamos;

        public AgregarModificarPrestamo(List<Prestamo> listaPrestamos)
        {
            InitializeComponent();

            _admPrestamo = new AdmPrestamo();
            _admPeliculas = new AdmPelicula();
            _admClientes = new AdmCliente();
            _listaPrestamos = listaPrestamos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula peliculaSeleccionada = (Pelicula)cmbPelicula.SelectedItem;
                Prestamo alta = new Prestamo();
                alta.FechaPrestamo = dateTimePrestamo.Value;
                //alta.IdCopia = _listaPrestamos.Where(x => x.copia.Id == (peliculaSeleccionada.copias.FirstOrDefault(x => x.Id)) // necesito una copia que no esté prestada, o sea, que no tenga algún prestamo abierto.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarModificarPrestamo_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = _admClientes.TraerTodos();
            cmbCliente.DisplayMember = "DescripcionCombo";

            cmbPelicula.DataSource = null;
            cmbPelicula.DataSource = _admPeliculas.TraerPeliculas();
            cmbPelicula.DisplayMember = "DescripcionCombo";
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
