// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Collections;

public class HelloWorld
{
    
    public static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[size];
 
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(input[i]);
        }
 
        List<int> even = new List<int>();
        List<int> odd = new List<int>();
 
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i]%2==0)
        {
            even.Add(arr[i]);
        }
    }
    for(int i=0;i<arr.Length;i++)
    {
        if(arr[i]%2!=0)
        {
            odd.Add(arr[i]);
        }
    }
    Console.Write(string.Join(" ", even)+" ");
    Console.Write(string.Join(" ", odd));
       
        
    }
}





// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static /*List<int>*/ string OddnEvenNUmbers(int[]a)
    {   
        List<int> even = new List<int>();
        List<int> odd = new List<int>();
        foreach(int num in a)
        {
            if(num%2 !=0)
            {
                odd.Add(num);
            }
            else
            {
                even.Add(num);
            }
        }
        string evenStr = String.Join(" ", even);
        string oddStr = String.Join(" ", odd);

        return evenStr+" "+ oddStr;
        // even.AddRange(odd);
        // return even;
        
        // foreach (int num in odd)
        // {
        //     even.Add(num);
        // }
    
    }
    public static void Main(string[] args)
    {
        int[] a = new int[8]{10,11,12,13,15,16,17,18};
        /*List<int>*/string res = OddnEvenNUmbers(a);
        Console.WriteLine(res);
        //Console.WriteLine(String.Join(" ",res));
    }
}