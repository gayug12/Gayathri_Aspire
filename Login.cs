namespace Employee
{
    public class Login
    {
        private string correctUsername = "admin";
        private string correctPassword = "password123";

        // Method to handle the login process
        public bool AuthenticateUser()
        {
            bool isLoggedIn = false;

            Console.WriteLine("Please login");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            // Check if the entered username and password match the correct ones
            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successfully completed.");
                isLoggedIn = true;
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }

            return isLoggedIn;
        }
    }
}
