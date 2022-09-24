namespace ConsoleApp
{
    class User
    {
        Printer printer;
        ConsoleColor textColor;

        public User(Printer printer)
        {
            this.printer = printer;
            this.textColor = Constants.userTextColor;
        }
        public string GetInput()
        {
            Printer p = this.printer;
            p.SetFGColor(this.textColor);
            p.Write(Constants.userInputTag);
            return p.Read();
        }
    }
}