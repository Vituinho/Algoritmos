using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = 5;
            int N2 = 4;
            Soma(N1, N2);
        }
        public static void Soma(int A, int B)
        {
            int S = 0;

            S = A + B;
            Console.WriteLine($"A soma vale {S}");
        }
    }
}

