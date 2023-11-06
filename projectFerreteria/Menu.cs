using MySql.Data.MySqlClient;
using projectFerreteria.clases;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                    if (txtPass1.Text.Equals(txtPass2.Text))
                    {
                        string set = "Update usuario set pass= '" + txtPass1.Text + "' where usuario= '" + Usuarios.usuario + " '";
                        //MessageBox.Show(set);
                        MySqlConnection conn = CConexion.establecerConexion();
                            ;
                        MySqlCommand consulta = new MySqlCommand();
                        consulta.Connection = conn;
                        consulta.CommandText = set;
                        consulta.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Se actualizo con exito");
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas deben ser iguales");
                    } 
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(this);
            this.Hide();
        }
        public void cambiarPass()
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                MySqlCommand bus = new MySqlCommand();
                string buscar = "Select * from usuario where usuario= '" + Usuarios.usuario + "'";
                // MessageBox.Show(buscar);


                bus.Connection = con;
                bus.CommandText = buscar;

                MySqlDataReader reader = bus.ExecuteReader();

                MessageBox.Show(reader.ToString());

                if (reader.Read())
                {
                    if (txtPass1.Text.Equals(txtPass2.Text))
                    {
                        string set = "Update usuario set pass= '" + txtPass1.Text + "' where usuario= '" + Usuarios.usuario + " '";
                        MessageBox.Show(set);
                        MySqlConnection conn = new MySqlConnection()
                            ;
                        MySqlCommand consulta = new MySqlCommand();
                        consulta.Connection = conn;
                        consulta.CommandText = set;
                        consulta.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Se actualizo con exito");
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas deben ser iguales");
                    }
                }
                else
                {
                    MessageBox.Show("No hubo lectura");
                }
                con.Close();


            }
            catch
            {
                MessageBox.Show("No se reconocio a este usuario");
            }
        }
    }
}
