using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] n1 = new double[5];
            double[] n2 = new double[5];
            double[] m = new double[5];
            double MT = 0;
            double SM = 0;
            int tot = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"ALUNO {i}");
                Console.Write($"Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Primeira Nota: ");
                n1[i] = int.Parse(Console.ReadLine());
                Console.Write("Segunda Nota: ");
                n2[i] = int.Parse(Console.ReadLine());
                m[i] = (n1[i] + n2[i]) / 2;
                SM = SM + m[i];
            }
            MT = SM / 4;
            Console.Clear();
            Console.WriteLine("LISTAGEM DE ALUNOS");
            Console.WriteLine("------------------");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"{nome[i],-15} {m[i],4:F1}");
                if (m[i] > MT)
                {
                    tot++;
                }
            }
            Console.WriteLine($"Ao todo temos {tot} alunos acima da média da turma que é {MT}");
        }
    }
}
