using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Definindo as categorias e os itens dentro delas
        var categorias = new Dictionary<string, List<string>>()
        {
            { "Filmes", new List<string> { "O Poderoso Chefão", "O Senhor dos Anéis", "Matrix", "Inception", "Titanic" } },
            { "Carros", new List<string> { "Fusca", "Civic", "Mustang", "Camaro", "Tesla" } },
            { "Países", new List<string> { "Brasil", "EUA", "França", "Japão", "Austrália" } }
        };

        // Instanciando o Random para gerar números aleatórios
        Random random = new Random();

        // Sorteando a categoria
        var categoriasList = new List<string>(categorias.Keys);
        string categoriaSorteada = categoriasList[random.Next(categoriasList.Count)];

        // Sorteando um item da categoria sorteada
        var itensCategoria = categorias[categoriaSorteada];
        string itemSorteado = itensCategoria[random.Next(itensCategoria.Count)];

        // Exibindo o resultado
        Console.WriteLine($"A categoria sorteada é: {categoriaSorteada}");
        Console.WriteLine($"O nome sorteado da categoria é: {itemSorteado}");
    }
}
