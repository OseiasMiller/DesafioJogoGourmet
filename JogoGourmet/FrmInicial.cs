using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class FrmInicial : Form
    {
        private Jogo jogo;

        public FrmInicial()
        {
            InitializeComponent();
            jogo = new Jogo();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            jogo.Iniciar();
        }
    }
}
