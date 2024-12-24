// See https://aka.ms/new-console-template for more information

using SkySoftwareConsole.Models;

class program
{
    public static void Main(string[] args)
    {
        /// Read x and y from user
        Console.WriteLine("Pleaze input x val");
        var x= Console.ReadLine();

        Console.WriteLine("Pleaze input y val");
        var y = Console.ReadLine();
        /// Create new Instance from calculator
        Calculator calculator = new Calculator(Convert.ToInt32(x) , Convert.ToInt32(y));
        /// Display the results of the  operations
        Console.WriteLine("Sum (x + y) = " +" " + calculator.Sum());
        Console.WriteLine("Difference  (x - y) = " + " " + calculator.Subtract());
        Console.WriteLine("Product (x * y) = " + " " + calculator.Multiply());
        Console.WriteLine("Quotient (x / y) = " + " " + calculator.Divide());
        Console.ReadLine();
    }
}

