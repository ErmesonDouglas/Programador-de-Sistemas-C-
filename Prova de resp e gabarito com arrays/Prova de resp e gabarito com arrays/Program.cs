using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_de_resp_e_gabarito_com_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar vetor respostas
            string[] respostas = new string[3];
            //criar vetor gabarito
            string[] gabarito = new string[3] {"a" , "c" , "d"};
            
            //escrever as questões
            Console.WriteLine("Prova Básica de c#");
            Console.WriteLine("Responda com a. b. c. ou d.:");
            Console.WriteLine(" ");
            Console.WriteLine("1. Qual opção contém um comando de estruta de repetição?");
            Console.WriteLine(" ");
            Console.WriteLine("a. for");
            Console.WriteLine("b. int numero");
            Console.WriteLine("c. if");
            Console.WriteLine("d. new string");
            Console.Write("Escolha sua Aternativa: ");
            //a cada questão coletar a resposta
            respostas[0] = Console.ReadLine();

            Console.WriteLine("1. Qual a Última Posição do Vetor" +
                " string[] respostas = new string[3]; ? ");
            Console.WriteLine(" ");
            Console.WriteLine("a. 0");
            Console.WriteLine("b. 1");
            Console.WriteLine("c. 2");
            Console.WriteLine("d. 3");
            Console.Write("Escolha sua Aternativa: ");
            //a cada questão coletar a resposta
            respostas[1] = Console.ReadLine();

            Console.WriteLine("3. Para que Serva o While?");
            Console.WriteLine(" ");
            Console.WriteLine("a. Armazenar Dados");
            Console.WriteLine("b. Instânciar Classes");
            Console.WriteLine("c. Declarar Variável");
            Console.WriteLine("d. Estrutura de Repetição");
            Console.Write("Escolha sua Aternativa: ");
            //a cada questão coletar a resposta
            respostas[2] = Console.ReadLine();

            //verificar quantas respostas estão corretas
            int cont = 0;
            for (int i = 0; i < respostas.Length; i++)
            {
                if (respostas[i] == gabarito[i])
                {
                    cont++;
                }
            }
            //informar qntas respostas estão corretas
            Console.WriteLine("---Você Acertou " + cont + " Questões!!!---");
            Console.WriteLine("Parabéns");
        }
    }
}
