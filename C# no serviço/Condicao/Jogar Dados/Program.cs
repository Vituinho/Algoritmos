using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogar_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas Rodadas Você quer que sejam? ");
            int rodada = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nome do primeiro jogador?");
            string jogador1 = Console.ReadLine();
            Console.WriteLine("Qual o nome do segundo jogador?");
            string jogador2 = Console.ReadLine();

            int joga1pontos = 0;
            int joga2pontos = 0;
            string vencedortd;

            for (int cont = 1; cont <= rodada; cont++)
            {
                Random aleatorio = new Random();
                int numero1 = aleatorio.Next(1, 10);
                int numero2 = aleatorio.Next(1, 10);
                string vencedor;
                if (numero1 > numero2)
                {
                    vencedor = jogador1;
                    joga1pontos++;
                }
                else if (numero2 > numero1)
                {
                    vencedor = jogador2;
                    joga2pontos++;
                }
                else
                {
                    vencedor = "Empate";
                }
                    Console.WriteLine($"{jogador1} tirou o numero {numero1} e {jogador2} o numero {numero2}. {vencedor} venceu a rodada {cont}");
                    Console.WriteLine($"Pontos de {jogador1}: {joga1pontos} Pontos de {jogador2}: {joga2pontos}");
                    Console.ReadKey();
            }
            int vencedorpontos;
            if (joga1pontos > joga2pontos)
            {
                vencedortd = jogador1;
                vencedorpontos = joga1pontos;
            }
            else if (joga2pontos > joga1pontos)
            {
                vencedortd = jogador2;
                vencedorpontos = joga2pontos;
            }
            else
            {
                vencedortd = "Empate";
                vencedorpontos = 0;
            }
            Console.WriteLine($"O Vencedor da Partida foi {vencedortd} com {vencedorpontos} Pontos");
        }
    }
}
