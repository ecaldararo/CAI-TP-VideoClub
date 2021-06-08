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

namespace VideoClubApp.Forms
{
    public partial class FormClientes : Form
    {
        private AdmCliente _admClientes;
        private List<Cliente> _clientes;
        private Cliente _cliente;
        private Cliente _clienteSeleccionado;
        public FormClientes()
        {
            InitializeComponent();

            


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

        private void FormClientes_Load(object sender, EventArgs e)
        {

            List<Cliente> _clientes = new List<Cliente>();
            _clientes.Add(new Cliente(28000000, "Juan", "Perez"));
            _clientes.Add(new Cliente(29000000, "Jorge", "Perez"));
            _clientes.Add(new Cliente(30000000, "Jorge Juan", "Sanchez"));

            listClientes.DataSource = null;
            listClientes.DataSource = _clientes;
            //listClientes.DataSource = _admClientes.TraerTodos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clienteSeleccionado = (Cliente)listClientes.SelectedValue;
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            try
            {
                listClientes.DataSource = null;
                //listClientes.DataSource = _admClientes.TraerPorDNI(_clienteSeleccionado.Dni);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
