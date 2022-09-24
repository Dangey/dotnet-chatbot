namespace ConsoleApp
{
    class Chatbot
    {
        Printer printer;
        ConsoleColor textColor;

        public Chatbot(Printer printer)
        {
            this.printer = printer;
            this.textColor = Constants.chatbotTextColor;
        }

        public void Respond()
        {
            Printer p = this.printer;
            p.SetFGColor(this.textColor);
            p.Write("\nCHATTY:\nOooh interesting! Thanks for saying that!\n");
        }
    }
}