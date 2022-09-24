namespace ConsoleApp
{
    class User
    {
        Printer printer;
        ConsoleColor textColor;
        string _message;

        public string Message { get { return _message; } }

        public User(Printer printer)
        {
            this.printer = printer;
            this.textColor = Constants.userTextColor;
            this._message = "PLACEHOLDER";
        }
        public bool DidGetInput()
        {
            Printer p = this.printer;
            p.SetFGColor(this.textColor);
            p.Write(Constants.userInputTag);
            
            try { _message = p.Read(); }
            catch (Exception ex)
            {
                p.SetFGColor(Constants.errorTextColor);
                p.Write("Error reading input:\n" + ex.Message);
                Console.ResetColor();
                return false;
            }

            if ( _message.Equals(string.Empty) ) { return false; }

            return true;
        }
    }
}
