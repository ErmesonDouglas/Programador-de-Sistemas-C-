using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_x_10_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Número");
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
                while(cont <=10 )
            {
                int produto = n * cont;
                Console.WriteLine(n + " X " + cont + " = " + produto);
                cont++;
            }
        }
    }
}
