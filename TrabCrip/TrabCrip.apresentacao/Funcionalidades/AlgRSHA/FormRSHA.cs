using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabCrip.Infra;

namespace TrabCrip.apresentacao.Funcionalidades.AlgRSHA
{
    public partial class FormRSHA : Form
    {
        byte[] textocifrado;
        byte[] textoDecifrado;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public FormRSHA()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            lbEncrip.Items.Add(RSHA.getRSHA(txtTexto.Text));

            MessageBox.Show("RSA Gerado : "+ ByteConverter.GetString(RSHA.RSAGerado()));        
        }

        private void btnDecriptar_Click(object sender, EventArgs e)
        {
            lbDecript.Items.Add(ByteConverter.GetString(RSHA.TextoAntesCriptografia()));
        }
    }
}
