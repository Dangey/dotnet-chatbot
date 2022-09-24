namespace ConsoleApp
{
    class Printer
    {
        public void Init()
        {
            Write(Constants.title + "\nVersion " + Constants.version + "\n\n" + Constants.greeting + "\n");
        }

        public void SetFGColor(ConsoleColor color){ Console.ForegroundColor = color; }

        public void Write(string text){ Console.WriteLine(text); }
        public string Read(){ return Console.ReadLine()?.ToLower() ?? string.Empty; }
    }
}