using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FirmarPDF
{
   public class GenerarXMLtoPDF
    {
        public string PathXML { get; set; } = null;
        public string NombrePDF { get; set; } = null;
        public string RutaSelecPDF { get; set; } = null;

        public GenerarXMLtoPDF(string _PathXML,string _NombrePDF, string _RutaSelecPDF)
        {
            PathXML = _PathXML;
            NombrePDF = _NombrePDF;
            RutaSelecPDF = _RutaSelecPDF;
        }


        public bool CrearPDF()
        {

            try
            {
                Comprobante objetoComprobante;
                string rutaXML = PathXML;

                XmlSerializer ObjetoSerializar = new XmlSerializer(typeof(Comprobante));


                using (StreamReader reader = new StreamReader(rutaXML))
                {
                    //deserializamos el xml
                    objetoComprobante = (Comprobante)ObjetoSerializar.Deserialize(reader);

                }

                //aplicamos razor

                string path = AppDomain.CurrentDomain.BaseDirectory + "/";
                string pathPDF = AppDomain.CurrentDomain.BaseDirectory;
                string pathHTMLTemp = path + "miHtml.html"; //temporal
                string pathHTMLPlantilla = "C:\\Users\\Mario\\Documents\\GitHub\\tesis_facturacion\\proyecto\\modulo_principal\\FirmarPDF\\PlantillasHTML\\plantilla.html";
                string sHtml = File.ReadAllText(pathHTMLPlantilla);
                string resultHtml = "";

                resultHtml = RazorEngine.Razor.Parse(sHtml, objetoComprobante);

                //Console.WriteLine(resultHtml);

                //creamos el archivo temporal
                System.IO.File.WriteAllText(pathHTMLTemp, resultHtml);

                string pathWKHTMLTOPDF = @"C:\Users\Mario\Documents\GitHub\tesis_facturacion\proyecto\modulo_principal\FirmarPDF\wkhtmltopdf\wkhtmltopdf.exe";

                ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
                oProcessStartInfo.UseShellExecute = false;
                oProcessStartInfo.FileName = pathWKHTMLTOPDF;
                oProcessStartInfo.Arguments = @"miHtml.html "+ NombrePDF +".pdf";

                using (Process oProcess = Process.Start(oProcessStartInfo))
                {
                    oProcess.WaitForExit();
                }

                //eliminamos el archivo temporal
                System.IO.File.Delete(pathHTMLTemp); //eliminamos el archivo html temporal que se lleno con los datos que contiene el xml


                System.IO.File.Copy(pathPDF + NombrePDF+".pdf", RutaSelecPDF+@"\" + NombrePDF + ".pdf");

                System.IO.File.Delete(pathPDF + NombrePDF + ".pdf");
                // Console.Read();

                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }

    }
}
