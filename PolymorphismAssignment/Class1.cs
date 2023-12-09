using System;

// Define the IQuittable interface with a Quit method
public interface IQuittable
{
    void Quit();
}

// Create an Employee class that inherits from IQuittable
public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize the employee with a first and last name
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Implement the Quit method from the IQuittable interface
    public void Quit() => Console.WriteLine($"{FirstName} {LastName} has quit the job");
}

class Program
{
    static void Main()
    {
        // Create an Employee object and call the Quit method
        new Employee("John", "Doe").Quit();

        // Keep the console window open
        Console.ReadLine();
    }
}