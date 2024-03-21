using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_numeros
{
    internal class Program
    {
        static void Main(string[] args)
    {
            Console.WriteLine("numero 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 2");
            int num2  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 3");
            int num3  = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("o maior numero é "+num1);
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("o maior numero é "+num2);
            }
            else if(num3>num1 && num3>num2)
            {
                Console.WriteLine("o maior numero é "+num3);
            }
            {
                Console.ReadLine();
            }
        }

    }
}
