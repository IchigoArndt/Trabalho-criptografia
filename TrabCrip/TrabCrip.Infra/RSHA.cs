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
        static byte[] textoRSA;
        static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        static UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public static string getRSHA(string texto)
        {
            
            textoCifrado = ByteConverter.GetBytes(texto);

            textoRSA = CriptografiaRSA.RSACifra(textoCifrado, rsa.ExportParameters(false),false);

            return AlgSHA.GenerateSHA256String(ByteConverter.GetString(textoRSA));

        }

        public static byte[] TextoAntesCriptografia()
        {
            return textoCifrado;
        }

        public static byte[] RSAGerado()
        {
            return textoRSA;
        }
    }
}
