using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for(int i = 1; i <=10 ; i++)
            {
                Console.WriteLine(i);
            }
            string[] nomes = {"André","Carla","Daniel","Lucas"};

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }*/
            Console.WriteLine("Tabuada de 0 a 10");
            Console.WriteLine(" ");
            Console.WriteLine("Digite um Número");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int cont = 0; cont <= 10; cont++)
            {
                int produto = n * cont;
                Console.WriteLine(n + " X " + cont + " = " + produto);
            }
        }   
    }
}
