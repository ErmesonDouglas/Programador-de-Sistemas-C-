using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeTalentos
{
    internal class Usuario
    {
        private string usuario = "ermeson";
        private string senha = "123";

       
        public string getUsuario() { return usuario; }
        public void setUsuario(string usuario) { this.usuario = usuario; }
        public string getSenha() { return senha; }
        public void setSenha(string senha) { this.senha = senha; }
    }
}
