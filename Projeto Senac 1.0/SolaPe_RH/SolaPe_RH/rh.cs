using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolaPe_RH
{
    public partial class rh : Form
    {
        public rh()
        {
            InitializeComponent();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void controleDePontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ponto ponto = new Ponto(); 
            ponto.Show();
        }
    }
}
