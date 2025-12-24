using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c._cliente = "Gabriel";
            c._saldo = 100;

            Console.WriteLine(c._cliente);
        }
    }
}
