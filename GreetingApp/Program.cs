// Welcome user to App
using System.ComponentModel;

Console.WriteLine("Welcome to the greeting application");
Console.WriteLine("This application was built by Matej");
Console.WriteLine("-------------------------------------");
Console.WriteLine();

// Ask for first name
Console.Write("What is your name: ");
string firstName = Console.ReadLine() ;
Console.WriteLine();
Console.Write("What is your last name: ");
string lastName = Console.ReadLine();
Console.Write("How old are you: ");
string age = Console.ReadLine();

// Greet user by name
Console.WriteLine();
Console.WriteLine("Hello " + firstName + " " + lastName);
Console.WriteLine();
Console.WriteLine("You are " + age);
Console.WriteLine("-------------------------------------");


Console.WriteLine("Thank you for using my application Mr." + lastName + ".");
Console.ReadLine();
