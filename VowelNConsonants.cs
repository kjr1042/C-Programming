// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
 
using System;
 
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower();
        int vowelCount=0;
        int consonantCount=0;
        foreach(char ch in input)
        {
            if(char.IsLetter(ch))
            {
                if("aeiou".Contains(ch))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }
        Console.WriteLine(vowelCount);
        Console.WriteLine(consonantCount);
    }
}