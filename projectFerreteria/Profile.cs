using MySql.Data.MySqlClient;
using projectFerreteria.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFerreteria
{
    public partial class Profile : Form
    {

        int idUsuario = 0;
        public Profile()
        {
            InitializeComponent();
            rbCaja.Select();
            btnCrearUsuario.Enabled = false;
            btnEditarUsuario.Enabled = false;
            btnEditarUsuario.Enabled = false;
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //Login login = new Login();  
           // login.Show(this);
          //  this.Hide();
          // aqui elimaremos a los usuarios 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = " ";
            string correo = "";
            string pass = "UsuarioFerreteria";
            int cargo = 0;
            //contraseña por defecto ser a ¨UsuarioFerreteria¨
            //cargo que puede ser de 4 tipos 
            MySqlConnection conn = CConexion.establecerConexion();

            if (txtNombreU.Text != "" || txtCorreo.Text != "")
            {
                nombre = txtNombreU.Text;
                correo = txtCorreo.Text;

            }
            if (rbCaja.Checked == true)
            {
                cargo = 1;
            }
            if (rbInventario.Checked == true)
            {
                cargo = 2;
            }
            if (rbGerencia.Checked == true)
            {
                cargo = 3;
            }
            if (rbAdministrativo.Checked == true)
            {
                cargo = 4;
            }
            
            string set = "UPDATE usuario set  usuario= '"+nombre+"',correo= '"+correo+"',pass='"+pass+"',cargo = "+cargo+" where IdUsuario = "+idUsuario+"";
            //MessageBox.Show(idUsuario.ToString());
            try
            {

                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conn;
                consulta.CommandText = set;
                consulta.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Actualizacion del usuario exitosa");


            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al Editar datos del usuario", ex.ToString());
            }
        }

        public void AgregarUsuarios()
        {
            string nvalor = buscarUserb(txtNombreU.Text);
            if (nvalor != txtNombreU.Text){

                string nombre = " ";
                string correo = "";
                string pass = "UsuarioFerreteria";
                int cargo = 0;
                //contraseña por defecto ser a ¨UsuarioFerreteria¨
                //cargo que puede ser de 4 tipos 
                MySqlConnection conn = CConexion.establecerConexion();

                if (txtNombreU.Text != "" || txtCorreo.Text != "")
                {
                    nombre = txtNombreU.Text;
                    correo = txtCorreo.Text;

                }
                if (rbCaja.Checked == true)
                {
                    cargo = 1;
                }
                if (rbInventario.Checked == true)
                {
                    cargo = 2;
                }
                if (rbGerencia.Checked == true)
                {
                    cargo = 3;
                }
                if (rbAdministrativo.Checked == true)
                {
                    cargo = 4;
                }
                string insertar = "INSERT INTO usuario (usuario,correo,pass,cargo) values('" + nombre + "','" + correo + "','" + pass + "'," + cargo + ")";

                try
                {

                    MySqlCommand consulta = new MySqlCommand();
                    consulta.Connection = conn;
                    consulta.CommandText = insertar;
                    consulta.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registro del usuario exitoso");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error al insertar datos del usuario", ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ya existe un usuario con este nombre");
            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            buscarUser(txtNombreU.Text);
        }


        //pendiente
        public static string EncryptPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convertir el resultado a una cadena hexadecimal
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        private void txtNombreU_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreU.Text)){
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            //txtCorreo.Text.IndexOf("@") != txtCorreo.Text.LastIndexOf("@")) probardoble arroba
            if (!string.IsNullOrWhiteSpace(txtNombreU.Text) 
                && !string.IsNullOrWhiteSpace(txtCorreo.Text) 
                && txtCorreo.Text.Contains("@") && !txtCorreo.Text.Contains("..") && !txtCorreo.Text.Contains("@@"))
                
            {
                //btnBuscar.Enabled = true;
                btnCrearUsuario.Enabled = true;
                btnEditarUsuario.Enabled = true;
            }
            else
            {
                btnCrearUsuario.Enabled= false;
                btnEditarUsuario.Enabled = false;
            }
        }

        private void txtNombreU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorar el caracter
            }
        }
        public void buscarUser(string nombreU)
        {
            string usuarioN = nombreU;//txtNombreU.Text;
            string buscar = "SELECT * FROM usuario WHERE usuario = '" + usuarioN + "'";
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            con.CommandText = buscar;

            MySqlDataReader leer = con.ExecuteReader();
            if (leer.Read())
            {

                idUsuario = leer.GetInt32(0);// para guardar el id del usuario 
                txtCorreo.Text = leer.GetString(2);

                int carg = leer.GetInt32(4);
                if (carg == 1)
                {
                    rbCaja.Select();
                }
                if (carg == 2)
                {
                    rbInventario.Select();
                }
                if (carg == 3)
                {
                    rbGerencia.Select();
                }
                if (carg == 4)
                {
                    rbAdministrativo.Select();
                }

                //MessageBox.Show(leer.GetInt32(0).ToString());
                btnEditarUsuario.Enabled = true;
            }
            else
            {
                btnEditarUsuario.Enabled = false;
            }
            //return usuarioN;


            conn.Close();
            
        }
        public string buscarUserb(string nombreU)
        {
            string usuarioN = nombreU;//txtNombreU.Text;
            string buscar = "SELECT * FROM usuario WHERE usuario = '" + usuarioN + "'";
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            con.CommandText = buscar;

            MySqlDataReader leer = con.ExecuteReader();
            if (leer.Read())
            {
                conn.Close();
                return usuarioN;
            }
            else
            {
                return null;
            }
            //return usuarioN;


            

        }
    }
}
