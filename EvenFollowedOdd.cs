using System;
using System.Collections.Generic;
 
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
 
        foreach (int num in arr)
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }
 
        int evenI = 0, oddI = 0;
 
        while (evenI < even.Count || oddI < odd.Count)
        {
            for (int i = 0; i < 2 && evenI < even.Count; i++)
            {
                Console.Write(even[evenI] + " ");
                evenI++;
            }
 
            for (int i = 0; i < 2 && oddI < odd.Count; i++)
            {
                Console.Write(odd[oddI] + " ");
                oddI++;
            }
        }
    }
}