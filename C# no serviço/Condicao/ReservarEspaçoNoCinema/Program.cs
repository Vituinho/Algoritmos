using System;

namespace ReservarEspaconoCinema
{
    internal class Program
    {
        static void Main()
        {
            int[] Cadeiras = new int[10];
            int[] RSV = new int[10];
            string r = "S";

            // Inicializa cadeiras e reservas
            for (int i = 0; i < Cadeiras.Length; i++)
            {
                Cadeiras[i] = i;
                RSV[i] = 0;
            }

            while (r.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("Cadeiras disponíveis:");

                // 👉 Mostrar cadeiras
                for (int i = 0; i < Cadeiras.Length; i++)
                {
                    if (RSV[i] == 0)
                    {
                        Console.Write($"[B{i}] ");
                    }
                    else
                    {
                        Console.Write("[--] ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("----------------------");

                // 👉 Perguntar qual cadeira quer reservar
                Console.Write("Quer reservar qual cadeira? B");
                int Re;

                // 👉 Validação se digitou número válido
                while (!int.TryParse(Console.ReadLine(), out Re) || Re < 0 || Re >= Cadeiras.Length)
                {
                    Console.WriteLine("Número inválido. Digite novamente:");
                }

                // 👉 Verificar se está livre
                if (RSV[Re] == 0)
                {
                    RSV[Re] = 1;
                    Console.WriteLine($"Cadeira B{Re} reservada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Desculpe! Essa cadeira já está reservada, tente outro número.");
                }

                // 👉 Perguntar se deseja continuar
                Console.Write("Deseja fazer outra reserva? [S/N]: ");
                r = Console.ReadLine().ToUpper();

                // 👉 Verificar se todas as cadeiras estão reservadas
                bool todasReservadas = true;
                for (int i = 0; i < RSV.Length; i++)
                {
                    if (RSV[i] == 0)
                    {
                        todasReservadas = false;
                        break;
                    }
                }
                if (todasReservadas)
                {
                    Console.WriteLine("Todas as cadeiras estão reservadas!");
                    break;
                }
            }

            // 👉 Mostrar reservas feitas
            Console.WriteLine("\nAs reservas feitas foram:");
            for (int i = 0; i < Cadeiras.Length; i++)
            {
                if (RSV[i] == 1)
                {
                    Console.Write($"[B{i}] ");
                }
            }
            Console.WriteLine("\nObrigado! Tenha uma boa sessão!");
        }
    }
}
