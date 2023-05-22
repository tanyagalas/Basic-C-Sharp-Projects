using System;

class Program
{
    static void Main()
    {
        // Ask the user for a number
        Console.Write("Enter a number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // Create an instance of MathOperations class
        MathOperations math = new MathOperations();

        // Call each method 
        int result1 = math.MultiplyByTwo(userInput);
        Console.WriteLine("Result 1: " + result1);

        int result2 = math.SquareNumber(userInput);
        Console.WriteLine("Result 2: " + result2);

        int result3 = math.CalculateFactorial(userInput);
        Console.WriteLine("Result 3: " + result3);
    }
}