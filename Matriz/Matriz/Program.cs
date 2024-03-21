using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("SOMA DE DUAS MATRIZES");
             int[,] numeros = new int[3,2]; //matriz 1
             numeros[0,0] = 1;      
             numeros[0,1] = 2;
             numeros[1,0] = 10;
             numeros[1,1] = 20;
             numeros[2,0] = 100;
             numeros[2,1] = 200;

             int[,] numeros2 = new int[3, 2] { { 9, 8 }, { 7, 6 }, { 5, 4 } }; // matriz 2

             int[,] resultado = new int[3, 2]; //resultado da soma

             //Console.WriteLine(numeros[2,0]);
             //Console.WriteLine(numeros[2,1]);
             Console.WriteLine(" ");
             Console.WriteLine("MATRIZ 1");
             for (int l = 0; l< 3; l++)
             {
                 for(int c=0; c<2; c++)
                 {
                     Console.Write(numeros[l,c]);
                     Console.Write("\t");
                 }
                 Console.WriteLine();            
             }
             Console.WriteLine(" ");
             Console.WriteLine("MATRIZ 2");
             for (int l = 0; l < 3; l++)
             {
                 for (int c = 0; c < 2; c++)
                 {
                     Console.Write(numeros2[l, c]);
                     Console.Write("\t");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine(" ");
             Console.WriteLine("RESULTADO DA SOMA:");
             for (int l = 0; l < 3; l++)
             {
                 for (int c = 0; c < 2; c++)
                 {
                     resultado[l,c] = numeros[l,c] + numeros2[l,c];
                     Console.Write(resultado[l,c]);
                     Console.Write("\t");
                 }
                 Console.WriteLine();
             }*/
            int[,] notamedia = new int[4, 4];
            int[,] notas = new int[4, 4]
            {
                { 7,8,6,4},
                { 9,5,8,7},
                { 10,9,10,5},
                { 10,8,8,7}
            };
            Console.WriteLine("MATRIZ");
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(notas[l, c]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            
            int cont = 0;
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (notas[l,c] >= 7)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Notas Acima da Média:" + cont);
        }
    }
}
