using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MathOperation(int a, int b);

public class Calculator
{
    public static void Add(int a, int b)
    {
        Console.WriteLine("Addition: {0}", a + b);
    }

    public static void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction: {0}", a - b);
    }

    public static void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication: {0}", a * b);
    }

    public static void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not allowed");
        }
        else
        {
            Console.WriteLine("Division: {0}", a / b);
        }
    }
}