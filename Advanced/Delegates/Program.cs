using delegates;

class Program
{
    static void Main()
    {
        MathOperation op = Calculator.Add;
        op(10, 20);
        op = Calculator.Subtract;
        op(10, 20);
        op = Calculator.Multiply;
        op(10, 20);
        op = Calculator.Divide;
        op(10, 20);
    }
}