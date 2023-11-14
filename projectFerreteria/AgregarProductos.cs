using MySql.Data.MySqlClient;
using projectFerreteria.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace projectFerreteria
{
    public partial class AgregarProductos : Form
    {
        
        string nCodigo = "";
        string nProducto = "";
        string nDimencion = "";
        string nMarca = "";
        string nCategoria = "";
        string nCantidad = "";
        string nPrecio = "";
        string user = Usuarios.usuario;
        public AgregarProductos()
        {
            InitializeComponent();
            cbCategoria.SelectedIndex = 0;
            btnAgregar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = false;
                       
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string dimencion = txtDimencion.Text;
            string marca = txtMarca.Text;
            string tipo = cbCategoria.Text;
            
            //tipo = cbCategoria.SelectedValue.ToString();
            int cantidad = Int32.Parse(txtCantidad.Text);
            float precio = float.Parse(txtPrecio.Text);
            MySqlConnection conn = CConexion.establecerConexion();

            
            string insertar = "INSERT INTO productos (codigo,nombre,dimencion,marca, tipo, cantidad, precio) values('" + codigo + "','" + nombre + "','" + dimencion + "','" + marca + "','" + tipo + "'," + cantidad + "," + precio + ")";

            try
            {

                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conn;
                consulta.CommandText = insertar;
                consulta.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Producto agregado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al insertar datos del producto", ex.ToString());
            }
        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            
            
            MySqlConnection conn = CConexion.establecerConexion();

            int cantidad = int.Parse(txtCantidad.Text);
            float precio = float.Parse (txtPrecio.Text);
            string set = "UPDATE productos set  nombre= '" + txtNombre.Text + "',dimencion= '" + txtDimencion.Text + "',marca='" + txtMarca.Text + "',tipo = '" + cbCategoria.Text + "',cantidad = " + cantidad + ",precio = " + precio + " where codigo = '" + txtCodigo.Text + "'";
           
            MessageBox.Show(set);
            
            //MessageBox.Show(idUsuario.ToString());
            try
            {

                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conn;
                consulta.CommandText = set;
                consulta.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Se actualizaron los datos del producto");


            }
            catch (Exception ex)

            {
                MessageBox.Show(" Error al Editar datos del producto", ex.ToString());
                MessageBox.Show( ex.ToString());
            }
            MySqlConnection conB = CConexion.establecerConexion();

            string previo = "";
            string posterior = "";

            if (nProducto != txtNombre.Text)
            {
                previo = nProducto;
                posterior = txtNombre.Text;
            }
            if (nDimencion != txtDimencion.Text)
            {
                previo = nDimencion;
                posterior = txtDimencion.Text;
            }
            if (nMarca != txtMarca.Text)
            {
                previo = nMarca;
                posterior = txtMarca.Text;
            }
            if (nCategoria != cbCategoria.Text)
            {
                previo = nCategoria;
                posterior = cbCategoria.Text;
            }
            if (nCantidad != txtCantidad.Text)
            {
                previo = nCantidad;
                posterior = txtCantidad.Text;
            }
            if (nPrecio != txtPrecio.Text)
            {
                previo = nPrecio;
                posterior = txtPrecio.Text;
            }
            string insertar = "INSERT INTO bitacora (fecha, usuario, codigo, previo, posterior) values( now(),'"+user+"','"+nCodigo+"','"+previo+"','"+posterior+"' )";

            MessageBox.Show(insertar);
            try
            {

                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conB;
                consulta.CommandText = insertar;
                consulta.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tu actualizacion se registro en la  bitacora");


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al insertar datos en la bitacora", ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string buscar = "SELECT * FROM productos WHERE codigo = '" + codigo + "'";
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            con.CommandText = buscar;

            MySqlDataReader leer = con.ExecuteReader();
            if (leer.Read())
            {

                txtNombre.Text = leer.GetString(1);
                txtDimencion.Text = leer.GetString(2);
                txtMarca.Text = leer.GetString(3);
                cbCategoria.Text = leer.GetString(4);
                txtCantidad.Text = leer.GetString(5);
                txtPrecio.Text = leer.GetString(6);

                nCodigo = codigo; // variables que usaremos para comparar y guardar en al bitacora el que fue actualizado
                nProducto= leer.GetString(1);
                nDimencion = leer.GetString(2);
                nMarca = leer.GetString(3);
                nCategoria = leer.GetString(4);
                nCantidad = leer.GetString(5);
                nPrecio = leer.GetString(6);

                btnEditar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontro ningun producto asociado a ese codigo");
            }

            conn.Close();


        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el caracter
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el caracter
            }
        }

        public void validarCampos()
        {
            //validamos cada campo cada que se hace cambio en alguno de ellos
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text) &&
                txtCodigo.Text.Length >= 8 &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtDimencion.Text) &&
                !string.IsNullOrWhiteSpace(txtMarca.Text) &&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled=false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            validarCampos();

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, un punto decimal y la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el caracter
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Ignorar el segundo punto decimal
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtDimencion_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }
    }
}
