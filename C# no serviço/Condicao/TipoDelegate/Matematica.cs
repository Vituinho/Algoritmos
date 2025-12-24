using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public void Somar(int num1, int num2)
        {
            Console.WriteLine($"A Soma é {num1 + num2}");
        }
        public void Subtrair(int num1, int num2)
        {
            Console.WriteLine($"A Subtração é {num1 - num2}");
        }
        public void Multiplicar(int num1, int num2)
        {
            Console.WriteLine($"A Multiplicação é {num1 * num2}");
        }
        public void Dividir(int num1, int num2)
        {
            Console.WriteLine($"A Divisão é {num1 / num2}");
        }
    }
}
