using MySql.Data.MySqlClient;
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
    public partial class Inventario : Form
    {
        MySqlConnection conectDb;
        int contador = 0;
        double valor = 00.00;

        public Inventario()
        {
            InitializeComponent();
            
            

        }

        private void dgInvnetario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string where = "where ";
           /* if (txtBuscar.Text != "")
            {
                where = where + "codigo like'%" + txtBuscar.Text + "%'" + "XOR nombre like'%" + txtBuscar.Text + "%'";
            }*/

                if (txtBuscar.Text != "")
            {
                where = where + " codigo like'%" + txtBuscar.Text + "%'" + "OR nombre like'%" + txtBuscar.Text + "%'"
                    + "OR dimencion like'%" + txtBuscar.Text + "%'" + "OR marca like'%" + txtBuscar.Text + "%'"
                    + "OR tipo like'%" + txtBuscar.Text + "%'" + "OR cantidad like'%" + txtBuscar.Text + "%'"
                    + "OR precio like'%" + txtBuscar.Text + "%'";
            }

           

            string query = "SELECT * FROM productos " + where;
            MySqlCommand comandDB = new MySqlCommand(query, conectDb);
            MySqlDataReader reader;
            dgInvnetario.Rows.Clear();
            dgInvnetario.Refresh();
            try
            {
                reader = comandDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgInvnetario.Rows.Add();
                        dgInvnetario.Rows[n].Cells[0].Value = reader.GetString(0);

                        dgInvnetario.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgInvnetario.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgInvnetario.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgInvnetario.Rows[n].Cells[4].Value = reader.GetString(4);
                        dgInvnetario.Rows[n].Cells[5].Value = reader.GetString(5);
                        dgInvnetario.Rows[n].Cells[6].Value = reader.GetString(6);
                    }
                }
                reader.Close();
            }catch (Exception ex)
            {
                MessageBox.Show("No hay registros"); 
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

      public void llenarTabla(){
            string servidor = "localhost";
            string bd = "ferreteria";
            string usuario = "root";
            string pass = "1234567";
            string puerto = "3307";

            string conexion = "server= " + servidor + ";" + "port=" + puerto + ";"
                + "user id=" + usuario + ";" + "password=" + pass + ";"
                + "database=" + bd + ";";


            DataTable dt = new DataTable();
            MySqlDataReader resultado;


            try
            {
                conectDb = new MySqlConnection(conexion);
                MySqlCommand consulta = new MySqlCommand("Select * FROM  productos", conectDb);
                consulta.CommandType = CommandType.Text;
                conectDb.Open();
                resultado = consulta.ExecuteReader();
                if (resultado.HasRows)
                {

                    while (resultado.Read())
                    {

                        int n = dgInvnetario.Rows.Add();
                        dgInvnetario.Rows[n].Cells[0].Value = resultado.GetString(0);
                        
                        dgInvnetario.Rows[n].Cells[1].Value = resultado.GetString(1);
                        dgInvnetario.Rows[n].Cells[2].Value = resultado.GetString(2);
                        dgInvnetario.Rows[n].Cells[3].Value = resultado.GetString(3);
                        dgInvnetario.Rows[n].Cells[4].Value = resultado.GetString(4);
                        dgInvnetario.Rows[n].Cells[5].Value = resultado.GetString(5);
                        dgInvnetario.Rows[n].Cells[6].Value = resultado.GetString(6);

                        valor = valor + double.Parse(resultado.GetString(6));

                        if (Int32.Parse(resultado.GetString(5))<25)
                        {
                            contador = contador + 1;
                            //MessageBox.Show(contador.ToString());

                        }
                        //contador = Int32.Parse(resultado.GetString(5));


                        //MessageBox.Show(contador.ToString());

                    }

                }


                // dt.Load(resultado);
               
                resultado.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Productos con baja existencia: " + contador.ToString());
            txtValor.Text = valor.ToString();
            //  dgInvnetario.DataSource = dt;
        }

        private void btncantidadB_Click(object sender, EventArgs e)
        {
            string where = "where ";
            /* if (txtBuscar.Text != "")
             {
                 where = where + "codigo like'%" + txtBuscar.Text + "%'" + "XOR nombre like'%" + txtBuscar.Text + "%'";
             }*/

            
                where = where +  "cantidad <= 25" ;
            



            string query = "SELECT * FROM productos " + where;
            MySqlCommand comandDB = new MySqlCommand(query, conectDb);
            MySqlDataReader reader;
            dgInvnetario.Rows.Clear();
            dgInvnetario.Refresh();
            try
            {
                reader = comandDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgInvnetario.Rows.Add();
                        dgInvnetario.Rows[n].Cells[0].Value = reader.GetString(0);

                        dgInvnetario.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgInvnetario.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgInvnetario.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgInvnetario.Rows[n].Cells[4].Value = reader.GetString(4);
                        dgInvnetario.Rows[n].Cells[5].Value = reader.GetString(5);
                        dgInvnetario.Rows[n].Cells[6].Value = reader.GetString(6);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            contador = 0;
            valor = 00.00;
            dgInvnetario.Rows.Clear();
            dgInvnetario.Refresh();

            llenarTabla();
        }

        private void panelInventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            dgInvnetario.Columns.Clear();
            DataGridViewTextBoxColumn ct = new DataGridViewTextBoxColumn();
            ct.HeaderText = "Fecha";
            ct.Name = "Fecha";
            dgInvnetario.Columns.Add(ct);

            DataGridViewTextBoxColumn ct2 = new DataGridViewTextBoxColumn();
            ct2.HeaderText = "Usuario";
            ct2.Name = "Usuario";
            dgInvnetario.Columns.Add(ct2);

            DataGridViewTextBoxColumn ct3 = new DataGridViewTextBoxColumn();
            ct3.HeaderText = "Codigo";
            ct3.Name = "Codigo";
            dgInvnetario.Columns.Add(ct3);

            DataGridViewTextBoxColumn ct4 = new DataGridViewTextBoxColumn();
            ct4.HeaderText = "Previo";
            ct4.Name = "Previo";
            dgInvnetario.Columns.Add(ct4);

            DataGridViewTextBoxColumn ct5 = new DataGridViewTextBoxColumn();
            ct5.HeaderText = "Posterior";
            ct4.Name = "Posterior";
            dgInvnetario.Columns.Add(ct5);

            //////////////////////////////////////
            string servidor = "localhost";
            string bd = "ferreteria";
            string usuario = "root";
            string pass = "1234567";
            string puerto = "3307";

            string conexion = "server= " + servidor + ";" + "port=" + puerto + ";"
                + "user id=" + usuario + ";" + "password=" + pass + ";"
                + "database=" + bd + ";";


            DataTable dt = new DataTable();
            MySqlDataReader resultado;


            try
            {
                conectDb = new MySqlConnection(conexion);
                MySqlCommand consulta = new MySqlCommand("Select * FROM  bitacora", conectDb);
                consulta.CommandType = CommandType.Text;
                conectDb.Open();
                resultado = consulta.ExecuteReader();
                if (resultado.HasRows)
                {

                    while (resultado.Read())
                    {

                        int n = dgInvnetario.Rows.Add();
                        dgInvnetario.Rows[n].Cells[0].Value = resultado.GetString(1);

                        dgInvnetario.Rows[n].Cells[1].Value = resultado.GetString(2);
                        dgInvnetario.Rows[n].Cells[2].Value = resultado.GetString(3);
                        dgInvnetario.Rows[n].Cells[3].Value = resultado.GetString(4);
                        dgInvnetario.Rows[n].Cells[4].Value = resultado.GetString(5);


                    }// aqui en el string obtenido evitamos el primer campo que es el identificador de la tabla

                }


                // dt.Load(resultado);

                resultado.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pnInventario_Paint(object sender, PaintEventArgs e)
        {
             
        }
    }
}
