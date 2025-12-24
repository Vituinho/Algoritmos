using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_do_ChatGPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10];
            int[] pares = new int[10];
            int npares = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º Numero: ");
                n1[i] = int.Parse(Console.ReadLine());

                if (n1[i] % 2 == 0)
                {
                    pares[npares] = n1[i];
                    npares++;
                }
            }

            Console.WriteLine("\n\nVetor com números pares:");
            for (int i = 0; i < npares; i++)
            {
                Console.Write($"[{pares[i]}]" + " ");
            }

            Console.WriteLine($"Existem {npares} numeros pares");
        }
    }
}
