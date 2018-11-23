using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabCrip.Infra;

namespace TrabCrip.apresentacao.Funcionalidades
{
    public partial class FormRSA : Form
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] textoPlano;
        byte[] textoCifrado;
        byte[] textoDecifrado;

        public FormRSA()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                textoPlano = ByteConverter.GetBytes(txtTexto.Text);
                textoCifrado = CriptografiaRSA.RSACifra(textoPlano, RSA.ExportParameters(false), false);
                lbEncrip.Items.Add(ByteConverter.GetString(textoCifrado));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private void btnDecriptar_Click(object sender, EventArgs e)
        {
            try
            {
                textoDecifrado = CriptografiaRSA.RSADecifra(textoCifrado, RSA.ExportParameters(true), false);
                lbDecript.Items.Add(ByteConverter.GetString(textoDecifrado));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }
    }
}
