using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_De_Tarefas_Dos_Funcionarios
{
    class BancoDados
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\banco\\BancoDados.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return (dt);
                }
            }
            catch (Exception ex) 
            {
                ConexaoBanco();
                throw ex;
            }
        }
        /////Funções do FORM_Cadastro
        
        public static void Cadastro (Usuario u)
        {
            if(existeUsuario(u))
            {
                MessageBox.Show("Usuário já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO usuarios (nome,usuario,senha,setor) VALUES (@nome,@usuario,@senha,@setor)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@setor", u.setor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário Inserido");
                ConexaoBanco().Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar Novo Usuário");
                ConexaoBanco().Close();
            }
        }

        /////Fim do FORM_Cadastro
       

        ////ROTINAS GERAIS
        public static bool existeUsuario(Usuario u) 
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT usuario FROM usuarios WHERE usuario='"+u.usuario+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if(dt.Rows.Count > 0 ) 
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
