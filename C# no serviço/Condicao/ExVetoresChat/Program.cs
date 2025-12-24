using System;

class LugaresCinema
{
    static string[] B = new string[20]; // índice de 1 a 19, mas o índice 0 não será usado
    static char r;
    static int cad;

    static void MostraFileira()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (string.IsNullOrEmpty(B[i]))
            {
                Console.Write($"[ B{i,2} ]");
            }
            else
            {
                Console.Write("[ --- ]");
            }
        }
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------");
    }

    static void Main()
    {
        do
        {
            Console.Clear();
            MostraFileira();

            Console.Write("Reservar a cadeira: B");
            if (int.TryParse(Console.ReadLine(), out cad) && cad >= 1 && cad <= 19)
            {
                if (string.IsNullOrEmpty(B[cad]))
                {
                    B[cad] = "X";
                    Console.WriteLine($"Cadeira B{cad} RESERVADA!");
                }
                else
                {
                    Console.WriteLine("ERRO: Lugar Ocupado!");
                }
            }
            else
            {
                Console.WriteLine("ERRO: Número inválido!");
            }

            Console.Write("Quer reservar outro? [S/N] ");
            r = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        }
        while (r != 'N');
    }
}
