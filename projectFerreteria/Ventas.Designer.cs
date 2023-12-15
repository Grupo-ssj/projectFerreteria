namespace projectFerreteria
{
    partial class Ventas
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnImprimirPedido = new System.Windows.Forms.Button();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIsv = new System.Windows.Forms.TextBox();
            this.txtStotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.btnAgregrarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtNventa = new System.Windows.Forms.TextBox();
            this.lbnumero = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(798, 99);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 39;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnImprimirPedido
            // 
            this.btnImprimirPedido.Location = new System.Drawing.Point(798, 137);
            this.btnImprimirPedido.Name = "btnImprimirPedido";
            this.btnImprimirPedido.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirPedido.TabIndex = 38;
            this.btnImprimirPedido.Text = "Imprimir";
            this.btnImprimirPedido.UseVisualStyleBackColor = true;
            this.btnImprimirPedido.Click += new System.EventHandler(this.btnImprimirPedido_Click);
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(157, 44);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(127, 20);
            this.txtMedida.TabIndex = 37;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(377, 11);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(119, 20);
            this.txtProducto.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Producto:";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(798, 38);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarProducto.TabIndex = 34;
            this.btnQuitarProducto.Text = "Eliminar";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Location = new System.Drawing.Point(798, 17);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPedido.TabIndex = 33;
            this.btnBuscarPedido.Text = "Buscar";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(636, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Total:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Isv 15%:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(709, 84);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 20);
            this.txtTotal.TabIndex = 30;
            // 
            // txtIsv
            // 
            this.txtIsv.Location = new System.Drawing.Point(709, 58);
            this.txtIsv.Name = "txtIsv";
            this.txtIsv.Size = new System.Drawing.Size(127, 20);
            this.txtIsv.TabIndex = 29;
            // 
            // txtStotal
            // 
            this.txtStotal.Location = new System.Drawing.Point(709, 30);
            this.txtStotal.Name = "txtStotal";
            this.txtStotal.Size = new System.Drawing.Size(127, 20);
            this.txtStotal.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Sub-Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(74, 27);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(495, 48);
            this.txtDescripcion.TabIndex = 25;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Unidad de medida:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(501, 43);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(81, 20);
            this.txtPrecio.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Precio:";
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(798, 61);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPedido.TabIndex = 20;
            this.btnCrearPedido.Text = "Crear";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // btnAgregrarProducto
            // 
            this.btnAgregrarProducto.Location = new System.Drawing.Point(709, 38);
            this.btnAgregrarProducto.Name = "btnAgregrarProducto";
            this.btnAgregrarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregrarProducto.TabIndex = 19;
            this.btnAgregrarProducto.Text = "Agregar";
            this.btnAgregrarProducto.UseVisualStyleBackColor = true;
            this.btnAgregrarProducto.Click += new System.EventHandler(this.btnAgregrarProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(545, 9);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 18;
            this.btnBuscarProducto.Text = "Buscar ";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(545, 76);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 17;
            this.btnBuscarProveedor.Text = "Buscar ";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(380, 78);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(127, 20);
            this.txtCliente.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cliente:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(377, 43);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(73, 20);
            this.txtcantidad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(157, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(127, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre:";
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(380, 111);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(127, 20);
            this.txtNombreEmp.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "RTN:";
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(126, 75);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(158, 20);
            this.txtRTN.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleado:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(380, 38);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(127, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha:";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(126, 101);
            this.txtIdEmpleado.Multiline = true;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(158, 25);
            this.txtIdEmpleado.TabIndex = 3;
            // 
            // txtNventa
            // 
            this.txtNventa.Location = new System.Drawing.Point(126, 40);
            this.txtNventa.Name = "txtNventa";
            this.txtNventa.Size = new System.Drawing.Size(158, 20);
            this.txtNventa.TabIndex = 2;
            this.txtNventa.TextChanged += new System.EventHandler(this.txtNcompra_TextChanged);
            // 
            // lbnumero
            // 
            this.lbnumero.AutoSize = true;
            this.lbnumero.Location = new System.Drawing.Point(18, 40);
            this.lbnumero.Name = "lbnumero";
            this.lbnumero.Size = new System.Drawing.Size(93, 13);
            this.lbnumero.TabIndex = 1;
            this.lbnumero.Text = "Numero de Venta:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Medida,
            this.Cantidad,
            this.PrecioU,
            this.SubTotal,
            this.ISV,
            this.Total});
            this.dgvProductos.Location = new System.Drawing.Point(57, 6);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(799, 112);
            this.dgvProductos.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioU
            // 
            this.PrecioU.HeaderText = "Precio Unitario";
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // ISV
            // 
            this.ISV.HeaderText = "ISV";
            this.ISV.Name = "ISV";
            this.ISV.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(205)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cmbFormato);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnImprimirPedido);
            this.panel1.Controls.Add(this.lbnumero);
            this.panel1.Controls.Add(this.txtNventa);
            this.panel1.Controls.Add(this.txtRTN);
            this.panel1.Controls.Add(this.txtIdEmpleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBuscarPedido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.txtNombreEmp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnBuscarProveedor);
            this.panel1.Controls.Add(this.btnCrearPedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 172);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(205)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.txtMedida);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.txtProducto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnQuitarProducto);
            this.panel2.Controls.Add(this.txtcantidad);
            this.panel2.Controls.Add(this.btnBuscarProducto);
            this.panel2.Controls.Add(this.btnAgregrarProducto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 75);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(205)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.dgvProductos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 130);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtDescripcion);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtIsv);
            this.panel4.Controls.Add(this.txtStotal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(922, 136);
            this.panel4.TabIndex = 4;
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {
            "Carta A4"});
            this.cmbFormato.Location = new System.Drawing.Point(663, 137);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(121, 21);
            this.cmbFormato.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(594, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Formato:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Ventas";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbnumero;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNventa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Button btnAgregrarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIsv;
        private System.Windows.Forms.TextBox txtStotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Button btnImprimirPedido;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.Label label15;
    }
}