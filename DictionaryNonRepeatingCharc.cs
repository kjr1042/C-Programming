// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        input = input.ToLower();
        
        Dictionary <char, int> frequency = new Dictionary<char, int>();
        foreach(char c in input)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c]=1;
            }
        }
        int count =0;
        foreach(char c in input)
        {
            if(frequency[c]==1)
            {
                count++;
                Console.Write(c +" ");
                
                
            }
            
        }
         //Console.WriteLine();
        //Console.WriteLine(count);
  
    }
}