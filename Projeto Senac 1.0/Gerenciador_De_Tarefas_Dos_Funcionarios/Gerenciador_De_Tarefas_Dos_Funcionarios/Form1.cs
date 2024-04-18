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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable(); 
        public Form1()
        {
            InitializeComponent();
        }
        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {}
        private void pictureBox1_Click(object sender, EventArgs e)
        {}
        private void label3_Click(object sender, EventArgs e)
        {label3.BackColor = System.Drawing.Color.Transparent;}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string senha = tbxSenha.Text; 
            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Usuario ou senha inválidos","error404");
                return;
            }
            
            string sql = "SELECT * FROM usuarios WHERE usuario = '" +usuario+ "' AND senha = '" +senha+ "'";
            dt = BancoDados.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                long setorLong = dt.Rows[0].Field<long>("setor");
                int setor = (int)setorLong; // Convertendo de Int64 para int

                if (setor == 1)
                {
                    Gerencia g = new Gerencia();
                    g.Show();
                }
                else if (setor == 2)
                {
                    AddTarefas add = new AddTarefas();
                    add.Show();
                }
                // Adicione mais condições conforme necessário
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos", "error404");
                }
            }
        }
    }
}
