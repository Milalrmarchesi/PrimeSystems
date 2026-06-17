using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bookflow
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventas frm = new ventas();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
      
            {
                dgvClientes.Rows.Add(
                    dgvClientes.Rows.Count + 1,
                    txtCuitCliente.Text,
                    txtCuitCliente.Text,
                    txtNombreCliente.Text,
                    txtEntidadCliente.Text,
                    txtTelefonoCliente.Text,
                    txtCorreoCliente.Text   
                );

                txtCuitCliente.Clear();
                txtNombreCliente.Clear();
                txtEntidadCliente.Clear();
                txtTelefonoCliente.Clear();
                txtCorreoCliente.Clear();
            }

        private void penelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
