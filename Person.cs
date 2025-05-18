using System; // Import the System namespace for Console.WriteLine

public class Person // Define a public class named Person
{
    public string Name { get; set; } // Property to store the person's name
    public int Age { get; set; } // Property to store the person's age
    public string FavoriteColor { get; set; } // Property to store the person's favorite color

    // Constructor: runs when you create a new Person
    public Person(string name, int age, string favoriteColor)
    {
        Name = name; // Set the Name property to the value passed in
        Age = age; // Set the Age property
        FavoriteColor = favoriteColor; // Set the FavoriteColor property
    }

    // Method to greet using the person's name
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}."); // Print a greeting to the console
        Console.WriteLine($"I am {Age} years old."); // Print the person's age
        Console.WriteLine($"My favorite color is {FavoriteColor}."); // Print the person's favorite color
        Console.WriteLine("How are you?"); // Ask how the user is doing
    }

    // Method to check if the person is an adult
    public bool IsAdult()
    {
        return Age >= 18;
    }

    // Method to change the favorite color
    public void ChangeFavoriteColor(string newColor)
    {
        FavoriteColor = newColor;
        Console.WriteLine($"{Name}'s new favorite color is {FavoriteColor}.");
    }
}
