using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_dos_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma dos Números:");
            Console.WriteLine("Digite a quantidade de números desejado");
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 1;
            int soma = 0;
            while (cont <= n)
            {
                Console.WriteLine("Digite um número");
                int num = Convert.ToInt32(Console.ReadLine());
                soma = soma + num;
                cont++; 
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}
