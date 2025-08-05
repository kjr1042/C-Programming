// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class HelloWorld
{
    public static int IndexOfSortedArrayElement(int [] a,int index)
    {   int[] sorted = (int[])a.Clone();
        Array.Sort(sorted);
        return sorted[index-1];
    }
    public static void Main(string[] args)
    {
        int[] a = new int[5]{2,1,4,3,5};
        int index=4;
        int res = IndexOfSortedArrayElement(a,index);
        Console.WriteLine(res);
    }
}