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
using Entidades.Exceptions;

namespace VideoClubApp.Forms.AgregarModificar
{
    public partial class AgregarModificarPrestamo : Form
    {
        private AdmPrestamo _admPrestamo;
        private AdmPelicula _admPeliculas;
        private AdmCliente _admClientes;
        private List<Prestamo> _listaPrestamos;
        private List<Prestamo> _prestamosAbiertos;
        private List<Copia> _copias;
        private List<Pelicula> _peliculas;
        private List<Pelicula> _peliculasDisponibles;

        public AgregarModificarPrestamo(List<Prestamo> listaPrestamos)
        {
            InitializeComponent();

            _admPrestamo = new AdmPrestamo();
            _admPeliculas = new AdmPelicula();
            _admClientes = new AdmCliente();
            _listaPrestamos = listaPrestamos;
            _prestamosAbiertos = new List<Prestamo>();

            _copias = new List<Copia>();
            _peliculas = new List<Pelicula>();
            _peliculasDisponibles = new List<Pelicula>();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // necesito una copia que no esté prestada, o sea, que no tenga algún prestamo abierto.
                Pelicula peliculaSeleccionada = (Pelicula)cmbPelicula.SelectedItem;
                Copia copiaDisponible;
                Prestamo alta = new Prestamo();

                if (peliculaSeleccionada.copias.Count == 0)
                    throw new NoHayCopiasDisponiblesException();

                List<Prestamo> prestamosAbiertos = _listaPrestamos.Where(x => x.Abierto == true).ToList();
                bool encontro = false;
                foreach (Copia c in peliculaSeleccionada.copias)
                {
                    if(!prestamosAbiertos.Exists(x => x.copia.Id == c.Id))
                    {
                        copiaDisponible = new Copia();
                        copiaDisponible = c;
                        alta.IdCopia = copiaDisponible.Id;
                        encontro = true;
                        break;
                    }
                }
                if (encontro == false)
                    throw new NoHayCopiasDisponiblesException();

                alta.pelicula = peliculaSeleccionada;
                alta.IdCliente = ((Cliente)cmbCliente.SelectedItem).Id;
                alta.Plazo = Validaciones.ValidarInt(txtPlazo.Text);
                alta.FechaPrestamo = dateTimePrestamo.Value;
                alta.FechaDevolucionTentativa = dateTimeTentativa.Value;
                alta.Abierto = true;
                _admPrestamo.Alta(alta);
                MessageBox.Show("Prestamo registrado");

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

            TraerPeliculas();

            cmbPelicula.DataSource = null;
            cmbPelicula.DataSource = _peliculasDisponibles;
            cmbPelicula.DisplayMember = "DescripcionCombo";
        }

        private void TraerPeliculas()
        {
            try
            {
                _copias.Clear();
                _peliculas.Clear();
                _copias = _admPeliculas.TraerCopias();
                _peliculas = _admPeliculas.TraerPeliculas();
                _prestamosAbiertos = _admPrestamo.TraerPrestamosAbiertos();

                foreach (Pelicula p in _peliculas)
                {
                    _peliculasDisponibles.Add(p);
                }

                foreach (Pelicula p in _peliculasDisponibles)
                {
                    foreach (Copia c in _copias)
                    {
                        if (p.Id == c.IdPelicula) 
                        {
                            if (!_prestamosAbiertos.Exists(x => x.copia.Id == c.Id))
                                p.copias.Add(c);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPlazo_TextChanged(object sender, EventArgs e)
        {
            dateTimeTentativa.Value = dateTimePrestamo.Value.AddDays(Validaciones.ValidarInt(txtPlazo.Text));
            
        }
    }
}
