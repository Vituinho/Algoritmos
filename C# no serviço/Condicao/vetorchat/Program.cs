using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace TimesDeFutebol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] respostaCerta = new char[5];
            char[] respostaAluno = new char[5];
            int[] NotaAluno = new int[3];
            string[] alunos = new string[3];
            double MediaDaTurma = 0;

            Console.WriteLine("PASSO 1 - Cadastro de Gabarito");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < respostaCerta.Length; i++)
            {
                Console.Write($"Questão {i + 1}: ");
                respostaCerta[i] = char.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"ALUNO {i + 1}");
                Console.WriteLine("-----------------");
                Console.Write("Nome: ");
                alunos[i] = Console.ReadLine();
                Console.WriteLine("RESPOSTAS DADAS");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Questão {j + 1}: ");
                    respostaAluno[i] = char.Parse(Console.ReadLine());
                    if (respostaAluno[i] == respostaCerta[i])
                    {
                        NotaAluno[i] += 2;
                    }
                }
            }
            MediaDaTurma = (double)(NotaAluno[0] + NotaAluno[1] + NotaAluno[2]) / 3;
            Console.WriteLine("NOTAS FINAIS");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{alunos[i]} {NotaAluno[i].ToString("F1")}");
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Media da Turma: {MediaDaTurma.ToString("F1")}");

        }
    }
}
