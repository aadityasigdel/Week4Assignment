public class Calculator
{
    //prints a welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    //return addition of two integers
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    //Mutliplication with optional parameter
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
