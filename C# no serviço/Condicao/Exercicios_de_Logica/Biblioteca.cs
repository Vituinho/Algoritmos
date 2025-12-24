using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_de_Logica
{
    public class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
            Console.WriteLine("Livro adicionado com sucesso!");
        }
        public bool RemoverLivro(string isbn)
        {
            var livro = livros.FirstOrDefault(l => l.ISBN == isbn);
            if (livro != null)
            {
                livros.Remove(livro);
                Console.WriteLine("Livro removido com sucesso!");
                return true;
            }
            Console.WriteLine("Livro não encontrado.");
            return false;
        }
        public void ListarLivros()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            Console.WriteLine("Lista de livros.");
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
        }
        public void BuscarPorAutor(string autor)
        {
            var encontrados = livros.Where(l => l.Autor.ToLower().Contains(autor.ToLower())).ToList();
            if (encontrados.Count == 0)
            {
                Console.WriteLine("Nenhum livro encontrado para o autor informado.");
                return;
            }
            Console.WriteLine($"Livros do autor {autor}:");
            foreach (var livro in encontrados)
            {
                Console.WriteLine(livro);
            }
        }
    }
}
