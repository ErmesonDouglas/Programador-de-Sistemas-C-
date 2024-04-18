using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_De_Tarefas_Dos_Funcionarios
{
    public partial class Gerencia : Form
    {
        public Gerencia()
        {
            InitializeComponent();
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void Gerencia_Load(object sender, EventArgs e)
        {

        }

        private void adicionarTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTarefas add = new AddTarefas();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTarefas add = new AddTarefas();
            add.Show();
        }
    }
}
