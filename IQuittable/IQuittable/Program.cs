//Define the IQuittable interface
public interface IQuittable
{
    void Quit();
}

//Define the Employee class and inherit the IQuittable interface
public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit() method for the Employee class
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} is quitting the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Create an object of type IQuittable and call the Quit() method
        Employee employee = new Employee
        {
            FirstName = "John",
            LastName = "Doe"
        };

        IQuittable quittable = employee; // Using polymorphism

        quittable.Quit(); // This will call the Quit() method of the Employee class

        // Keep the console window open
        Console.ReadLine();
    }
}
