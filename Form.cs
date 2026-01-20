namespace Tsaru{

    class Form{
        public static void GetForm() {
            System.Console.Write("Enter login:");
            string login = Console.Readline()!;
            System.Console.Write("Enter email: ");
            string email = Console.Readline()!;
            System.Console.WtiteLine($"Your name: {login}\nE-mail: {email}");
        }
    }
}