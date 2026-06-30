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
        DataTable tablaClientes = new DataTable();
        int filaSeleccionada = -1;

        public Clientes()
        {
            InitializeComponent();

            tablaClientes.Columns.Add("ID");
            tablaClientes.Columns.Add("DNI");
            tablaClientes.Columns.Add("Nombre");
            tablaClientes.Columns.Add("Apellido");
            tablaClientes.Columns.Add("Telefono");
            tablaClientes.Columns.Add("Email");

            //dgvClientes.DataSource = tablaClientes;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            Label titulo = new Label();
            titulo.Text = "BookFlow";
            titulo.Font = new Font("Arial", 24, FontStyle.Bold);
            titulo.ForeColor = Color.Green;
            titulo.AutoSize = true;
            titulo.Location = new Point(20, 30);


            Button btnVolver = new Button();
            btnVolver.Text = "Volver al menú";
            btnVolver.Width = 170;
            btnVolver.Height = 35;
            btnVolver.Location = new Point(25, 100);

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
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtDniCliente.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells["DNI"].Value);
                txtNombreCliente.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value);
                txtApellidoCliente.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells["Apellido"].Value);
                txtTelefonoCliente.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value);
                txtEmailCliente.Text = Convert.ToString(dgvClientes.Rows[e.RowIndex].Cells["Email"].Value);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Add(
                dgvClientes.Rows.Count,
                txtDniCliente.Text,
                txtNombreCliente.Text,
                txtApellidoCliente.Text,
                txtTelefonoCliente.Text,
                txtEmailCliente.Text
            );

            txtDniCliente.Clear();
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtTelefonoCliente.Clear();
            txtEmailCliente.Clear();
        }

        private void penelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                dgvClientes.Rows[filaSeleccionada].Cells["DNI"].Value = txtDniCliente.Text;
                dgvClientes.Rows[filaSeleccionada].Cells["Nombre"].Value = txtNombreCliente.Text;
                dgvClientes.Rows[filaSeleccionada].Cells["Apellido"].Value = txtApellidoCliente.Text;
                dgvClientes.Rows[filaSeleccionada].Cells["Telefono"].Value = txtTelefonoCliente.Text;
                dgvClientes.Rows[filaSeleccionada].Cells["Email"].Value = txtEmailCliente.Text;

                Limpiar();
            }
        }
        private void Limpiar()
                {
                    txtDniCliente.Clear();
                    txtNombreCliente.Clear();
                    txtApellidoCliente.Clear();
                    txtTelefonoCliente.Clear();
                    txtEmailCliente.Clear();
                    filaSeleccionada = -1;
                }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                dgvClientes.Rows.RemoveAt(filaSeleccionada);
                Limpiar();
            }
        }
    }
}    
  

