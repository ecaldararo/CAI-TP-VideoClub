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
        AdmPelicula _admPelicula;
        AdmCliente _admClientes;
        
        List<Copia> _copias;
        List<Cliente> _clientes;
        List<Prestamo> _prestamos;
        List<Pelicula> _peliculas; 
        List<Pelicula> _peliculasDisponibles; 

        public FormReportes()
        {
            InitializeComponent();

            _admPrestamo = new AdmPrestamo();
            _admPelicula = new AdmPelicula();
            _admClientes = new AdmCliente();

            _copias = new List<Copia>();
            _clientes = new List<Cliente>();
            _prestamos = new List<Prestamo>();
            _peliculas = new List<Pelicula>();
            _peliculasDisponibles = new List<Pelicula>();
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

            _prestamos = _admPrestamo.TraerPrestamos();
            _copias = _admPelicula.TraerCopias();
            _peliculas = _admPelicula.TraerPeliculas();
            _clientes = _admClientes.TraerTodos();

            List<Prestamo> _prestamosAbiertos = _admPrestamo.TraerPrestamosAbiertos();
            List<Pelicula> _peliculasConCopias = new List<Pelicula>();
            


            foreach (Copia c in _copias)
            {
                if (_peliculas.Exists(x => x.Id == c.IdPelicula))
                    _peliculas.FirstOrDefault(x => x.Id == c.IdPelicula).copias.Add(c);
            }

            //foreach (Cliente cl in _clientes)
            //{
            //    if (_prestamos.Exists(x => x.IdCliente == cl.Id))
            //        _prestamos.FirstOrDefault(x => x.IdCliente == cl.Id).cliente = cl;
            //}


            

            //_peliculasDisponibles = _admPelicula.TraerPeliculas();

            //foreach (Pelicula p in _peliculasDisponibles)
            //{
            //    foreach (Copia c in p.copias)
            //    {
            //        if (!_prestamosAbiertos.Exists(x => x.copia.Id == c.Id))
            //        {
            //            p.copias.Add(c);
            //        }
            //    }
            //}

            TraerPeliculas();

            foreach (Cliente cl in _clientes)
            {
                if (_prestamosAbiertos.Exists(x => x.IdCliente == cl.Id))
                    _prestamosAbiertos.FirstOrDefault(x => x.IdCliente == cl.Id).cliente = cl;
            }

            foreach (Copia c in _copias)
            {
                if (_prestamosAbiertos.Exists(x => x.IdCopia == c.Id))
                    _prestamosAbiertos.FirstOrDefault(x => x.IdCopia == c.Id).copia = c;
            }

            

            //_peliculasDisponibles = _peliculas;
            // pendiente: agregarle listado de copias a cada pelicula
            // agregarles las disponibles
            lstPeliculasDisponibles.DataSource = null;
            lstPeliculasDisponibles.DataSource = _peliculasDisponibles;
            lstPeliculasDisponibles.DisplayMember = "DescripcionCombo";


            // falta asociarle las instancias de peliculas
            lstPrestamosAbiertos.DataSource = null;
            lstPrestamosAbiertos.DataSource = _prestamosAbiertos;

        }

        private void TraerPeliculas()
        {
            try
            {
                _copias.Clear();
                _peliculas.Clear();
                _copias = _admPelicula.TraerCopias();
                _peliculas = _admPelicula.TraerPeliculas();
                List<Prestamo> _prestamosAbiertos = _admPrestamo.TraerPrestamosAbiertos();

                //foreach (Copia c in _copias)
                //{
                //    if (_peliculas.Exists(x => x.Id == c.IdPelicula))
                //        _peliculas.FirstOrDefault(x => x.Id == c.IdPelicula).copias.Add(c);
                //}

                //List<Pelicula> _peliculasDisponibles = new List<Pelicula>();

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

                _peliculasDisponibles = _peliculasDisponibles.Where(x => x.copias.Count > 0).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstPrestamosAbiertos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstPeliculasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
