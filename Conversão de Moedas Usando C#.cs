using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_de_Moedas
{
internal class Program
{
static void Main(string[] args)
{
Console.WriteLine("Me fale um Valor em Real (R$) Para converter: ");
double Valor = double.Parse(Console.ReadLine());
Console.WriteLine("Menu de Moedas: ");
Console.WriteLine("1 - dólar ( $ )");
Console.WriteLine("2 - euro ( € )");
Console.WriteLine("3 - iene ( ¥ )");
Console.WriteLine("4 - libra ( £ )");
int Moeda = int.Parse(Console.ReadLine());
double dolar = 5.67;
double euro = 6.30;
double iene = 0.038;
double libra = 7.48;

        switch (Moeda)
        {
            case 1:
                Console.WriteLine($"A Conversão de Real em Dólar é {Valor / dolar:F2}");
                break;
            case 2:
                Console.WriteLine($"A Conversão de Real em Euro é {Valor / euro:F2}");
                break;
            case 3:
                Console.WriteLine($"A Conversão de Real em Iene é {Valor / iene:F2}");
                break;
            case 4:
                Console.WriteLine($"A Conversão de Real em Libra é {Valor / libra:F2}");
                break;
            default:
                Console.WriteLine("Ocorreu um erro");
                break;
        }
        Console.WriteLine("Agora ao contrario, me fale um valor em alguma dessas moedas para converter em real (R$)");
        Console.WriteLine("Menu de Moedas: ");
        Console.WriteLine("1 - dólar ( $ )");
        Console.WriteLine("2 - euro ( € )");
        Console.WriteLine("3 - iene ( ¥ )");
        Console.WriteLine("4 - libra ( £ )");
        int Moeda2 = int.Parse(Console.ReadLine());
        string MoedaEscolhida;
        switch (Moeda2)
        {
            case 1: MoedaEscolhida = "Dolar";
                break;
            case 2:
                MoedaEscolhida = "Euro";
                break;
            case 3:
                MoedaEscolhida = "Iene";
                break;
            case 4:
                MoedaEscolhida = "Libra";
                break;
            default:
                Console.WriteLine("Moeda Inválida.");
                return;
        }
        Console.WriteLine($"Me fale um Valor em {MoedaEscolhida} Para converter para Real (R$): ");
        double Valor2 = double.Parse(Console.ReadLine());

        switch (Moeda2)
        {
            case 1:
                Console.WriteLine($"A Conversão de Real em Dólar é {Valor2 * dolar:F2}");
                break;
            case 2:
                Console.WriteLine($"A Conversão de Real em Euro é {Valor2 * euro:F2}");
                break;
            case 3:
                Console.WriteLine($"A Conversão de Real em Iene é {Valor2 * iene:F2}");
                break;
            case 4:
                Console.WriteLine($"A Conversão de Real em Libra é {Valor2 * libra:F2}");
                break;
            default:
                Console.WriteLine("Ocorreu um erro");
                break;
        }
    }
}
}
