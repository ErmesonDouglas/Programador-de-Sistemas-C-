using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eleicao_2._0_usando_o_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goku = 0;
            int vegeta = 0;
            Console.WriteLine("ELEIÇÃO");
            for (int cont = 0; cont < 7; cont++)
            {
                Console.WriteLine("Digite 1. Para Goku");
                Console.WriteLine("Digite 2. Para Vegeta");
                int voto = Convert.ToInt32(Console.ReadLine());
                if (voto == 1)
                {
                    Console.WriteLine("Você votou em Goku");
                    goku++;
                }
                if (voto == 2 )
                {
                    Console.WriteLine("Você votou em Vegeta");
                    vegeta++;
                }
            }
            if (goku > vegeta)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Goku Venceu com {0} votos", goku);
            }
            if (vegeta > goku)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Vegeta Venceu com {0} votos",vegeta);
            }
        }
    }
}
