// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        
        string temp = "";
        
        Dictionary<char,int> freq = new Dictionary<char,int>();
        
        foreach(char ch in word1)
        {
            if(freq.ContainsKey(ch))
            {
                freq[ch]++;
            }
            else
            {
                freq[ch]=1;
            }
        }
        
        foreach(char ch in word2)
        {
            if(freq.ContainsKey(ch))
            {
                freq[ch]++;
            }
            else
            {
                freq[ch]=1;
            }
        }
        
        foreach(var pair in freq)
        {
            if(pair.Value ==1)
            {
                Console.WriteLine(pair.Key);
            }
        }
        
    }
}