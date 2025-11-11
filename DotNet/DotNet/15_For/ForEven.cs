class ForEven
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sum += i; 
            }
        }

        Console.WriteLine("1~100 Even sum: {0}", sum);
    }
}