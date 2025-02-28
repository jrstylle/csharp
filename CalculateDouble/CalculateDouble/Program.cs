namespace CalculateDouble;

class Program
{
    static void Main()
    {
        double value1 = 10;
        double value2 = 5;
        var calculate = new CalculateDouble();

        Console.WriteLine($"Add: {calculate.Add(value1, value2)}");
        Console.WriteLine($"Subtract: {calculate.Subtract(value1, value2)}");
        Console.WriteLine($"Multiply: {calculate.Multiply(value1, value2)}");
        Console.WriteLine($"Divide: {calculate.Divide(value1, value2)}");
        Console.WriteLine($"Modulus: {calculate.Modulus(value1, value2)}");
    }
}
