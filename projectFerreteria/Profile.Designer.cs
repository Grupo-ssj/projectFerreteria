namespace projectFerreteria
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCaja = new System.Windows.Forms.RadioButton();
            this.rbAdministrativo = new System.Windows.Forms.RadioButton();
            this.rbInventario = new System.Windows.Forms.RadioButton();
            this.rbGerencia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Usuario";
            // 
            // txtNombreU
            // 
            this.txtNombreU.Location = new System.Drawing.Point(305, 103);
            this.txtNombreU.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(211, 22);
            this.txtNombreU.TabIndex = 1;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(305, 170);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(211, 22);
            this.txtCorreo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña  por defectto";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(664, 103);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnCrearUsuario.TabIndex = 6;
            this.btnCrearUsuario.Text = "Crear ";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(664, 158);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnEditarUsuario.TabIndex = 7;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(664, 291);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarUsuario.TabIndex = 8;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 9;
            // 
            // rbCaja
            // 
            this.rbCaja.AutoSize = true;
            this.rbCaja.Location = new System.Drawing.Point(29, 23);
            this.rbCaja.Margin = new System.Windows.Forms.Padding(4);
            this.rbCaja.Name = "rbCaja";
            this.rbCaja.Size = new System.Drawing.Size(56, 20);
            this.rbCaja.TabIndex = 10;
            this.rbCaja.TabStop = true;
            this.rbCaja.Text = "Caja";
            this.rbCaja.UseVisualStyleBackColor = true;
            // 
            // rbAdministrativo
            // 
            this.rbAdministrativo.AutoSize = true;
            this.rbAdministrativo.Location = new System.Drawing.Point(145, 71);
            this.rbAdministrativo.Margin = new System.Windows.Forms.Padding(4);
            this.rbAdministrativo.Name = "rbAdministrativo";
            this.rbAdministrativo.Size = new System.Drawing.Size(112, 20);
            this.rbAdministrativo.TabIndex = 11;
            this.rbAdministrativo.TabStop = true;
            this.rbAdministrativo.Text = "Administrativo";
            this.rbAdministrativo.UseVisualStyleBackColor = true;
            // 
            // rbInventario
            // 
            this.rbInventario.AutoSize = true;
            this.rbInventario.Location = new System.Drawing.Point(145, 23);
            this.rbInventario.Margin = new System.Windows.Forms.Padding(4);
            this.rbInventario.Name = "rbInventario";
            this.rbInventario.Size = new System.Drawing.Size(86, 20);
            this.rbInventario.TabIndex = 12;
            this.rbInventario.TabStop = true;
            this.rbInventario.Text = "Inventario";
            this.rbInventario.UseVisualStyleBackColor = true;
            // 
            // rbGerencia
            // 
            this.rbGerencia.AutoSize = true;
            this.rbGerencia.Location = new System.Drawing.Point(29, 71);
            this.rbGerencia.Margin = new System.Windows.Forms.Padding(4);
            this.rbGerencia.Name = "rbGerencia";
            this.rbGerencia.Size = new System.Drawing.Size(83, 20);
            this.rbGerencia.TabIndex = 13;
            this.rbGerencia.TabStop = true;
            this.rbGerencia.Text = "Gerencia";
            this.rbGerencia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCaja);
            this.groupBox1.Controls.Add(this.rbAdministrativo);
            this.groupBox1.Controls.Add(this.rbGerencia);
            this.groupBox1.Controls.Add(this.rbInventario);
            this.groupBox1.Location = new System.Drawing.Point(243, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(321, 123);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(801, 103);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 554);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCaja;
        private System.Windows.Forms.RadioButton rbAdministrativo;
        private System.Windows.Forms.RadioButton rbInventario;
        private System.Windows.Forms.RadioButton rbGerencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
    }
}