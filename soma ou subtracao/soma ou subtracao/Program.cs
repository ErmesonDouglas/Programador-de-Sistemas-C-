using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while(continuar)
            {
                Console.WriteLine("soma ou subtraçao?");
                   string sm = Console.ReadLine();
                if (sm == "soma")
                {
                    Console.WriteLine("Digite o 1o número");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o 2o número");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int resultado = num1 + num2;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Deseja fazer outro calculo? sim ou nao");
                    string resposta = Console.ReadLine();
                    if (resposta == "nao")
                    {
                        continuar = false;
                    }
                }
                if (sm == "subtraçao")
                {
                    Console.WriteLine("Digite o 1o número");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o 2o número");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    int resultado = num3 - num4;
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Deseja fazer outro calculo? sim ou nao");
                    string resposta = Console.ReadLine();
                    if (resposta == "nao")
                    {
                         continuar = false;
                    }
                 }
                        
            }
        }
    }
}
