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
            this.btnProvedores = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(34, 118);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(237, 42);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas_Click
            // 
            this.btnVentas_Click.BackColor = System.Drawing.Color.White;
            this.btnVentas_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas_Click.Location = new System.Drawing.Point(34, 198);
            this.btnVentas_Click.Name = "btnVentas_Click";
            this.btnVentas_Click.Size = new System.Drawing.Size(237, 42);
            this.btnVentas_Click.TabIndex = 2;
            this.btnVentas_Click.Text = "Ventas";
            this.btnVentas_Click.UseVisualStyleBackColor = false;
            this.btnVentas_Click.Click += new System.EventHandler(this.btnVentas_Click_Click);
            // 
            // btnUsuarios_Click
            // 
            this.btnUsuarios_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios_Click.Location = new System.Drawing.Point(34, 352);
            this.btnUsuarios_Click.Name = "btnUsuarios_Click";
            this.btnUsuarios_Click.Size = new System.Drawing.Size(240, 42);
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
            this.panelMenu.Controls.Add(this.btnProvedores);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.BookFlow);
            this.panelMenu.Controls.Add(this.btnLibros_Click);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnUsuarios_Click);
            this.panelMenu.Controls.Add(this.btnVentas_Click);
            this.panelMenu.Location = new System.Drawing.Point(-3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(275, 780);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 738);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(272, 42);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnEstadoContable
            // 
            this.btnEstadoContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoContable.Location = new System.Drawing.Point(34, 591);
            this.btnEstadoContable.Name = "btnEstadoContable";
            this.btnEstadoContable.Size = new System.Drawing.Size(237, 42);
            this.btnEstadoContable.TabIndex = 9;
            this.btnEstadoContable.Text = "Estado Contable";
            this.btnEstadoContable.UseVisualStyleBackColor = true;
            this.btnEstadoContable.Click += new System.EventHandler(this.btnEstadoContable_Click);
            // 
            // btnRRHH
            // 
            this.btnRRHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRHH.Location = new System.Drawing.Point(34, 517);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Size = new System.Drawing.Size(237, 42);
            this.btnRRHH.TabIndex = 8;
            this.btnRRHH.Text = "RRHH";
            this.btnRRHH.UseVisualStyleBackColor = true;
            this.btnRRHH.Click += new System.EventHandler(this.btnRRHH_Click);
            // 
            // btnProvedores
            // 
            this.btnProvedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvedores.Location = new System.Drawing.Point(34, 428);
            this.btnProvedores.Name = "btnProvedores";
            this.btnProvedores.Size = new System.Drawing.Size(237, 45);
            this.btnProvedores.TabIndex = 7;
            this.btnProvedores.Text = "Proveedores";
            this.btnProvedores.UseVisualStyleBackColor = true;
            this.btnProvedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(74, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sistema de Librería";
            // 
            // BookFlow
            // 
            this.BookFlow.AutoSize = true;
            this.BookFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookFlow.ForeColor = System.Drawing.Color.Green;
            this.BookFlow.Location = new System.Drawing.Point(3, 0);
            this.BookFlow.Name = "BookFlow";
            this.BookFlow.Size = new System.Drawing.Size(198, 46);
            this.BookFlow.TabIndex = 5;
            this.BookFlow.Text = "BookFlow";
            // 
            // btnLibros_Click
            // 
            this.btnLibros_Click.BackColor = System.Drawing.Color.White;
            this.btnLibros_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros_Click.ForeColor = System.Drawing.Color.Black;
            this.btnLibros_Click.Location = new System.Drawing.Point(34, 274);
            this.btnLibros_Click.Name = "btnLibros_Click";
            this.btnLibros_Click.Size = new System.Drawing.Size(237, 42);
            this.btnLibros_Click.TabIndex = 4;
            this.btnLibros_Click.Text = "Libros";
            this.btnLibros_Click.UseVisualStyleBackColor = false;
            this.btnLibros_Click.Click += new System.EventHandler(this.btnLibros);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = global::bookflow.Properties.Resources.ChatGPT_Image_12_jun_2026__04_24_27_p_m_;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrincipal.Location = new System.Drawing.Point(274, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1187, 782);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1461, 782);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "panelContenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
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
        private System.Windows.Forms.Button btnProvedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEstadoContable;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}