using System;

class GetSumTwoNumber
{
    static double GetSum(double x, double y)
    {
        double r = x + y;
        return r;
    }
    static void Main()
    {
        double result = GetSum(3.0, 0.14);
        Console.WriteLine(result);
    }
}