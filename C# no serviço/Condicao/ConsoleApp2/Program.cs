using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = 5;
            int N2 = 4;
            int RES;
            RES  = Soma(N1, N2);
            Console.WriteLine($"A soma é {RES}");
        }
        public static int Soma(int A, int B) 
        {
            int S = 0;
            S = A + B;
            return S;
        }
    }
}
