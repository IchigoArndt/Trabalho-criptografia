using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrabCrip.Infra
{
    public class RSHA
    {
        static byte[] textoCifrado;
        static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        static UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public static byte[] getRSHA(string texto)
        {
            
            textoCifrado = ByteConverter.GetBytes(AlgSHA.GenerateSHA256String(texto));

            return CriptografiaRSA.RSACifra(textoCifrado, rsa.ExportParameters(false),false);

        }

        public static byte[] getSHA(byte[] textoCifrado)
        {
            return CriptografiaRSA.RSADecifra(textoCifrado, rsa.ExportParameters(true), false);
        }
    }
}
