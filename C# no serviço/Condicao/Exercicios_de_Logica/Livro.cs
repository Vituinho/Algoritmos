using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_de_Logica
{
    public class Livro
    {
        public string Título { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string ISBN { get; set; }

        public Livro(string título, string autor, int ano, string isbn)
        {
            Título = título; ;
            Autor = autor;
            Ano = ano;
            ISBN = isbn;
        }

        public override string ToString()
        {
            return $"{Título} - {Autor} ({Ano}) - ISBN: {ISBN}";
        }
    }
}
