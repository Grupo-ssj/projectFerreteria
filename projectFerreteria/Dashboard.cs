using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFerreteria
{

    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {
            abrirForm(new Profile());
           // if (this.dgContenedor.Controls.Count > 0)
             //   this.dgContenedor.Controls.RemoveAt(0);
            
            
           // Profile form = new Profile();
           // form.FormBorderStyle = FormBorderStyle.None;
          //  form.Dock = DockStyle.Fill;
           // form.TopLevel = false;
           // dgContenedor.Controls.Add(form);
          //  form.Show();

        }
        public void abrirForm(object formulario)
        {
            this.dgcontenedor.Controls.Clear();
            if (this.dgcontenedor.Controls.Count >0)
                this.dgcontenedor.Controls.RemoveAt(0);

            Form form = formulario as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.dgcontenedor.Controls.Add(form);
            this.dgcontenedor.Tag = form;
            
            form.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

            abrirForm(new Inventario());

            
        }
        private void eventoclk(object sender, EventArgs e)
        {
            
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            abrirForm(new AgregarProductos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new Informes());
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            abrirForm(new Informes());
        }

        public static void fChange( Form form)
        {
             //
             
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            abrirForm(new Pedidos());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirForm(new Proveedores());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirForm(new Ventas());
        }

        private void dgContenedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
