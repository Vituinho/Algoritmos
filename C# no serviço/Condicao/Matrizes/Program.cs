using System;

namespace Matrizes
{
    internal class Program
    {
        static string[,] matriz = new string[3, 3];
        static int[,] ocupadas = new int[3, 3];
        static int turnos = 0;
        static string vezjogador;
        static int placarX, placar0, Empates = 0;


        static void Main()
        {
            int contador = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = contador.ToString();
                    ocupadas[i, j] = 0;
                    contador++;
                }
            }
            JogarPartida();
        }
        static void ExibirNaTela()
        {
            Console.WriteLine("--------- Placar ----------");
            Console.WriteLine($"Jogador X: {placarX} Jogador O: {placar0} Empates: {Empates}");
            Console.WriteLine("------------------------------------\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|{matriz[i, j]}");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }
        static void JogadorX()
        {
            int jogadaValida = 0;
            string entrada;
            vezjogador = "X";
            turnos++;

            do
            {
                Console.WriteLine("\n Jogador X, Escolha uma posição (1 a 9): ");
                entrada = Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matriz[i, j] == entrada && ocupadas[i, j] == 0)
                        {
                            matriz[i, j] = "X";
                            ocupadas[i, j] = 1;
                            jogadaValida = 1;
                            break;
                        }
                    }
                }
                if (jogadaValida == 0)
                {
                    Console.WriteLine("Jogada Inválida! Tente Novamente");
                }
            } while (jogadaValida == 0);
            Console.Clear();
            ExibirNaTela();
        }
        static void JogadorO()
        {
            int jogadaValida = 0;
            string entrada;
            vezjogador = "O";
            turnos++;
            do
            {
                Console.WriteLine("\n Jogador O, Escolha uma posição (1 a 9): ");
                entrada = Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matriz[i, j] == entrada && ocupadas[i, j] == 0)
                        {
                            matriz[i, j] = "O";
                            ocupadas[i, j] = 1;
                            jogadaValida = 1;
                            break;
                        }
                    }
                }
                if (jogadaValida == 0)
                {
                    Console.WriteLine("Jogada Inválida! Tente Novamente");
                }
            } while (jogadaValida == 0);
            Console.Clear();
            ExibirNaTela();
        }
        static void JogarPartida()
        {
            string vencedor = "";
            turnos = 0;
            PreencherMatriz();
            Console.Clear();
            ExibirNaTela();

            while (vencedor == "" && turnos < 9)
            {
                JogadorX();
                vencedor = VerificarVencedor();
                if (vencedor != "" || turnos == 9) break;

                JogadorO();
                vencedor = VerificarVencedor();
                if (vencedor != "" || turnos == 9) break;
            }

            if (vencedor == "X")
            {
                Console.WriteLine("Vitória do Jogador X");
                placarX++;
            }
            else if (vencedor == "O")
            {
                Console.WriteLine("Vitória do Jogador O");
                placar0++;
            }
            else
            {
                Console.WriteLine("Empate!");
                Empates++;
            }

            Console.Write("\nDeseja jogar novamente? (s/n): ");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                Console.Clear();
                JogarPartida();
            }
            else
            {
                Console.WriteLine("Obrigado por jogar!");
            }
        }
        static void PreencherMatriz()
        {
            int contador = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = contador.ToString();
                    ocupadas[i, j] = 0;
                    contador++;
                }
            }
        }
        static string VerificarVencedor()
        {
            // Verificar linhas e colunas
            for (int i = 0; i < 3; i++)
            {
                // Verificar linhas
                if (matriz[i, 0] != "" && matriz[i, 0] == matriz[i, 1] && matriz[i, 1] == matriz[i, 2])
                {
                    return matriz[i, 0];
                }

                // Verificar colunas
                if (matriz[0, i] != "" && matriz[0, i] == matriz[1, i] && matriz[1, i] == matriz[2, i])
                {
                    return matriz[0, i];
                }
            }

            // Verificar diagonal principal
            if (matriz[0, 0] != "" && matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
            {
                return matriz[0, 0];
            }

            // Verificar diagonal secundária
            if (matriz[0, 2] != "" && matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
            {
                return matriz[0, 2];
            }

            // Se ninguém venceu
            return "";

        }
    }
}


