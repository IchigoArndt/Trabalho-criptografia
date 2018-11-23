using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabCrip.apresentacao.Funcionalidades;
using TrabCrip.apresentacao.Funcionalidades.AlgRSHA;
using TrabCrip.apresentacao.Funcionalidades.AlgSHA256;

namespace TrabCrip.apresentacao
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            FormRSA frsa = new FormRSA();
            frsa.Show();
        }

        private void btnSHA_Click(object sender, EventArgs e)
        {
            FormSHA fsh = new FormSHA();
            fsh.Show();
        }

        private void btnRSHA_Click(object sender, EventArgs e)
        {
            FormRSHA rsha = new FormRSHA();
            rsha.Show();
        }
    }
}
