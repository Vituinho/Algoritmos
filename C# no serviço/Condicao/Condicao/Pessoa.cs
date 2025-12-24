using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Pessoa
    {
        // Atributos / Campos / Fields
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // Ano Atual ---> DateTime.Now.Year

        // Métodos simples
        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {nome} {sobrenome} e nasci em {anoNascimento} tenho {DateTime.Now.Year - anoNascimento} anos de idade");
        }
    }
}
