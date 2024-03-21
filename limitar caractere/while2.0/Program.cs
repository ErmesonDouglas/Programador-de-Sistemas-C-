using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace while2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um usuário com no minimo 1 caractere. " +
                 "E uma senha com mais de 6 caracteres");
            string usuario = "";
            string senha = "";
            var rg = new Regex(@" ");
            var snh = new Regex(@" ");
            do
            {
                Console.WriteLine("Digite o usuário: ");
                usuario = Console.ReadLine();
            } while (usuario.Length == 0 || rg.IsMatch(usuario));
            do
            {
                Console.WriteLine("Digite a senha: ");
                senha = Console.ReadLine();
            } while (senha.Length < 6 || snh.IsMatch(senha));
            




        }
    }
}
