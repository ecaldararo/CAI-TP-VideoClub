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
    public partial class DevolucionPrestamo : Form
    {
        Prestamo _prestamoADevolver;

        AdmPrestamo _admPrestamo;
        public DevolucionPrestamo(Prestamo pre)
        {
            InitializeComponent();

            _prestamoADevolver = pre;

            _admPrestamo = new AdmPrestamo();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DevolucionPrestamo_Load(object sender, EventArgs e)
        {

            dateTimeDevolucion.Value = _prestamoADevolver.FechaDevolucionTentativa;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            _prestamoADevolver.Abierto = false;
            _prestamoADevolver.FechaDevolucionReal = dateTimeDevolucion.Value;
            try
            {
                _admPrestamo.RegistrarDevolucion(_prestamoADevolver);
                MessageBox.Show("Devolución Registrada");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
