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
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                dgvLibros.Rows.Add(
                dgvLibros.Rows.Count + 1,
                txtCodigo.Text,
                txtTitulo.Text,
                txtAutor.Text,
                txtEditorial.Text,
                txtPrecio.Text
            );

                        txtCodigo.Clear();
                        txtTitulo.Clear();
                        txtAutor.Clear();
                        txtEditorial.Clear();
                        txtPrecio.Clear();
                       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                dgvLibros.Rows.RemoveAt(dgvLibros.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione un libro para eliminar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                dgvLibros.CurrentRow.Cells[1].Value = txtCodigo.Text;
                dgvLibros.CurrentRow.Cells[2].Value = txtTitulo.Text;
                dgvLibros.CurrentRow.Cells[3].Value = txtAutor.Text;
                dgvLibros.CurrentRow.Cells[4].Value = txtEditorial.Text;
                dgvLibros.CurrentRow.Cells[5].Value = txtPrecio.Text;

                MessageBox.Show("Libro modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Seleccione un libro.");
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];

                txtCodigo.Text = fila.Cells[1].Value.ToString();
                txtTitulo.Text = fila.Cells[2].Value.ToString();
                txtAutor.Text = fila.Cells[3].Value.ToString();
                txtEditorial.Text = fila.Cells[4].Value.ToString();
                txtPrecio.Text = fila.Cells[5].Value.ToString();
            }
        }
    }
}
