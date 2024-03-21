using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ELEIÇÃO");
            int cont = 1;
            int goku = 0;
            int vegeta = 0;
            while(cont <= 3)
            {
                Console.WriteLine("Digite 1 para Goku e 2 para Vegeta: ");
                int voto = Convert.ToInt32(Console.ReadLine());
                if(voto == 1)   
                {
                    goku = goku + 1;
                }
                else if(voto == 2)
                {
                    vegeta = vegeta + 1;
                }
                else if ((voto != 1) && (voto != 2))
                {
                    Console.WriteLine("Voto Inválido");
                }
                cont++;
                
                if (goku > vegeta)
                 {
                     Console.WriteLine("goku ganhou");
                 }
                 else if (vegeta > goku)
                 {
                     Console.WriteLine("vegeta ganhou");
                 }
                
            }
        }
    }
}
