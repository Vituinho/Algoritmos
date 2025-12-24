using System;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int i, j, aux;

            // Entrada de dados
            for (i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            // Ordenação
            for (i = 0; i < 9; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }

            // Saída dos dados ordenados
            Console.WriteLine("\nVetor ordenado em ordem crescente:");
            for (i = 0; i < 10; i++)
            {
                Console.Write($"[{vet[i]}] ");
            }

            Console.ReadKey();
        }
    }
}
