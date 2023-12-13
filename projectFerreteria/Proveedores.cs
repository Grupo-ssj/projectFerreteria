using MySql.Data.MySqlClient;
using projectFerreteria.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFerreteria
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // agregar proveedor
            
            string RTN = "";
            string nombre = " ";
            string correo = "";
            string telefono = "";
            string direccion = "";


            MySqlConnection conn = CConexion.establecerConexion();

            RTN = txtRtn.Text;
            nombre = txtNombreP.Text;
            correo = txtCorreoP.Text;
            telefono = txtTelefono.Text;
            direccion = txtDireccion.Text;



            string insertar = "INSERT INTO proveedor (idProveedor,nombre,telefono,correo,direccion) values('" + RTN + "','" + nombre + "','" + telefono + "','" + correo + "','" + direccion + "' )";
            
            try
            {

                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conn;
                consulta.CommandText = insertar;
                consulta.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Se registro este proveedor con exitoso");


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al insertar datos del Proveedor ", ex.ToString());
               // Console.WriteLine(" Error al insertar datos del Proveedor", ex.ToString());
            }

        }

        private void bbrnBuscar_Click(object sender, EventArgs e)
        {
            string rtn = txtRtn.Text;//txtNombreU.Text;
            string buscar = "SELECT * FROM proveedor WHERE idProveedor = '" + rtn + "'";
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            con.CommandText = buscar;

            MySqlDataReader leer = con.ExecuteReader();
            if (leer.Read())
            {

               
                txtNombreP.Text = leer.GetString(1);
                txtTelefono.Text = leer.GetString(2);
                txtCorreoP.Text = leer.GetString(3);
                txtDireccion.Text = leer.GetString(4);    
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado");
            }
            


            conn.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreP.Text;
            string correo = txtCorreoP.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;

            MySqlConnection conn = CConexion.establecerConexion();

           

            string set = "UPDATE proveedor set  nombre= '" + nombre + "',telefono= " + telefono + ",correo='" + correo + "',direccion = '" + direccion + "' where idProveedor = '" + txtRtn.Text + "'";
            //MessageBox.Show(idUsuario.ToString());
            try
            {

                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conn;
                consulta.CommandText = set;
                consulta.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Datos del proveedor actualizados");


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al actualizar datos del proveedor", ex.ToString());
            }
        }
    }
}
