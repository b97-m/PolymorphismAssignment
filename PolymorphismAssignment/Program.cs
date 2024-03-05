using System;

public class Program
{
    // The Main method is the entry point of the application
    static void Main()
    {
        // Create an Employee object and call the Quit method
        new Employee("John", "Doe").Quit();

        // Keep the console window open
        Console.ReadLine();
    }
}
