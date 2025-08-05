// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static bool isPrime(int num)
    {
        if(num<2)
        {
            return false;
        }
        for(int i=2;i<num;i++)
        {
            if(num%i ==0)
            {
                return false;
            }
        }
        return true;
    }
    public static void Main(string[] args)
    {
        int num =Convert.ToInt32(Console.ReadLine());
        
        int temp = num;
        int sum=0;
        while(temp>0)
        {
            int digit = temp%10;
            if(isPrime(digit))
            {
                sum +=digit;
            }
            temp /=10;
        }
        
       Console.WriteLine(sum); 
        
    }
}