using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgsenac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //configuracao 1o jogador "mago"
            int vidaJ1 = 43;
            int ataqueJ1 = 8;
            int defesaJ1 = 2;
            int defesaJ1T = defesaJ1; 
            //configuracao 2o jogador "guerreiro"
            int vidaJ2 = 50;
            int ataqueJ2 = 5;
            int defesaJ2 = 3;
            int defesaJ2T = defesaJ2;
            //inicio da repetiçao
            while (vidaJ1 > 0 && vidaJ2 > 0)
            {
                //ação do jogador 1
                string acao = "";
                do
                {
                    Console.WriteLine("--Turno do Player1: (Mago)-- ");
                    Console.WriteLine("1. Ataque");
                    Console.WriteLine("2. Defesa");
                    acao = Console.ReadLine();
                } while(acao != "1" && acao != "2");
                //verificar ação
                if(acao == "1")
                {
                    //se ataque calcular poder de atk
                    //calcular fator aleatorio (1 a 10)
                    Random numAleatorio = new Random();
                    int fAleatorio = numAleatorio.Next(90, 111);
                    int ataqueJ1T = (ataqueJ1 * fAleatorio) / 100;


                    Console.WriteLine($"Você Atacou o Inimigo com Força: {ataqueJ1T}!");
                    //verificar se poder de ataque J1 > def J2
                    if(ataqueJ1T > defesaJ2T)
                    {
                        //se sim, diminuir a vida
                        vidaJ2 = vidaJ2 - (ataqueJ1T - defesaJ2T);
                        Console.WriteLine("A Vida do Player2 (Guerreiro é: " + vidaJ2);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Ataque Falhou");
                    }
                }
                //se defesa calcular o poder de defesa
                else if(acao == "2")
                {
                    Random numAleatorio = new Random();
                    int fAleatorio = numAleatorio.Next(90, 121);
                    defesaJ1T = (defesaJ1 * fAleatorio) / 100;
                    Console.WriteLine($"Você Tem Uma Ótima Defesa: {defesaJ1T}!");
                    Console.WriteLine(" ");
                }
                
               
                //verificar se os jogadores possuem pontos de vida
                if (vidaJ1 <= 0 || vidaJ2 <= 0)
                {
                    Console.WriteLine("Game Over.");
                    Console.WriteLine(" ");
                }
                //defesa volta aos valores padrões
                defesaJ2T = defesaJ2;
                //prox turno
                //.........................................................................
                //.........................................................................
                //.........................................................................
                //.......................................................................
                //ação do jogador 2
                if (vidaJ2 > 0)
                {
                    acao = "";
                    do
                    {
                        Console.WriteLine("--Turno do Player2 (Guerreiro):--");
                        Console.WriteLine("1. Ataque");
                        Console.WriteLine("2. Defesa");
                        acao = Console.ReadLine();
                    } while (acao != "1" && acao != "2");
                    //verificar ação
                    if (acao == "1")
                    {
                        //se ataque calcular poder de atk
                        //calcular fator aleatorio (1 a 10)
                        Random numAleatorio = new Random();
                        int fAleatorio = numAleatorio.Next(90, 111);
                        int ataqueJ2T = (ataqueJ2 * fAleatorio) / 100;


                        Console.WriteLine($"Você Atacou o Inimigo com Força: {ataqueJ2T}!");
                        //verificar se poder de ataque J2 > def J1
                        if (ataqueJ2T > defesaJ1T)
                        {
                            //se sim, diminuir a vida
                            vidaJ1 = vidaJ1 - (ataqueJ2T - defesaJ1T);
                            Console.WriteLine("A Vida do Player1 (Mago) é: " + vidaJ1);
                            Console.WriteLine(" ");
                        }
                        else 
                        {
                            Console.WriteLine("Ataque Falhou");
                        }
                    }
                    //se defesa calcular o poder de defesa
                    else if (acao == "2")
                    {
                        Random numAleatorio = new Random();
                        int fAleatorio = numAleatorio.Next(90, 121);
                        defesaJ2T = (defesaJ2 * fAleatorio) / 100;
                        Console.WriteLine($"Você Tem Uma Ótima Defesa: {defesaJ2T}!");
                        Console.WriteLine(" ");
                    }
                    //defesa volta aos valores padrões
                    defesaJ1T = defesaJ1;

                    //verificar se os jogadores possuem pontos de vida
                    if (vidaJ1 <= 0 || vidaJ2 <= 0)
                    {
                        Console.WriteLine("Game Over.");
                        Console.WriteLine(" ");
                    }
                }
            }
            if(vidaJ1 <= 0)
            {
                Console.WriteLine("+++  O Player2(Guerreiro) Venceu!!!  +++");
                Console.WriteLine(" ");
            }
            else if (vidaJ2 <= 0)
            {
                Console.WriteLine("+++  O Player1(Mago) Venceu!!!  +++");
                Console.WriteLine(" ");
            }
        }
    }
}
