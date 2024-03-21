using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numero 1");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 2"); 
            int numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("o maior é " + numero1);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("o maior é " + numero2);
            }
            else 
                Console.WriteLine("os numeros são iguais");
            {
                Console.ReadLine();

            }
        }

            
        
    }
}
