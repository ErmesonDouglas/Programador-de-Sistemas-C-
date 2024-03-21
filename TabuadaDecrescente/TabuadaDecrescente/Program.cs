using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TabuadaDecrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            {
                do
                {


                    var rg = new Regex(@"^[0-9]+$");
                    //expressao composta apenas por numeros
                    string textoN = "";
                    do
                    {
                        Console.WriteLine("Digite o Número de Qual Tabuada Você Deseja: ");
                        textoN = Console.ReadLine();
                    } while (!rg.IsMatch(textoN));
                    int n = Convert.ToInt32(textoN);

                    do
                    {
                        Console.WriteLine("Digite o Número Inicial: ");
                        textoN = Console.ReadLine();
                    } while (!rg.IsMatch(textoN));
                    int n1 = Convert.ToInt32(textoN);
                    
                    do
                    {
                        Console.WriteLine("Digite o Número Final: ");
                        textoN = Console.ReadLine();
                        
                    } while (!rg.IsMatch(textoN) || Convert.ToInt32(textoN) > n1);
                    
                    int n2 = Convert.ToInt32(textoN);  
                    while(n1 >= n2)
                    {
                        Console.WriteLine(n + " X " + n1 + " = " + (n * n1));
                            n1--;
                    }
                    Console.WriteLine("Digite 0 para sair");
                    string sair = Console.ReadLine();
                    if(sair == "0")
                    {
                        continua = false;
                    }

                } while (continua);
                /*O código que você compartilhou é um programa que solicita ao usuário que digite três números: o número da tabuada desejada, o número inicial e o número final.Em seguida, ele imprime a tabuada do número fornecido dentro do intervalo especificado. O programa continuará a pedir entrada até que o usuário digite "0" para sair.

Vamos explicar o código passo a passo:

                1. * *Declaração da variável `continua`**: `bool continua = true;` é usada para controlar a continuação ou saída do loop principal do programa.
                

                2. * *Loop principal `do -while`**: `do { ... } while (continua);` é usado para repetir o código dentro do bloco até que a variável `continua` seja `false`.

3. * *Criação da expressão regular `rg`**: `var rg = new Regex(@"^[0-9]+$");` cria uma expressão regular que valida se uma string contém apenas dígitos de 0 a 9.

4. * *Loop para obter o número da tabuada(`n`)**: `do { ... } while (!rg.IsMatch(textoN));` solicita ao usuário que digite um número e continua pedindo até que a entrada seja um número válido.

5. * *Obtenção dos números inicial(`n1`) e final(`n2`)**: Usando loops semelhantes aos passos anteriores, são obtidos os números inicial e final para a tabuada.

6. * *Cálculo e impressão da tabuada**: O código calcula e imprime a tabuada do número `n` no intervalo de `n1` a `n2`.

7. * *Verificação para continuar ou sair**: O programa solicita ao usuário que digite "0" para sair. Se a entrada for "0", a variável `continua` é definida como `false`, encerrando o loop principal e finalizando o programa.

Este código é um exemplo simples de um programa de tabuada com a capacidade de encerrar quando o usuário desejar.Ele usa expressões regulares para validar as entradas de números.Certifique - se de importar o namespace `System.Text.RegularExpressions` para utilizar a classe `Regex`.*/

            }
        }    
    }
}
