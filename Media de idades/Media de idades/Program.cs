using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_de_idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int smMaiorIdade = 0;
            int contMaiorIdade = 0;
            Console.WriteLine("Informe a idade de uma pessoa (ou digite 0 para finalizar)");
            int idade = int.Parse(Console.ReadLine());
            while(idade != 0)
            {
                if (idade > 18)
                {
                    smMaiorIdade += idade;
                    contMaiorIdade++;
                }
                Console.WriteLine("Informe a idade da próxima pessoa");
                idade = int.Parse(Console.ReadLine());
            }
            if (contMaiorIdade > 0)
            {
                double mediaMaiorIdade = (double)smMaiorIdade / contMaiorIdade;
                Console.WriteLine($"A soma das idades das pessoas maiores de idade é: {smMaiorIdade} ");
                Console.WriteLine($"A média das idades das pessoas maiores de idade é: {mediaMaiorIdade:F2} ");
            }
            else
            {
                Console.WriteLine("Não foram informadas pessoas maiores de idade");
            }*/

            int smMaiorIdade = 0;
            int contMaiorIdade = 0;
            Console.WriteLine("Informe a idade de uma pessoa (ou digite 0 para finalizar)");
            int idade = Convert.ToInt32(Console.ReadLine());
            while (idade != 0)
            {
                if (idade > 18)
                {
                    smMaiorIdade += idade;
                    contMaiorIdade++;
                }

                Console.WriteLine("Digite a Idade da Próxima pessoa");
                idade = Convert.ToInt32(Console.ReadLine());
            }
            if(contMaiorIdade > 0)
            {
                double mediaMaiorIdade = smMaiorIdade / contMaiorIdade;
                Console.WriteLine("A soma das idades dos adultos é: " + smMaiorIdade);
                Console.WriteLine("A média das idades dos adultos é: " + mediaMaiorIdade);
            }
            else
            {
                Console.WriteLine("Não foram informados pessoas maior de idade");
            }
        }
    }
}
