using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClubApp
{
    public partial class FormApps : Form
    {
        public FormApps()
        {
            InitializeComponent();
        }

        private void FormApps_Load(object sender, EventArgs e)
        {

        }

        private void btnVideoClub_Click(object sender, EventArgs e)
        {
            FormPrincipal frm = new FormPrincipal(this);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
