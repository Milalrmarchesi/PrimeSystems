using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeSystem_2026; //conecta mi proyecto

namespace bookflow
{
    public partial class panelContenido : Form
    {
        public panelContenido()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes ventana = new Clientes();
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ventas frm = new ventas();
            frm.Show();
            this.Hide();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btnLibros(object sender, EventArgs e)
        {
            //aca va mi diseño we 
            //llamo a libros
            this.panelPrincipal.Controls.Clear();

            //  ¡AHORA SÍ LLAMAS A TU DISEÑO!
            Libros pantallaArticulos = new Libros();

            pantallaArticulos.TopLevel = false;
            pantallaArticulos.FormBorderStyle = FormBorderStyle.None;
            pantallaArticulos.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaArticulos);
            pantallaArticulos.Show();

        }

        private void btnUsuarios(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnRRHH_Click(object sender, EventArgs e)
        {
            //llamo a rrhh 
            this.panelPrincipal.Controls.Clear();

            RRHH pantallaRRHH = new RRHH();

            pantallaRRHH.TopLevel = false;

            pantallaRRHH.FormBorderStyle = FormBorderStyle.None;
            pantallaRRHH.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaRRHH);
            pantallaRRHH.Show();

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();

            Proveedor pantallaproveedor = new Proveedor();
            pantallaproveedor.TopLevel = false;

            pantallaproveedor.FormBorderStyle = FormBorderStyle.None;
            pantallaproveedor.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaproveedor);
            pantallaproveedor.Show();
        
        }

        private void btnEstadoContable_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();

            EstadoContable pantallaEstadoContable = new EstadoContable();

            pantallaEstadoContable.TopLevel = false;

            pantallaEstadoContable.FormBorderStyle = FormBorderStyle.None;
            pantallaEstadoContable.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaEstadoContable);
            pantallaEstadoContable.Show();
        }
    }
}
