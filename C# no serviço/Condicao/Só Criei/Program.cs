using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Só_Criei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] respostascorretas = new char[5];
            char[] respostasdadas = new char[5];
            string[] nomealunos = new string[3];
            double[] notaalunos = new double[3];
            double mediadaturma = 0;

            Console.WriteLine("PASSO 1 - Cadastro de Gabarito");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Questão {i+1}: ");
                respostascorretas[i] = char.Parse(Console.ReadLine());
            }
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"ALUNO  {i+1}");
                Console.WriteLine("----------------------------");
                Console.Write("Nome: ");
                nomealunos[i] = Console.ReadLine();
                for (int j = 0; j < respostasdadas.Length; j++)
                {
                    Console.Write($"Questão {j + 1}: ");
                    respostasdadas[j] = char.Parse(Console.ReadLine());
                    if (respostasdadas[j] == respostascorretas[j])
                    {
                        notaalunos[i] += 2;
                    }
                }
                double soma = 0;

                for (int k = 0; k < notaalunos.Length; k++)
                {
                    soma += notaalunos[k];
                }
                mediadaturma = soma / notaalunos.Length;
                Console.Clear();
            }
            Console.WriteLine("NOTAS FINAIS");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < nomealunos.Length; i++)
            {
                Console.WriteLine($"{nomealunos[i]} {notaalunos[i]:F1}");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Media da Turma: {mediadaturma:F1}");
        }
    }
}
