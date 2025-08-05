// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static int MaxTwoSum(int [] a)
    {
        int max1 = int.MinValue;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]>max1)
            {
                max1 = a[i];
            }
        }
        int max2 =int.MinValue;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]>max2 && a[i]<max1)
            {
                max2 = a[i];
            }
        }
        return max1+max2;
        
    }
    public static void Main(string[] args)
    {
        int[] a = new int[6]{1,2,3,-1,5,4};
        int res = MaxTwoSum(a);
        Console.WriteLine(res);
    }
}