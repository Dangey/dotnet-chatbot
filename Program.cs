namespace ConsoleApp
{
    class Program
    {
        private Program()
        {
            Printer prt = new Printer();
            Chatbot bot = new Chatbot(prt);
            User user = new User(prt);

            prt.Init();
            Run(bot, user, true);
        }

        static void Run(Chatbot bot, User user, bool isRunning)
        {
            while(isRunning)
            {
                user.GetInput();
                bot.Respond();
            }
        }

        protected static void Cleanup(object ?sender, ConsoleCancelEventArgs args)
        {
            Console.ResetColor();
            Console.WriteLine(Constants.exitMessage);
        }

        static void Main(string[] args)
        {
            // Listener for handling cancellation exit and cleanup
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Cleanup);

            // start program
            new Program();
        }
    }
}
