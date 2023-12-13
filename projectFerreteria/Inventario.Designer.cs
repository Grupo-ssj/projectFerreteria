namespace projectFerreteria
{
    partial class Inventario
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
            this.panelInventario = new System.Windows.Forms.Panel();
            this.pnInventario = new System.Windows.Forms.Panel();
            this.dgInvnetario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btncantidadB = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnInforme = new System.Windows.Forms.Button();
            this.panelInventario.SuspendLayout();
            this.pnInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvnetario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInventario
            // 
            this.panelInventario.Controls.Add(this.btnInforme);
            this.panelInventario.Controls.Add(this.pnInventario);
            this.panelInventario.Controls.Add(this.btnRefrescar);
            this.panelInventario.Controls.Add(this.lbValor);
            this.panelInventario.Controls.Add(this.txtValor);
            this.panelInventario.Controls.Add(this.btncantidadB);
            this.panelInventario.Controls.Add(this.btnBitacora);
            this.panelInventario.Controls.Add(this.btnBuscar);
            this.panelInventario.Controls.Add(this.txtBuscar);
            this.panelInventario.Location = new System.Drawing.Point(-2, 1);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(804, 450);
            this.panelInventario.TabIndex = 0;
            this.panelInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInventario_Paint);
            // 
            // pnInventario
            // 
            this.pnInventario.Controls.Add(this.dgInvnetario);
            this.pnInventario.Location = new System.Drawing.Point(14, 57);
            this.pnInventario.Name = "pnInventario";
            this.pnInventario.Size = new System.Drawing.Size(776, 326);
            this.pnInventario.TabIndex = 8;
            this.pnInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnInventario_Paint);
            // 
            // dgInvnetario
            // 
            this.dgInvnetario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvnetario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Dimension,
            this.Marca,
            this.Tipo,
            this.Cantidad,
            this.Precio});
            this.dgInvnetario.Location = new System.Drawing.Point(19, 12);
            this.dgInvnetario.Name = "dgInvnetario";
            this.dgInvnetario.Size = new System.Drawing.Size(726, 311);
            this.dgInvnetario.TabIndex = 0;
            this.dgInvnetario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvnetario_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Dimension
            // 
            this.Dimension.HeaderText = "Dimension";
            this.Dimension.Name = "Dimension";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(321, 28);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(61, 23);
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(14, 402);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(27, 13);
            this.lbValor.TabIndex = 6;
            this.lbValor.Text = "Lps:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(47, 402);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(108, 20);
            this.txtValor.TabIndex = 5;
            // 
            // btncantidadB
            // 
            this.btncantidadB.Location = new System.Drawing.Point(532, 28);
            this.btncantidadB.Name = "btncantidadB";
            this.btncantidadB.Size = new System.Drawing.Size(109, 23);
            this.btncantidadB.TabIndex = 4;
            this.btncantidadB.Text = "Cantidad Baja";
            this.btncantidadB.UseVisualStyleBackColor = true;
            this.btncantidadB.Click += new System.EventHandler(this.btncantidadB_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(666, 28);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(75, 23);
            this.btnBitacora.TabIndex = 3;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(230, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(64, 28);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(630, 397);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 23);
            this.btnInforme.TabIndex = 9;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInventario);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panelInventario.ResumeLayout(false);
            this.panelInventario.PerformLayout();
            this.pnInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvnetario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.DataGridView dgInvnetario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btncantidadB;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel pnInventario;
        private System.Windows.Forms.Button btnInforme;
    }
}