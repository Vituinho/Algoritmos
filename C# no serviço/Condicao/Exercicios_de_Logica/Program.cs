using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_de_Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            while (true)
            {
                Console.WriteLine("\nSistema de Biblioteca");
                Console.WriteLine("1 - Adicionar livro");
                Console.WriteLine("2 - Remover livro");
                Console.WriteLine("3 - Listar livros");
                Console.WriteLine("4 - Buscar por autor");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();
                        Console.Write("Ano: ");
                        int ano = int.Parse(Console.ReadLine());
                        Console.Write("ISBN: ");
                        string isbn = Console.ReadLine();

                        Livro novoLivro = new Livro(titulo, autor, ano, isbn);
                        biblioteca.AdicionarLivro(novoLivro);
                        break;

                    case "2":
                        Console.Write("Digite o ISBN do livro para remover: ");
                        string isbnRemover = Console.ReadLine();
                        biblioteca.RemoverLivro(isbnRemover);
                        break;

                    case "3":
                        biblioteca.ListarLivros();
                        break;

                    case "4":
                        Console.Write("Digite o nome do autor para buscar: ");
                        string autorBusca = Console.ReadLine();
                        biblioteca.BuscarPorAutor(autorBusca);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
