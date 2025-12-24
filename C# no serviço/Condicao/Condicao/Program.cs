using System;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Security.Principal;
using Condicao;
namespace ClassesObjetos
{
    class Program
    {

        static void Main(string[] args)
        {
            #region
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Victor";
            p1.sobrenome = "Emanuel";
            p1.anoNascimento = 2009;

            Pessoa p2 = new Pessoa()
            {
                nome = "Heros",
                sobrenome = "Emanuel",
                anoNascimento = 2009
            };

            p2.nome = "Enzo";
            p2.sobrenome = "Hisashi";
            p2.anoNascimento = 2009;

            Console.WriteLine($"Pessoa 1: {p1.nome}");
            Console.WriteLine($"Pessoa 1: {p1.sobrenome}");
            Console.WriteLine($"Pessoa 1: {p1.anoNascimento}");
            p1.Cumprimentar();

            Console.WriteLine();

            Console.WriteLine($"Pessoa 2: {p2.nome}");
            Console.WriteLine($"Pessoa 2: {p2.sobrenome}");
            Console.WriteLine($"Pessoa 2: {p2.anoNascimento}");
            p2.Cumprimentar();

            Console.ReadKey();

            
        }
    }
    class MinhaClasse
    {
        
    }
    class OutraClasse
    {

    }
}
