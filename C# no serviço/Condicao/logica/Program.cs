using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar Ex: 5,66");
            double dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Me fale um valor em Dólares");
            double valorEmdolar = double.Parse(Console.ReadLine());

            double valorEmreal = (valorEmdolar * dolar);

            Console.WriteLine($"O seu valor em Reais é {valorEmreal}");
        }
    }
}
