using System;
using System.Security.Cryptography;


namespace TrabCrip.Infra
{
    public class CriptografiaRSA
    {
        static public byte[] RSACifra(byte[] byteCifrado, RSAParameters RSAInfo, bool isOAEP)
        {
            try
            {
                byte[] DadosCifrados;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {   
                    RSA.ImportParameters(RSAInfo);

                    DadosCifrados = RSA.Encrypt(byteCifrado, isOAEP);
                }
                return DadosCifrados;
            }
            catch (CryptographicException e)
            {
                throw new Exception(e.Message);
            }

        }

        static public byte[] RSADecifra(byte[] byteDecifrado, RSAParameters RSAInfo, bool isOAEP)
        {
            try
            {
                byte[] DadosDecifrados;
                
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    
                    RSA.ImportParameters(RSAInfo);

                    DadosDecifrados = RSA.Decrypt(byteDecifrado, isOAEP);
                }
                return DadosDecifrados;
            }
            catch (CryptographicException e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
