namespace projectFerreteria
{
    partial class FormBitacora
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
            this.dgInvnetario = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Despues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvnetario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInvnetario
            // 
            this.dgInvnetario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvnetario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Usuario,
            this.Codigo,
            this.Antes,
            this.Despues});
            this.dgInvnetario.Location = new System.Drawing.Point(12, 119);
            this.dgInvnetario.Name = "dgInvnetario";
            this.dgInvnetario.Size = new System.Drawing.Size(836, 311);
            this.dgInvnetario.TabIndex = 1;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Antes
            // 
            this.Antes.HeaderText = "Antes";
            this.Antes.Name = "Antes";
            // 
            // Despues
            // 
            this.Despues.HeaderText = "Despues";
            this.Despues.Name = "Despues";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(773, 76);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 548);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgInvnetario);
            this.Name = "FormBitacora";
            this.Text = "FormBitacora";
            ((System.ComponentModel.ISupportInitialize)(this.dgInvnetario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInvnetario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Despues;
        private System.Windows.Forms.Button btnVolver;
    }
}