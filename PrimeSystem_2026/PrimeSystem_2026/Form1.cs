using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeSystem_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //llamo a articulos
            this.panelContenido.Controls.Clear();
            Libros pantallaArticulos = new Libros();

            pantallaArticulos.TopLevel = false;

            pantallaArticulos.FormBorderStyle = FormBorderStyle.None;
            pantallaArticulos.Dock = DockStyle.Fill;

            this.panelContenido.Controls.Add(pantallaArticulos);
            pantallaArticulos.Show();
        }

        private void btn_rrhh_Click(object sender, EventArgs e)
        {
            //llamo a rrhh 
            this.panelContenido.Controls.Clear();

            RRHH pantallaRRHH = new RRHH();

            pantallaRRHH.TopLevel = false;

            pantallaRRHH.FormBorderStyle = FormBorderStyle.None;
            pantallaRRHH.Dock = DockStyle.Fill;

            this.panelContenido.Controls.Add(pantallaRRHH);
            pantallaRRHH.Show();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            this.panelContenido.Controls.Clear();

            Proveedor pantallaproveedor = new Proveedor();
            pantallaproveedor.TopLevel = false;

            pantallaproveedor.FormBorderStyle = FormBorderStyle.None;
            pantallaproveedor.Dock = DockStyle.Fill;

            this.panelContenido.Controls.Add(pantallaproveedor);
            pantallaproveedor.Show();
        
        }

        private void btn_estadocontable_Click(object sender, EventArgs e)
        {
            this.panelContenido.Controls.Clear();

            EstadoContable pantallaEstadoContable = new EstadoContable();

            pantallaEstadoContable.TopLevel = false;

            pantallaEstadoContable.FormBorderStyle = FormBorderStyle.None;
            pantallaEstadoContable.Dock = DockStyle.Fill;

            this.panelContenido.Controls.Add(pantallaEstadoContable);
            pantallaEstadoContable.Show();
        }
    }
}
