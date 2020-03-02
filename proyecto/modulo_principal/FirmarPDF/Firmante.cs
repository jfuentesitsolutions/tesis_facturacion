using iTextSharp.text.pdf;
using iTextSharp.text.pdf.security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmarPDF
{
   public class Firmante
    {
        private readonly ValidarCertificado certificado;

        public Firmante(ValidarCertificado certificado)
        {
            this.certificado = certificado;
        }

        public int Firmar(string rutaDocumentoSinFirma, string rutaDocumentoFirmado,bool ArchivoSobrescrito)
        {
            try
            {

                if (ArchivoSobrescrito) {
                    //elimina el archivo exitente si el usuario elije sobrescribir el archivo
                    System.IO.File.Delete(rutaDocumentoFirmado);
                }

                if (!System.IO.File.Exists(rutaDocumentoFirmado))
                {//verifica si ya existe un archivo que ya este firmado atraves de la ruta 

                    using (var reader = new PdfReader(rutaDocumentoSinFirma))
                    {//aqui se puede verificar si es un archivo pdf

                        var certificado = new ValidarCertificado(Directory.GetCurrentDirectory() + "\\..\\..\\..\\ArchivosFacturaElectronica\\certificado_mape.pfx", "1234");
                        var validarPDF = new ValidacionPDF(certificado);
                        int docFirmado = validarPDF.ValidarDocumentoPDF(rutaDocumentoSinFirma);

                        //si es una de las 2 opciones quiere decir que el pdf selecionado ya esta firmado y no se podra volver a firmar
                        if (docFirmado == 0 || docFirmado == 1)
                        {
                            return 2;
                        }


                        using (var writer = new FileStream(rutaDocumentoFirmado, FileMode.Create, FileAccess.Write))
                        using (var stamper = PdfStamper.CreateSignature(reader, writer, '\0', null, true))
                        {
                            var signature = stamper.SignatureAppearance;
                            signature.CertificationLevel = PdfSignatureAppearance.CERTIFIED_NO_CHANGES_ALLOWED;
                            signature.Reason = "Firma del sistema";
                            signature.ReasonCaption = "Tipo de firma: ";

                            var signatureKey = new PrivateKeySignature(certificado.Key, DigestAlgorithms.SHA256);
                            var signatureChain = certificado.Chain;
                            var standard = CryptoStandard.CADES;

                            MakeSignature.SignDetached(signature, signatureKey, signatureChain, null, null, null, 0, standard);
                        }
                    }



                    return 0;
                }
                else {

                    return 3;
                }

                 
            }
            catch (Exception)
            {

                return 1;
            }
        
        }


    }
}
