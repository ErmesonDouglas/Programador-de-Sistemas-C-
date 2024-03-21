using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achei_os_nomes_for_and_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerador de nomes automaticos");
            string[] nomes = new string[] { "Maria", "João", "Ana", "Pedro", "Carla", "Rafael", "Sofia", "Luís", "Mariana", "Tiago", "Catarina", "Gustavo", "Beatriz", "Rodrigo", "Laura", "Guilherme", "Juliana", "Rui", "Isabela", "Fernando", "Alice", "Carlos", "Bianca", "Alexandre", "Camila", "Ricardo", "Vitória", "André", "Gabriela", "Paulo", "Letícia", "Hugo", "Natália", "Miguel", "Érica", "Francisco", "Jéssica", "Daniel", "Vanessa", "Diogo", "Aline", "Tiago", "Amanda", "David", "Carolina", "Samuel", "Diana", "Leonardo", "Inês", "Gustavo", "Patrícia", "Lucas", "Débora", "Fábio", "Renata", "Eduardo", "Tatiana", "Marco", "Priscila", "Felipe", "Larissa", "Roberto", "Thaís", "Diego", "Mônica", "Vinícius", "Daniela", "Joaquim", "Nathalia", "Paulo", "Marina", "Antônio", "Flávia", "Luis", "Juliana", "José", "Tatiane", "André", "Fabiana", "Sérgio", "Giovanna", "Hélio", "Verônica", "Rogério", "Luciana", "Marcelo", "Isabel", "Guilherme", "Priscila" };
            string[] sobrenomes = new string[] { "Silva", "Santos", "Oliveira", "Pereira", "Almeida", "Costa", "Rodrigues", "Martins", "Ferreira", "Sousa", "Pinto", "Carvalho", "Mendes", "Gomes", "Lopes", "Marques", "Ribeiro", "Alves", "Fernandes", "Moreira", "Castro", "Nunes", "Cardoso", "Vieira", "Monteiro", "Araújo", "Rocha", "Ramos", "Barbosa", "Neves", "Teixeira", "Correia", "Mota", "Melo", "Cunha", "Jesus", "Dias", "Antunes", "Lourenço", "Henriques", "Moura", "Reis", "Baptista", "Pinheiro", "Garcia", "Coelho", "Afonso", "Fonseca", "Leal", "Vaz", "Magalhães", "Duarte", "Gonçalves", "Santana", "Miranda", "Lima", "Azevedo", "Freitas", "Figueiredo", "Barros", "Machado", "Borges", "Serra", "Osório", "Rangel", "Fidalgo", "Pacheco", "Xavier", "Vargas", "Figueira", "Rocha", "Brito", "Braga", "Veiga", "Bessa", "Guedes", "Macedo", "Quintana", "Mendes", "Rangel", "Benevides", "Ferreira", "Viana", "Ávila", "Alarcón", "Vasconcelos" };
            Console.WriteLine("Digite 1 para gerar um nome aleatorio ou 0 zero sair");
            while (true)
            {
                int resposta = int.Parse(Console.ReadLine());
                if(resposta == 0)
                {
                    break;
                }
                Random aleatorios = new Random();
                for (int i = 0; i < 1; i++)
                {
                   
                    int randomIndex = aleatorios.Next(nomes.Length);
                    string randomName = nomes[randomIndex];
                    string randomsobreName = sobrenomes[randomIndex];
                    Console.WriteLine(randomName + " " + randomsobreName);
                }
            }
        }
    }
}
