using System;

class MaxMinFunction
{
    static int Max(int x, int y)
    {
        return (x > y) ? x : y;
    }

    static int Min(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    static void Main()
    {
        Console.WriteLine(Max(3, 5)); //5
        Console.WriteLine(Min(-3, -5)); //-5
    }
}