using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectFerreteria.clases
{
    internal class CConexion
    {
       

        
        public static MySqlConnection establecerConexion()
        {

            MySqlConnection conect = new MySqlConnection();

             string servidor = "localhost";
             string bd = "ferreteria";
             string usuario = "root";
             string pass = "1234567";
            string puerto = "3307";

            string conexion = "server= " + servidor + ";" + "port=" + puerto + ";"
                + "user id=" + usuario + ";" + "password=" + pass + ";"
                + "database=" + bd + ";";
            try {
                conect.ConnectionString = conexion;
                conect.Open();
                //MessageBox.Show("Conexion Exitosa");
                
            } catch (MySqlException e){
                MessageBox.Show("Error de conexion "+e.ToString());

            }return conect;
        }
       

    }
}
