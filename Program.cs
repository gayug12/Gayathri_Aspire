namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            bool isLoggedIn = false;

            // Instantiate Manager class (instead of Employees base class)
            Employees employees = new Manager();

            // Instantiate Login class
            Login login = new Login();

            while (!exit)
            {
                
                if (!isLoggedIn)
                {
                    
                    isLoggedIn = login.AuthenticateUser();
                }

                if (isLoggedIn)
                {
                    Console.WriteLine("\nEmployee Details");
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. View Employee");
                    Console.WriteLine("3. Edit Employee");
                    Console.WriteLine("4. Logout");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            // Add employee data
                            employees.addDetails();
                            Console.WriteLine("Details added successfully.");
                            break;

                        case "2":
                            // View employee data
                            Console.WriteLine("\nEmployee Details:");
                            employees.viewDetails();
                            break;

                        case "3":
                            // Edit employee data
                            employees.editDetails();
                            Console.WriteLine("Details updated successfully.");
                            break;

                        case "4":
                            // Logout
                            isLoggedIn = false;
                            Console.WriteLine("Logout successful.");
                            break;

                        default:
                            // Invalid input handling
                            Console.WriteLine("Invalid choice! Please choose 1, 2, or 3.");
                            break;
                    }
                }
            }

            Console.WriteLine("Exiting the program...");
        }
    }
}
