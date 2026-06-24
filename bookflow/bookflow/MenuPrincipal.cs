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
    public partial class panelContenido : Form
    {
        public panelContenido()
        {
            InitializeComponent();

            // Esto hace que todas tengan el mismo tamaño cuando lo inicias

            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(900, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

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
            //lblUsuario.Text = "Usuario: admin";
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btnLibros(object sender, EventArgs e)
        {
            //aca va mi diseño we 
            //llamo a libros
            this.panelPrincipal.Controls.Clear();


            LibrosBook pantallaArticulos = new LibrosBook();

            pantallaArticulos.TopLevel = false;
            pantallaArticulos.FormBorderStyle = FormBorderStyle.None;
            pantallaArticulos.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaArticulos);
            pantallaArticulos.Show();

        }

        private void btnUsuarios(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();

            Usuarios pantallaUsuarios = new Usuarios();

            pantallaUsuarios.TopLevel = false;
            pantallaUsuarios.FormBorderStyle = FormBorderStyle.None;
            pantallaUsuarios.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaUsuarios);
            pantallaUsuarios.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();

            Clientes pantallaClientes = new Clientes();

            pantallaClientes.TopLevel = false;
            pantallaClientes.FormBorderStyle = FormBorderStyle.None;
            pantallaClientes.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaClientes);
            pantallaClientes.Show();
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

            Provedores pantallaproveedor = new Provedores();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            this.panelPrincipal.Controls.Clear();

            CerrarSesion pantallaVentas = new CerrarSesion();

            pantallaVentas.TopLevel = false;
            pantallaVentas.FormBorderStyle = FormBorderStyle.None;
            pantallaVentas.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaVentas);
            pantallaVentas.Show();

            DialogResult respuesta = MessageBox.Show(
                    "¿Desea cerrar sesión?",
                    "Cerrar sesión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                {
                    Form1 login = new Form1();
                    login.Show();
                    this.Close();
                 }
          }

        private void btnVentas_Click_Click(object sender, EventArgs e)
        {
            this.panelPrincipal.Controls.Clear();

            ventas pantallaVentas = new ventas();

            pantallaVentas.TopLevel = false;
            pantallaVentas.FormBorderStyle = FormBorderStyle.None;
            pantallaVentas.Dock = DockStyle.Fill;

            this.panelPrincipal.Controls.Add(pantallaVentas);
            pantallaVentas.Show();
        }

      }
   }

