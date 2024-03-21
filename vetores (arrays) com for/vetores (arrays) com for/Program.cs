using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores__arrays__com_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] numeros = new int[5];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° numero:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j = 0; j < numeros.Length; j++)
            {
                Console.WriteLine("numero(" + (j+1) + "): " + numeros[j]);
            }
                int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("A Soma Dos Numeros é:");
                soma = soma + numeros[i];
            }
        }
    }
}
