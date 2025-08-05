// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class HelloWorld
{
    public static int SumOfOddNumbers(int[]a)
    {   
        int sum=0;
        foreach(int num in a)
        {
            if(num%2 !=0)
            {
                sum +=num;
            }
        }
        return sum;
    
    }
    public static void Main(string[] args)
    {
        int[] a = new int[8]{2,3,2,5,4,6,7,1};
        int res = SumOfOddNumbers(a);
        Console.WriteLine(res);
    }
}