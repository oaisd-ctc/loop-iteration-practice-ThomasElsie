using System;

public class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(5);

        Write1ThroughN_For(5);

        WriteNThrough1_While(5);

        WriteNThrough1_For(5);

        WriteEvensThrough100();

        FindSum(5);

        FindSumOfEvenNumbers(5);

        FindSumOfOddNumbers(5);

        OutputRightTriangle(5);
    }
    public static void Write1ThroughN_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        int counter = 1;
        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
    public static void Write1ThroughN_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        for (int counter = 1; counter <= n; counter++)
        {
            Console.WriteLine(counter);
        }
    }
    public static void WriteNThrough1_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        int counter = 1;
        while (counter <= n)
        {
            Console.WriteLine(n);
            n--;
        }
    }
    public static void WriteNThrough1_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        for (int counter = n; counter >= 1; counter--)
        {
            Console.WriteLine(counter);
        }
    }
    public static void WriteEvensThrough100()
    {
        for (int counter = 0; counter <= 100; counter++)
        {
            if(counter % 2 != 0)
            {
                continue;
            }
            Console.WriteLine(counter);
        }
    }
    public static void FindSum(int n)
    {
        int sum = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            sum = sum + counter;
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            if (counter % 2 !=0)
            {
                continue;
            }
            sum = sum + counter;
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            if (counter % 2 == 0)
            {
                continue;
            }
            sum = sum + counter;
        }
        Console.WriteLine(sum);
    }
    public static void OutputRightTriangle(int _base)
    {
        for (int counter = 1; counter <= _base; counter++)
        {
            for (int j = 1; j <= counter; counter++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine(n + " is out of range.");
    }
}