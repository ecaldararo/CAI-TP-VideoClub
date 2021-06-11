using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubApp.Forms.AgregarModificar;
using Negocio;
using Entidades;

namespace VideoClubApp.Forms
{
    public partial class FormPeliculas2 : Form
    {
        private AgregarModificarPelicula _frm;
        private AdmPelicula _admPelicula;
        public FormPeliculas2()
        {
            InitializeComponent();
            _frm = new AgregarModificarPelicula();
            _admPelicula = new AdmPelicula();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPeliculas_Load(object sender, EventArgs e)
        {
            listPeliculas.DataSource = null;
            listPeliculas.DataSource = _admPelicula.TraerPeliculas();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AgregarModificarPelicula frm = new AgregarModificarPelicula(this);
            //frm.Owner = this;
            //frm.Show();

        }
    }
}
