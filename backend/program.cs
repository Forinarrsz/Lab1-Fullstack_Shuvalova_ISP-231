// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Shuvalova Alina Egorovna");
Console.WriteLine(DateTime.Now);

System.Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
System.Console.WriteLine($"Hello, {name}");
System.Console.WriteLine("Day of week");
System.Console.WriteLine(DateTime.Now.DayOfWeek);

System.Console.WriteLine("Хотите продолжить? (y/n)");

string inpt = Console.ReadLine();

switch(inpt)
{
    case "y":
        System.Console.WriteLine("программа продолжает работу");
    case "n":
        System.Console.WriteLine("программа завершает работу");
        Environment.Exit(0);
}
