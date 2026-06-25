namespace bookflow
{
    partial class panelContenido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas_Click = new System.Windows.Forms.Button();
            this.btnUsuarios_Click = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnEstadoContable = new System.Windows.Forms.Button();
            this.btnRRHH = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BookFlow = new System.Windows.Forms.Label();
            this.btnLibros_Click = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(291, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(23, 77);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(158, 27);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas_Click
            // 
            this.btnVentas_Click.BackColor = System.Drawing.Color.White;
            this.btnVentas_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas_Click.Location = new System.Drawing.Point(23, 129);
            this.btnVentas_Click.Margin = new System.Windows.Forms.Padding(2);
            this.btnVentas_Click.Name = "btnVentas_Click";
            this.btnVentas_Click.Size = new System.Drawing.Size(158, 27);
            this.btnVentas_Click.TabIndex = 2;
            this.btnVentas_Click.Text = "Ventas";
            this.btnVentas_Click.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios_Click
            // 
            this.btnUsuarios_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios_Click.Location = new System.Drawing.Point(23, 229);
            this.btnUsuarios_Click.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios_Click.Name = "btnUsuarios_Click";
            this.btnUsuarios_Click.Size = new System.Drawing.Size(160, 27);
            this.btnUsuarios_Click.TabIndex = 3;
            this.btnUsuarios_Click.Text = "Usuarios";
            this.btnUsuarios_Click.UseVisualStyleBackColor = true;
            this.btnUsuarios_Click.Click += new System.EventHandler(this.btnUsuarios);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnEstadoContable);
            this.panelMenu.Controls.Add(this.btnRRHH);
            this.panelMenu.Controls.Add(this.btnProveedores);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.BookFlow);
            this.panelMenu.Controls.Add(this.btnLibros_Click);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnUsuarios_Click);
            this.panelMenu.Controls.Add(this.btnVentas_Click);
            this.panelMenu.Location = new System.Drawing.Point(-2, 1);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(203, 498);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(23, 441);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(158, 27);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnEstadoContable
            // 
            this.btnEstadoContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoContable.Location = new System.Drawing.Point(23, 384);
            this.btnEstadoContable.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstadoContable.Name = "btnEstadoContable";
            this.btnEstadoContable.Size = new System.Drawing.Size(158, 27);
            this.btnEstadoContable.TabIndex = 9;
            this.btnEstadoContable.Text = "Estado Contable";
            this.btnEstadoContable.UseVisualStyleBackColor = true;
            this.btnEstadoContable.Click += new System.EventHandler(this.btnEstadoContable_Click);
            // 
            // btnRRHH
            // 
            this.btnRRHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRHH.Location = new System.Drawing.Point(23, 336);
            this.btnRRHH.Margin = new System.Windows.Forms.Padding(2);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Size = new System.Drawing.Size(158, 27);
            this.btnRRHH.TabIndex = 8;
            this.btnRRHH.Text = "RRHH";
            this.btnRRHH.UseVisualStyleBackColor = true;
            this.btnRRHH.Click += new System.EventHandler(this.btnRRHH_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Location = new System.Drawing.Point(23, 278);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(158, 29);
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(49, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sistema de Librería";
            // 
            // BookFlow
            // 
            this.BookFlow.AutoSize = true;
            this.BookFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookFlow.ForeColor = System.Drawing.Color.Green;
            this.BookFlow.Location = new System.Drawing.Point(2, 0);
            this.BookFlow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookFlow.Name = "BookFlow";
            this.BookFlow.Size = new System.Drawing.Size(134, 31);
            this.BookFlow.TabIndex = 5;
            this.BookFlow.Text = "BookFlow";
            // 
            // btnLibros_Click
            // 
            this.btnLibros_Click.BackColor = System.Drawing.Color.White;
            this.btnLibros_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros_Click.ForeColor = System.Drawing.Color.Black;
            this.btnLibros_Click.Location = new System.Drawing.Point(23, 178);
            this.btnLibros_Click.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibros_Click.Name = "btnLibros_Click";
            this.btnLibros_Click.Size = new System.Drawing.Size(158, 27);
            this.btnLibros_Click.TabIndex = 4;
            this.btnLibros_Click.Text = "Libros";
            this.btnLibros_Click.UseVisualStyleBackColor = false;
            this.btnLibros_Click.Click += new System.EventHandler(this.btnLibros);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = global::bookflow.Properties.Resources.ChatGPT_Image_12_jun_2026__04_24_27_p_m_;
            this.panelPrincipal.Location = new System.Drawing.Point(199, 1);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(764, 523);
            this.panelPrincipal.TabIndex = 5;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelContenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(974, 508);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "panelContenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas_Click;
        private System.Windows.Forms.Button btnUsuarios_Click;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLibros_Click;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label BookFlow;
        private System.Windows.Forms.Button btnRRHH;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEstadoContable;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}