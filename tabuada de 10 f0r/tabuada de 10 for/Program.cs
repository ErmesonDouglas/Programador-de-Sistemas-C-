using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace While_and_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n = 0;
        while (n < 10)
        {
            n = n + 1;
        Console.WriteLine(n);

            int i = 1;
            while (i<=1000)
            {
                Console.WriteLine("Feliz Dia Internacional das Mulheres");
                i++;
            }*/

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Tabuada de 10 dos números");
                Console.WriteLine("Escreva um numero:");
                int num = Convert.ToInt32(Console.ReadLine());
                int res = 0;
                Console.WriteLine("aqui está seu resultado");
                while (res < 10)
                {
                    Console.WriteLine(num * (res + 1));
                    res++;
                }
                Console.WriteLine("Deseja continuar? sim ou nao");
                string resposta = Console.ReadLine();
                if (resposta == "nao")
                {
                    continuar = false;
                }
            }
        }

    }
}
