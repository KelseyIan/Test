using System; // Import the System namespace for Console.WriteLine

public class Person // Define a public class named Person
{
    public string Name { get; set; } // Property to store the person's name

    public Person(string name) // Constructor: runs when you create a new Person
    {
        Name = name; // Set the Name property to the value passed in
    }

    public void SayHello() // Method to greet using the person's name
    {
        Console.WriteLine($"Hello, my name is {Name}."); // Print a greeting to the console
    }
}
