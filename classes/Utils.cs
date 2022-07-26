namespace er2.classes
{
    static class Utils
    {
        public static void LoadingBar(string texto, int tempo, int quantidade)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(texto);
            for (var contador = 0; contador < quantidade; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);
            }
            Console.ResetColor();
        }
    }
}