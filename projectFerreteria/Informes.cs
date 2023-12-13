using iTextSharp.text;
using iTextSharp.text.pdf;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.tool.xml;
using SpreadsheetLight;

namespace projectFerreteria
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Dashboard.fChange(new Inventario());
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            //para crear informes en formato PDF
            informePdf();

        }


        public void informePdf()
        {
            int contador= 0;//intentamos saber cuantos registros van en un ahoja
            //tomar fecha
            // DateTime fecha = DateTime.Now;
            DateTime fecha = dtpFecha.Value;



            string archivo = txtNombreArchivo.Text;
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = archivo + ".pdf";// le damos el formato al archivo

            // usamos la plantilla de html para inventario
            string pageHTML = Properties.Resources.plantillaInventario.ToString();
            //string pageHTML = "<table><tr><td>TEXTO TEXTO </td></tr></table>";
            // reemplazo de datos
            pageHTML = pageHTML.Replace("@TITULODOCUMENTO",txtNombreArchivo.Text);
            pageHTML = pageHTML.Replace("@FECHA", fecha.ToString());
            pageHTML = pageHTML.Replace("@USUARIO", "Adner Vasquez");
            pageHTML = pageHTML.Replace("@TITULO", "Informe de Inventario");


           

            string datos = string.Empty;
            double valor = 0;
            string headerTable = string.Empty;
            headerTable += "<thead>";
            headerTable += "<tr>";
            headerTable += "<th>" + "Codigo" + "</th>";
            headerTable += "<th>" + "Nombre" + "</th>";
            headerTable += "<th>" + "Dimension" + "</th>";
            headerTable += "<th>" + "Marca" + "</th>";
            headerTable += "<th>" + "Tipo" + "</th>";
            headerTable += "<th>" + "Cantidad" + "</th>";
            headerTable += "<th>" + "Precio" + "</th>";
            headerTable += "</tr>";
            headerTable += "</thead>";
            pageHTML = pageHTML.Replace("@HEADERS", headerTable);


            // ESTE FOR ES SOLO PARA INVENTARIO
            foreach (var Producto in Inventario.listaP)
            {
                // pageHTML = pageHTML.Replace("@CODIGO",Producto.codigo);
                
                datos += "<tr>";
                datos += "<td>" + Producto.codigo.ToString() + "</td>";
                datos += "<td>" + Producto.nombre.ToString() + "</td>";
                datos += "<td>" + Producto.dimension.ToString() + "</td>";
                datos += "<td>" + Producto.marca.ToString() + "</td>";
                datos += "<td>" + Producto.tipo.ToString() + "</td>";
                datos += "<td>" + Producto.cantidad.ToString() + "</td>";
                datos += "<td>" + Producto.precio.ToString() + "</td>";
                datos += "</tr>";
                valor = Producto.total; 
                contador++;
                
               
            }
            //MessageBox.Show(contador.ToString());
            /*if (contador > 9)
            {
                
                pageHTML = pageHTML.Replace("@HEADERS", headerTable);
            }*/

            // pageHTML = pageHTML.Replace("@HEADERS", headerTable);
            pageHTML = pageHTML.Replace("@TOTAL", valor.ToString());
            pageHTML = pageHTML.Replace("@DATOS", datos);
            pageHTML = pageHTML.Replace("@COMENTARIOS", txtObservaciones.Text);
            //---------------------------------------------------------------------

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 25,25,25,25);
                    //Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                   // pdfDoc.Add(new Phrase("Pdf creado"));
                    using (StringReader  sr = new StringReader(pageHTML))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();

                    stream.Close();
                }
            }

        }

        private void tdpFecha_ValueChanged(object sender, EventArgs e)
        {
            //
            
        }

        
        public void exel()
        {
            SLDocument sl = new SLDocument();
            sl.SetCellValue("A1", "Ejemplo excel");
            sl.SaveAs("Excel.xlsx");
        }
    }
}
