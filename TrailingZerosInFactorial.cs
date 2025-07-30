using System;
using System.Collections.Generic;
 
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for(int i=1; i<=n; i++)
        {
            fact = fact*i;
        }
        Console.WriteLine(fact);

        string ch = fact.ToString();

        if(ch[ch.Length-1] != '0')
        {
            Console.WriteLine(0);
        }
        else
        {
            int count =0;
        for(int i=ch.Length-1;i>=0;i--)
        {
            if (ch[i]=='0')
            {
                count++;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(count);
        }
    }
}