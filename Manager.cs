namespace Employee{
    public class Manager : Employees
   {
    public override void viewDetails()
    {
        
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {salary}");
       
    }
    
    }
}
