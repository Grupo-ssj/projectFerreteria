
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using MySql.Data.MySqlClient;
using projectFerreteria.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using SpreadsheetLight;
using System.Windows.Forms;
//using QuestPDF.Helpers;

namespace projectFerreteria
{
    public partial class Ventas : Form
    {
        int n  = 0;
        double total = 0.00;
        double Isv = 0.00;
        double subTotal = 0.00;

        public Ventas()
        {
            InitializeComponent();
            txtStotal.Text = subTotal.ToString();
            txtIsv.Text = Isv.ToString();
            txtTotal.Text = total.ToString();
            // int n = dgvProductos.Rows.Add();
            
            txtCliente.Enabled = true;
            txtIdEmpleado.Enabled = true;

            txtNombreEmp.Enabled = true;
            txtProducto.Enabled = false;
            txtMedida.Enabled = false;
            txtStotal.Enabled = false;
            txtIsv.Enabled = false;
            txtTotal.Enabled = false;
            
        }

        private void btnAgregrarProducto_Click(object sender, EventArgs e)
        {
            agregarP();
        }

        public void agregarP()
        {
            //primero agregamos productos solo al datagrid para realizar la insercion de productos de manera directa a la BBDD

            double  subT = double.Parse(txtPrecio.Text) * double.Parse(txtcantidad.Text);
            double isv = subT * 0.15;
            double Total = subT + isv;

            dgvProductos.Rows.Add();
            dgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dgvProductos.Rows[n].Cells[1].Value = txtProducto.Text;
            dgvProductos.Rows[n].Cells[2].Value = txtMedida.Text;
            dgvProductos.Rows[n].Cells[3].Value = txtcantidad.Text;
            dgvProductos.Rows[n].Cells[4].Value = txtPrecio.Text;

            dgvProductos.Rows[n].Cells[5].Value = subT.ToString();
            dgvProductos.Rows[n].Cells[6].Value = isv.ToString();
            dgvProductos.Rows[n].Cells[7].Value = Total.ToString();
            subTotal += subT;
            Isv += isv;
            total += Total;

            txtStotal.Text = subTotal.ToString();
            txtIsv.Text = Isv.ToString();
            txtTotal.Text = total.ToString();

            n++;

        }

        public void agregarPedido()
        {
            string codigoP = "";
            string precioP = "";
            string CantidadP = "";

            string nVenta = txtNventa.Text;
            string rtn = "";
            if (txtRTN.Text==""){
                rtn = "0000000000001";
            }
            else
            {
                rtn = txtRTN.Text;
            }
            DateTime fechaPedido = dtpFecha.Value;
            
            //aqui agregamos el pedido a la base de datos
           /* foreach (DataGridViewRow fila in dgvProductos.Rows)// recorremos todo el datagrid
            {
                var1 = Convert.ToString(fila.Cells[0].Value);
                var2 = Convert.ToString(fila.Cells[2].Value);
                var3 = Convert.ToString(fila.Cells[3].Value);
                //MessageBox.Show(var1 + var2 + var3);
            }*/
            MySqlConnection conn = CConexion.establecerConexion();

            string insertar = "INSERT INTO Venta (nVenta,fechaVenta,idEmpleado,idCliente) values(" + nVenta + ", now(),'" + txtIdEmpleado.Text + "','" + rtn + "' )";
            string insertar2 = "";

            try
            {

                MySqlCommand consulta = new MySqlCommand();
                consulta.Connection = conn;
                consulta.CommandText = insertar;
                consulta.ExecuteNonQuery();
                

                int filas = dgvProductos.Rows.Count;
                for (int i = 0; i < filas - 1; i++)
                {
                    codigoP = dgvProductos.Rows[i].Cells[0].Value.ToString();
                    CantidadP = dgvProductos.Rows[i].Cells[3].Value.ToString();
                    precioP = dgvProductos.Rows[i].Cells[4].Value.ToString();
                    
                    insertar2 = "INSERT INTO detalleVenta (nVenta,codigo,cantidad,precio) values('" + nVenta + "', '" + codigoP + "', " + CantidadP + "," + precioP + " )";
                    //Console.WriteLine(insertar2);

                    consulta.CommandText = insertar2;
                    consulta.ExecuteNonQuery();
                }

                conn.Close();
                MessageBox.Show("Pedido creado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error al crear este venta " + ex.ToString());
                // Console.WriteLine(" Error al insertar datos del Proveedor", ex.ToString());
            }
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
          agregarPedido();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
          buscarEmpleado(txtIdEmpleado.Text);

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string buscar = "SELECT * FROM productos WHERE codigo = '" + txtCodigo.Text + "'";
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            con.CommandText = buscar;

            MySqlDataReader leer = con.ExecuteReader();
            if (leer.Read())
            {

                // solo los datos que ocupamos para el formulario
                txtProducto.Text = leer.GetString(1);
                txtMedida.Text = leer.GetString(2);

                // btnEditarUsuario.Enabled = true;
            }
            else
            {
                // btnEditarUsuario.Enabled = false;
                MessageBox.Show("Codigo de producto no valido");
            }
            //return usuarioN;


            conn.Close();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            buscarVenta();
            buscarEmpleado(txtIdEmpleado.Text);
            buscarDetallesPedido();
           
        }

        public void buscarDetallesPedido()
        {
            int l = 0;
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            string b = "SELECT * FROM detalleVenta WHERE nPedido = '" + txtNventa.Text + "' ";

            con.CommandText = b;
            MySqlDataReader contador = con.ExecuteReader();

          
            try
            {
                while (contador.Read())
                {
                    double subT = 0.00;
                    double isv = 0.00;
                    double tot = 0.00;
                    dgvProductos.Rows.Add();
                    dgvProductos.Rows[l].Cells[0].Value = contador.GetString(1);//codigo
                    string[] datos= buscarDatosProductos(contador.GetString(1));
                    dgvProductos.Rows[l].Cells[1].Value = datos[0];//nombre
                    dgvProductos.Rows[l].Cells[2].Value = datos[1];//medida
                    dgvProductos.Rows[l].Cells[3].Value = contador.GetString(2);//cantidad
                    dgvProductos.Rows[l].Cells[4].Value = contador.GetString(3);//precio

                    subT =  double.Parse(contador.GetString(2)) * double.Parse (contador.GetString(3));
                    isv = subT * 0.15; 
                    tot = subT + isv;
                    subTotal += subT; Isv += isv; total += tot;// guardamos los totales
                    dgvProductos.Rows[l].Cells[5].Value = subT.ToString();
                    dgvProductos.Rows[l].Cells[6].Value = isv.ToString();
                    dgvProductos.Rows[l].Cells[7].Value = tot.ToString();


                    l++;
                }
               
                txtStotal.Text = subTotal.ToString();
                txtIsv.Text = Isv.ToString();
                txtTotal.Text = total.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Productos del Pedido");
            }
            conn.Close();
        }
        public string[]  buscarDatosProductos(string codigo)
        {
            string buscar = "SELECT * FROM productos WHERE codigo = '" +codigo + "'";
            string productoNo = "";
            string productosMe = "";
            MySqlConnection connect = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = connect;
            con.CommandText = buscar;

            MySqlDataReader leer = con.ExecuteReader();
            if (leer.Read())
            {

                //Solo ocupamos estos dos datoa para mostrarlso en el dtgrid
                
               productoNo = leer.GetString(1);
               productosMe = leer.GetString(2);
                

                // btnEditarUsuario.Enabled = true;
                connect.Close();
            }
            else
            {
                // btnEditarUsuario.Enabled = false;
                MessageBox.Show("Codigo de producto no valido");
            }

            string[] datos = new string[] {productoNo, productosMe};
            return datos;


            
        }
        public void buscarEmpleado(string idEmpleado)
        {
            string buscar = "SELECT * FROM Empleado WHERE idEmpleado = '" + idEmpleado + "'";
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            con.CommandText = buscar;

            MySqlDataReader leer = con.ExecuteReader();
            if (leer.Read())
            {

               
               txtNombreEmp.Text = leer.GetString(1);
                



               
            }
            else
            {
                
                MessageBox.Show("ID de empleado no valido");
            }
           


            conn.Close();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
        public void buscarVenta()
        {
            string buscar = "SELECT * FROM Venta WHERE nVenta = '" + txtNventa.Text + "'";
            int n = 0;
            MySqlConnection conn = CConexion.establecerConexion();
            MySqlCommand con = new MySqlCommand();
            con.Connection = conn;
            con.CommandText = buscar;
            try
            {
                MySqlDataReader leer = con.ExecuteReader();
                if (leer.Read())
                {


                    txtRTN.Text = leer.GetString(3);

                    leer.Close();
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show("Codigo de Pedido no valido");

            }
            conn.Clone();
        }
        public void imprimirVenta()
        {
            int contador = 0;//intentamos saber cuantos registros van en un ahoja
            //tomar fecha
            // DateTime fecha = DateTime.Now;
            DateTime fecha = dtpFecha.Value;
            


            string archivo = "ejemplo";
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = archivo + ".pdf";// le damos el formato al archivo

            // usamos la plantilla de html para inventario
            string pageHTML = Properties.Resources.plantillaFactura.ToString();
            //string pageHTML = "<table><tr><td>TEXTO TEXTO </td></tr></table>";
            // reemplazo de datos
            //pageHTML = pageHTML.Replace("@TITULODOCUMENTO", "Factura");
            //pageHTML = pageHTML.Replace("@TITULO", "Factura");
            pageHTML = pageHTML.Replace("@RTN", txtRTN.Text);
            pageHTML = pageHTML.Replace("@CLIENTE", txtCliente.Text);
            pageHTML = pageHTML.Replace("@EMPLEADO", txtNombreEmp.Text);
            //pageHTML = pageHTML.Replace("@DIRECCION", txtIdEmpleado.Text);
            //pageHTML = pageHTML.Replace("@TEL", txtNombreEmp.Text);

            pageHTML = pageHTML.Replace("@NVenta", txtNventa.Text);
            pageHTML = pageHTML.Replace("@FECHAVENTA", fecha.ToString());

            string datos = string.Empty;
            double valor = 0;
            string headerTable = string.Empty;
            headerTable += "<thead>";
            headerTable += "<tr>";
            headerTable += "<th>" + "Producto" + "</th>";
            headerTable += "<th>" + "Cantidad" + "</th>";
            headerTable += "<th>" + "Precio Unitario" + "</th>";
            headerTable += "</tr>";
            headerTable += "</thead>";
            pageHTML = pageHTML.Replace("@HEADERS", headerTable);


            
            int filas = dgvProductos.Rows.Count;
            for (int i=0; i<filas -1; i++)
            {
                

                datos += "<tr>";
                datos += "<td>" + dgvProductos.Rows[i].Cells[1].Value.ToString() + "</td>";//producto
                datos += "<td>" + dgvProductos.Rows[i].Cells[3].Value.ToString() + "</td>";//cantidad
                datos += "<td>" + dgvProductos.Rows[i].Cells[4].Value.ToString() + "</td>";//precio
                datos += "</tr>";
                //valor = Producto.total;
                //contador++;


            }



            // pageHTML = pageHTML.Replace("@HEADERS", headerTable);
            pageHTML = pageHTML.Replace("@DATOS", datos);

            pageHTML = pageHTML.Replace("@SUBT", txtStotal.Text);
            pageHTML = pageHTML.Replace("@ISV", txtIsv.Text);
            pageHTML = pageHTML.Replace("@TOTAL", txtTotal.Text);
            
           // pageHTML = pageHTML.Replace("@COMENTARIOS", txtDescripcion.Text);
            //---------------------------------------------------------------------

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    
                    Document pdfDoc = new Document(PageSize.A6, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    //pdfDoc.Add(new Paragraph(pageHTML));
                   
                    using (StringReader sr = new StringReader(pageHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();

                    stream.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al crear Reporte del pedido");
            }
        }

        private void btnImprimirPedido_Click(object sender, EventArgs e)
        {
            imprimirVenta();
        }

        private void txtNcompra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
