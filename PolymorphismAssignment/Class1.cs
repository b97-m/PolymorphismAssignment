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

    // Constructor that sets the employee's name
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Implements the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"Employee {FirstName} {LastName} has quit the job.");
    }
}
