using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            double soma = 0;
            double media = 0;
            Console.WriteLine("Quantos Números Você quer Somar e fazer a Média? (de 3 a 10)");
            int qnt = int.Parse(Console.ReadLine());
    
            if (qnt > 10 | qnt < 3)
            {
                Console.WriteLine("Valor Invalido!");
                Console.WriteLine("\n");
                goto Inicio;
            }

            for (int contagem = 1; contagem <= qnt; contagem++)
            {
                Console.Write($"Digite o {contagem} Numero:");
                double numero = double.Parse(Console.ReadLine());
                
                soma = soma + numero;
                media = soma / qnt;
                
            }
            Console.WriteLine($"O resultado da soma é {soma}");
            Console.WriteLine($"O resultado da média é {media}");
        }
    }
}
