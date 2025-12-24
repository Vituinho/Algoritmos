namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            //m.Cumprimentar();
            //m.Somar(10,5);
            //m.Apresentar("Victor", 15);
            //int valor1 = 100;
            //int valor2 = 100;
            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);
            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            //string nomeCompleto = m.MontaNome("Victor", "Emanuel");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPI();
            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);

            m.Cumprimentar();
            m.Cumprimentar("Victor");
            m.Cumprimentar("Victor", 15);

            bool res1 = m.Comparar(100, 50 * 2);
            bool res2 = m.Comparar("Gabriel", "gabriel");

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
