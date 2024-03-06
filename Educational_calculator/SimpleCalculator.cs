using System;

public class SimpleCalculator
{
    private Random random;


    public SimpleCalculator()
    {
        random = new Random();
    }


    public int Multiply()
    {
        int num1 = random.Next(1, 11);
        int num2 = random.Next(1, 11);
        Console.WriteLine($"Multiply: {num1} * {num2} = ?");
        return num1 * num2;
    }

    public int Divide()
    {
        int num1 = random.Next(1, 11);
        int num2 = random.Next(1, 11);
        Console.WriteLine($"Divide: {num1 * num2} / {num1} = ?");
        return num2;
    }

    public int Sum()
    {
        int num1 = random.Next(1, 101);
        int num2 = random.Next(1, 101);
        Console.WriteLine($"Add: {num1} + {num2} = ?");
        return num1 + num2;
    }

    public int Subtract()
    {
        int num1 = random.Next(1, 101);
        int num2 = random.Next(1, 101);
        Console.WriteLine($"Subtract: {num1 + num2} - {num2} = ?");
        return num1;
    }

    internal static int GenerateMultiplicationExercise()
    {
        throw new NotImplementedException();
    }
}


