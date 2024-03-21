using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace progressao_geometrica_usando_o_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Progressão Geométrica");
            Console.WriteLine(" ");
            
            Console.WriteLine("Insira o Número Inicial");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a Razão Entre os Termos");
            int razao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o Número de Termos");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
           
            int pg = n1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(pg);
                pg = pg * razao;
            }
        }            
    }
}
