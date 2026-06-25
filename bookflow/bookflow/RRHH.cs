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
    public partial class RRHH : Form
    {
        public RRHH()
        {
            InitializeComponent();
        
        }

        private void btn_administrarClientes_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();

            // 2. Creamos la ventana de tu compañero
            Clientes ventanaClientes = new Clientes();

            // 3. Configuración CLAVE para que actúe como un control dentro del panel y no flote
            ventanaClientes.TopLevel = false;
            ventanaClientes.FormBorderStyle = FormBorderStyle.None;
            ventanaClientes.Dock = DockStyle.Fill;

            // 4. Metemos la ventana adentro del panel y la mostramos
            this.panel1.Controls.Add(ventanaClientes);
            ventanaClientes.Show();
            bookflow.Clientes ventana = new bookflow.Clientes();
            ventanaClientes.Show();
        }

        private void btn_administrarProveedores_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();

            Proveedor ventanaProveedor = new Proveedor();

            ventanaProveedor.TopLevel = false;
            ventanaProveedor.FormBorderStyle = FormBorderStyle.None;
            ventanaProveedor.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(ventanaProveedor);
            ventanaProveedor.Show();
           

        }

    
        }
    }

