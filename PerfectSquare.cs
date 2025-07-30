using System;

public class HelloWorld
{
    public static bool isPerfectNumber(int number)
    {
        if (number < 0)
        {
            return false;
        }

        int sqrt = (int)Math.Sqrt(number);
        return sqrt * sqrt == number;
    }

    public static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        string inputLine = Console.ReadLine();
        string[] input = inputLine.Split(' ');

        int[] a = new int[size];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Convert.ToInt32(input[i]);
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (isPerfectNumber(a[i]))
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}