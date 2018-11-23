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
            textocifrado = RSHA.getRSHA(txtTexto.Text);
            lbEncrip.Items.Add(ByteConverter.GetString(textocifrado));
        }

        private void btnDecriptar_Click(object sender, EventArgs e)
        {
            textoDecifrado = RSHA.getSHA(textocifrado);
            lbDecript.Items.Add(ByteConverter.GetString(textoDecifrado));
        }
    }
}
