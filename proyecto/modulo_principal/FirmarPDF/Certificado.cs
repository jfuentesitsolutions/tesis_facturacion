using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.X509;

namespace FirmarPDF
{
    public class Certificado
    {
        public AsymmetricKeyParameter Key { get; private set; }

        public X509Certificate[] Chain { get; private set; }

        public Certificado(string rutaCompletaDelPfx, string claveDelPfx = null)
        {
            using (var file = File.OpenRead(rutaCompletaDelPfx))
            {
                var password = claveDelPfx?.ToCharArray() ?? new char[] { }; //contraseña que posee el alchivo de certificado
                var store = new Pkcs12Store(file, password);
                var alias = GetCertificateAlias(store);

                Key = store.GetKey(alias).Key;
                Chain = store.GetCertificateChain(alias).Select(x => x.Certificate).ToArray();
            }
        }

        private static string GetCertificateAlias(Pkcs12Store store)
        {
            foreach (string currentAlias in store.Aliases)
            {
                if (store.IsKeyEntry(currentAlias))
                {
                    return currentAlias;
                }
            }

            return null;
        }
    }
}
