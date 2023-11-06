using MySql.Data.MySqlClient;
using projectFerreteria.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFerreteria
{
    public partial class Login : Form
    {
        //static string userName = "";
        
        

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                Menu menu = new Menu();
                menu.Show(this);
                this.Hide();
                Usuarios.usuario = txtUsuario.Text;
            }else
            {
                MessageBox.Show("Ingresa el nombre de tu usuario");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //texto para probar la conexion
            // clases.CConexion obConect = new clases.CConexion();
            // obConect.establecerConexion();

            if (txtUsuario.Text!="" || txtPass.Text!="") {

                string sql = "server = localhost; port= 3307; user id=root;password=1234567; database=ferreteria;";
                MySqlConnection conectar = new MySqlConnection(sql);
                conectar.Open();


                MySqlCommand code = new MySqlCommand();
                code.Connection = conectar;

                // code.Connection = obConect.establecerConexion();


                code.CommandText = ("Select * from usuario WHERE usuario= '" + txtUsuario.Text + "' and pass = '" + txtPass.Text + "'");
                MySqlDataReader leer = code.ExecuteReader();
                MessageBox.Show("----" + leer.ToString());
                if (leer.Read())
                {
                    Usuarios.usuario = txtUsuario.Text;
                    MessageBox.Show("Bienvenido" + Usuarios.usuario);
                    Dashboard d = new Dashboard();
                    d.Show(this);
                    this.Hide();
                } else
                {
                    MessageBox.Show("Usuario o Contraseña no validos");
                } conectar.Close();

            }else
            {
                MessageBox.Show("Debe intruducir sus credenciales");
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        
    }
}
