using InformationSecurity;

class Program
{
    static void Main(string[] args)
    {
        UserAuthenticationSystem authSystem = new UserAuthenticationSystem();

        while (true)
        {
            Console.WriteLine("\n1. Register User");
            Console.WriteLine("2. Authenticate User");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    authSystem.RegisterUser(username, password);
                    break;

                case "2":
                    Console.Write("Enter username: ");
                    string authUsername = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string authPassword = Console.ReadLine();
                    authSystem.AuthenticateUser(authUsername, authPassword);
                    break;

                case "3":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}

