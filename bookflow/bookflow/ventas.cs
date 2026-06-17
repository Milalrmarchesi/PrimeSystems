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
    }
}
