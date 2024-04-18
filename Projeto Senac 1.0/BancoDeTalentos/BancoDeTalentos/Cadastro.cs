using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeTalentos
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Curriculo c = new Curriculo();
            c.nome = tbxNome.Text;
            c.telefone = tbxTelefone.Text;
            c.dataNascimento = dtpData.Text;
            c.escolaridade = cbxEscolaridade.Text;
            c.profissao1 = tbxProfissao1.Text;
            c.profissao2 = tbxProfissao2.Text;
            c.curso1 = tbxCurso1.Text;
            c.curso2 = tbxCurso2.Text;

            Banco.InserirCurriculo(c);
        }
    }
}
