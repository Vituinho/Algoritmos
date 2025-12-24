using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora do Vituinho");

            Console.WriteLine("Digite o Primeiro Numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Operação que você quer");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int Operacao = int.Parse(Console.ReadLine());
            double resultado = 0;

            switch (Operacao)
            {
                case 1:
                    resultado = (num1 + num2);
                    break;
                case 2:
                    resultado = (num1 - num2);
                    break;
                case 3:
                    resultado = (num1 * num2);
                    break;
                case 4:
                    resultado = (num1 / num2);
                    break;
            }
            Console.WriteLine($"Resultado da Conta é {resultado}");
        }
    }
}
