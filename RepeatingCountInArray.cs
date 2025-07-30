// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int target = Convert.ToInt32(Console.ReadLine());
        
        Dictionary <int, int> frequency = new Dictionary<int, int>();
        foreach(char c in input)
        {
            if(char.IsDigit(c))
            {
                int num = int.Parse(c.ToString());
                if(frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num]=1;
            }
            }
        }
        if(frequency.ContainsKey(target))
        {
            Console.WriteLine(frequency[target]);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

using System;
using System.Collections.Generic;
 
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count =0;
        for(int i=5; n/i>=1;i *=5)
        {
            count += n/i;
        }
        Console.WriteLine(count);
    }
}