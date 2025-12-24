namespace OlaMundo
{
    internal static class Program
    {
        [STAThread]

        static void Main()
        {
            ApplicationConiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}