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
    public partial class Provedores : Form
    {
        public Provedores()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(900, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        private void Provedores_Load(object sender, EventArgs e)
        {

        }

    }
}
