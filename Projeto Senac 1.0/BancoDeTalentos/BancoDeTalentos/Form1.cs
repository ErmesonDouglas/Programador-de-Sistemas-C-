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
    public partial class Form1 : Form
    {
        //cria um objeto dt da classe datatable 
        //esse objeto serivira para armazenar as informações que virao do 
        //banco de dados
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string senha = tbxSenha.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Ususario ou senha incorretos");
                return;
            }
            //comando sql para selecionar todas as colunas da tabela usuario
            //onde o usuario e a senha forem iguais as digitadas na tela de login 
            string sql = "SELECT * FROM t_usuario WHERE usuario = '" +usuario+ "' AND senha = '" +senha+ "'";
            //IDA - chama o método consulta passando a string sql como
            //parâmetro, esse é um método static que pertence a classe banco 
            //VOLTA - retorna a tabela de dados do banco de dados 
            // e salva no dt
            dt = Banco.consulta(sql);
            //conta quantas linhas tem na tabela de dados 
            //e verifica se tem uma linha 
            if (dt.Rows.Count == 1)
            {
                //cria um objeto do tipo dashboard (form) e
                //passar o usuario como parâmetro 
                //dt - tabela de dados 
                //rows[0]=primeira linha
                //itemarray[1] segundo item/coluna da linha
                DashBoard d = new DashBoard(dt.Rows[0].Field<string>("usuario"));
                d.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
