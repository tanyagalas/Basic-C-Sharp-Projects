public class MathOperations
{
    // Method 1 Multiply 
    public int MultiplyByTwo(int number)
    {
        return number * 2;
    }

    // Method 2 Square the parameter
    public int SquareNumber(int number)
    {
        return number * number;
    }

    // Method 3 Calculate 
    public int CalculateFactorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}