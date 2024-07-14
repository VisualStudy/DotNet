class Sum100
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }

        Console.WriteLine("1~100 sum: {0}", sum);
    }
}