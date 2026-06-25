namespace bookflow
{
    partial class RRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RRHH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_administrarProveedores = new System.Windows.Forms.Button();
            this.btnGestionLogin = new System.Windows.Forms.Button();
            this.btn_administrarUsuarios = new System.Windows.Forms.Button();
            this.btn_administrarClientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_administrarProveedores);
            this.panel1.Controls.Add(this.btnGestionLogin);
            this.panel1.Controls.Add(this.btn_administrarUsuarios);
            this.panel1.Controls.Add(this.btn_administrarClientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 498);
            this.panel1.TabIndex = 0;
            // 
            // btn_administrarProveedores
            // 
            this.btn_administrarProveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_administrarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_administrarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrarProveedores.Location = new System.Drawing.Point(355, 320);
            this.btn_administrarProveedores.Name = "btn_administrarProveedores";
            this.btn_administrarProveedores.Size = new System.Drawing.Size(212, 35);
            this.btn_administrarProveedores.TabIndex = 4;
            this.btn_administrarProveedores.Text = "Administrar Proveedores";
            this.btn_administrarProveedores.UseVisualStyleBackColor = false;
            this.btn_administrarProveedores.Click += new System.EventHandler(this.btn_administrarProveedores_Click);
            // 
            // btnGestionLogin
            // 
            this.btnGestionLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGestionLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionLogin.Location = new System.Drawing.Point(355, 274);
            this.btnGestionLogin.Name = "btnGestionLogin";
            this.btnGestionLogin.Size = new System.Drawing.Size(212, 35);
            this.btnGestionLogin.TabIndex = 3;
            this.btnGestionLogin.Text = "Gestion De Login";
            this.btnGestionLogin.UseVisualStyleBackColor = false;
            // 
            // btn_administrarUsuarios
            // 
            this.btn_administrarUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_administrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_administrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrarUsuarios.Location = new System.Drawing.Point(355, 225);
            this.btn_administrarUsuarios.Name = "btn_administrarUsuarios";
            this.btn_administrarUsuarios.Size = new System.Drawing.Size(212, 35);
            this.btn_administrarUsuarios.TabIndex = 2;
            this.btn_administrarUsuarios.Text = "Administrar Usuarios";
            this.btn_administrarUsuarios.UseVisualStyleBackColor = false;
            // 
            // btn_administrarClientes
            // 
            this.btn_administrarClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_administrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_administrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_administrarClientes.Location = new System.Drawing.Point(355, 170);
            this.btn_administrarClientes.Name = "btn_administrarClientes";
            this.btn_administrarClientes.Size = new System.Drawing.Size(212, 35);
            this.btn_administrarClientes.TabIndex = 1;
            this.btn_administrarClientes.Text = "Administrar Clientes";
            this.btn_administrarClientes.UseVisualStyleBackColor = false;
            this.btn_administrarClientes.Click += new System.EventHandler(this.btn_administrarClientes_Click);
            // 
            // RRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 498);
            this.Controls.Add(this.panel1);
            this.Name = "RRHH";
            this.Text = "RRHH";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_administrarProveedores;
        private System.Windows.Forms.Button btnGestionLogin;
        private System.Windows.Forms.Button btn_administrarUsuarios;
        private System.Windows.Forms.Button btn_administrarClientes;
    }
}