namespace Employee
{
    public abstract class Employees
    {
    public int id{get; set;}
    public string? name {get; set;}
    public string? position {get; set;}
    protected double salary{get; set;}

    public void addDetails()
    {
        Console.WriteLine("Add Employee Details");

        Console.Write("Enter Employee Id: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Position: ");
        position = Console.ReadLine();
        Console.Write("Enter Salary: ");
        salary = double.Parse(Console.ReadLine());
    }
    
    public void editDetails()
    {
        Console.WriteLine("Edit Employee Details:");
        
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Position: ");
        position = Console.ReadLine();
        Console.Write("Enter Salary: ");
        salary = double.Parse(Console.ReadLine());
    }
    public abstract void viewDetails();
    }
}