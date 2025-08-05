// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    
public static int NonRepeating(string word1, char target)
{
    Dictionary<char, int> frequency = new Dictionary<char, int>();
    foreach (char ch in word1)
    {
        if (frequency.ContainsKey(ch))
        {
            frequency[ch]++;
        }
        else
        {
            frequency[ch] = 1;
        }
    }
    if(frequency.ContainsKey(target))
    {
        return frequency[target];
    }
    return 0;
    //return frequency.ContainsKey(target) ? frequency[target] : 0;
}

    public static void Main(string[] args)
    {
        string word1= Console.ReadLine();
        char target = Console.ReadLine()[0];
        int res =NonRepeating(word1,target);
        Console.WriteLine(res);
        
    }
}

abcdaa
a
3


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    
public static List<char> NonRepeating(string word1, string word2)
{
    Dictionary<char, int> frequency = new Dictionary<char, int>();
    List<char> result = new List<char>();
    foreach (char ch in word1)
    {
        if (frequency.ContainsKey(ch))
        {
            frequency[ch]++;
        }
        else
        {
            frequency[ch] = 1;
        }
    }
    
    foreach (char ch in word2)
    {
        if (frequency.ContainsKey(ch))
        {
            frequency[ch]++;
        }
        else
        {
            frequency[ch] = 1;
        }
    }
    foreach(var pair in frequency)
    {
        if(pair.Value==1)
        {
            result.Add(pair.Key);
        }
    }
   return result;
}

    public static void Main(string[] args)
    {
        string word1= Console.ReadLine();
        string word2= Console.ReadLine();
        List<char> res =NonRepeating(word1,word2);
        foreach(char c in res)
        {
            Console.Write(c+" ");
        }
        
    }
}

abbaf
abba
f 

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    
public static int NonRepeating(string word1)
{
    Dictionary<char, int> frequency = new Dictionary<char, int>();
    int count=0;
   // List<char> result = new List<char>();
    foreach (char ch in word1)
    {
        if (frequency.ContainsKey(ch))
        {
            frequency[ch]++;
        }
        else
        {
            frequency[ch] = 1;
        }
    }
    foreach(var pair in frequency)
    {
        if(pair.Value > 1)
        {
            count++;
        }
        
    }
    return count;
}

    public static void Main(string[] args)
    {
        string word1= Console.ReadLine();
    
        int res =NonRepeating(word1);
        Console.WriteLine(res);
        
    }
}

abbace
2