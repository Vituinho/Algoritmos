using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Console.WriteLine("Qual o formato de data que você deseja visualizar?");
            Console.WriteLine("1 - Utilizar minha configuração de sistema: 08/01/2021 20:48:13");
            Console.WriteLine("2 - Formato simples: 08-01-21");
            Console.WriteLine("3 - Formato longo: sexta-feira, 8 de janeiro de 2021");
            Console.WriteLine("4 - Formato longo personalizado: 08-01-2021 08:48:13");
            Console.WriteLine("5 - Formato RFC1123 pattern: Fri, 08 Jan 2021 20:48:13 GMT");
            int formato = int.Parse(Console.ReadLine());
            if (formato > 5 | formato < 1)
            {
                Console.WriteLine("Formato está menor do que 1 ou maior do que 5");
                Console.Clear();
                goto Inicio;
            }
            Console.WriteLine("1 -ENIAC");
            Console.WriteLine("2 - RFC1");
            Console.WriteLine("3 - Alan Turing");
            int formato2 = int.Parse(Console.ReadLine());

            DataConfiguracao.FormatoData(formato);
            DataConfiguracao.FormatoData2(formato2);
        }
    }
    class DataConfiguracao
    {
        public static void FormatoData(int formato)
        {
            switch (formato)
            {
                case 1:
                    Console.WriteLine(DateTime.Now.ToString());
                    break;
                case 2:
                    Console.WriteLine(DateTime.Now.ToString("dd-MM-yy"));
                    break;
                case 3:
                    Console.WriteLine(DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy"));
                    break;
                case 4:
                    Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                    break;
                case 5:
                    Console.WriteLine(DateTime.Now.ToString("R"));
                    break;

            }        
        }
        public static void FormatoData2(int formato2)
        {
            switch (formato2)
            {
                case 1:
                    Console.WriteLine("15 de agosto de 1946 No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                    break;
                case 2:
                    Console.WriteLine("17 de abril de 1969 Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                    break;
                case 3:
                    Console.WriteLine("23 de junho de 1912 Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o \"pai da informática\" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias.Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                    break;
            }
        }
    }
}
