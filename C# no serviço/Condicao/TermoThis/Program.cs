using System.ComponentModel.Design;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            if (a.Login("0312011990"))
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else 
            {
                Console.WriteLine("Acesso Negado!");
            }
        }
    }
}
