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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(900, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes ventana = new Clientes();
            ventana.Show();
            this.Hide();
        }

        private void ventas_Load(object sender, EventArgs e)
        {

        }
    }
}
