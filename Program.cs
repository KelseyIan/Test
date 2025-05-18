using System; // Import the System namespace for basic functionality

class Program // Define the Program class (the entry point of your app)
{
    static void Main(string[] args) // Main method: where the program starts
    {
        Console.Write("Enter your name: "); // Ask the user to enter their name
        string name = Console.ReadLine() ?? ""; // Read user input from the console

        Person person = new Person(name); // Create a new Person object with the user's name
        person.SayHello(); // Call the SayHello method to greet the user
    }
}
