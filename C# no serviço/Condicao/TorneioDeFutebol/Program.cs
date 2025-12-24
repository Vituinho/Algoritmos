using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioDeFutebol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos time você quer que seja?");
            int quantidade = int.Parse(Console.ReadLine());

            string[] times = new string[quantidade];

            for (int i = 0; i < times.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}o. time: ");
                times[i] = Console.ReadLine();
            }

            for (int i = 0; i < times.Length; i++)
            {
                for (int j = 0; j < times.Length; j++) 
                {
                    if (i != j)
                    {
                        Console.WriteLine($"{times[i].PadRight(12)} [] x [] {times[j]}");
                    }

                }
            }

        }
    }
}
