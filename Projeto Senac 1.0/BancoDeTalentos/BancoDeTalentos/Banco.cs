using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BancoDeTalentos
{
    class Banco
    {
        //atributo
        private static SQLiteConnection conexao;
        //metodo conexao banco retorna uma conexao da classe sqliteconnection
        private static SQLiteConnection ConexaoBanco()
        {
            //cria uma conexão do tipo sqliteconnect
            //linkado ao arquivo banco.db
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\Banco_de_Dados\\banco1.db");
            //abrindo conexão utilizando o método open
            conexao.Open();
            //retorna para o arquivo/método que o chamou
            return conexao;
        }
        //método consulta que recebe uma string com o comando sql 
        // e retornar uma tabela de dados
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            //objeto da classe datatable (tabela de dados - formato de c#) 
            DataTable dt = new DataTable();
            //tentar realizar os comandos dentro do try
            try
            {
               //cria um escopo que ao final de sua execução libera recursos automaticamente
               //atraves do metodo dispose() cria um objeto do tipo comando 
               //ConexaoBanco().CreateCommand() = conexao.CreateCommand
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                   //preenche o comando com a string sql
                    cmd.CommandText = sql;
                    //criar um sqlitedataadapter usando o comando e a conexão
                    //faz a pesquisa no banco de dados de dados e salva em da
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    //converte de dataadapter para datatable e preenche o dt
                    da.Fill(dt);
                    //fecha a conexão 
                    ConexaoBanco().Close();
                  //retorna um datatable
                    return dt;
                }
            }
            catch (Exception ex) 
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }
        public static void InserirCurriculo(Curriculo c)
        {
            if(existeNome(c))
            {
                MessageBox.Show("Nome já cadastrado");
                return;
            }
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preencher o comando com a string sql
                    cmd.CommandText = "INSERT INTO t_usuario (nome,telefone,datanascimento,escolaridade,profissao1,profissao2,curso1,curso2) VALUES (@nome,@telefone,@dataNascimento,@escolaridade,@profissao1,@profissao2,@curso1,@curso2)" ;
                    cmd.Parameters.AddWithValue("@nome",c.nome);
                    cmd.Parameters.AddWithValue("@telefone", c.telefone);
                    cmd.Parameters.AddWithValue("@dataNascimento", c.dataNascimento);
                    cmd.Parameters.AddWithValue("@escolaridade", c.escolaridade);
                    cmd.Parameters.AddWithValue("@profissao1", c.profissao1);
                    cmd.Parameters.AddWithValue("@profissao2", c.profissao2);
                    cmd.Parameters.AddWithValue("@curso1", c.curso1);
                    cmd.Parameters.AddWithValue("@curso2", c.curso2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo CUrriculo Cadastrado");
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao gravar curriculo");
                ConexaoBanco().Close();
                //se acontecer algum erro no try exibe a exceção
                throw ex;
            }
        }
        public static bool existeNome(Curriculo c)
        {
            DataTable dt = null;
            bool res = false;
            string sql = "SELECT nome FROM t_usuario WHERE nome = '" + c.nome + "'";


            dt = Banco.consulta(sql);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }
    }
}
