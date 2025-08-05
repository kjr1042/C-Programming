// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static char isShifted(char ch, int t)
    {
       int shifted=(int)ch + t;

    if (shifted > 122) // 'z' = 122 in ASCII
    {
        shifted = (int)ch + t - 26;
    }

    return (char)shifted;

    }
    public static void Main(string[] args)
    {
        string input = Console.ReadLine().ToLower(); /*char ch = Console.ReadLine()[0];*/
        
        int t= Convert.ToInt32(Console.ReadLine());
        
        char ch;
        
        if(!string.IsNullOrEmpty(input))
        {
            ch = input[0];
            char res = isShifted(ch,t);
            Console.WriteLine(res);
        }
        
        
        
    }

}
