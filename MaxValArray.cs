// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static int[] MaxValue(int[,]arr)
    {
        int row =arr.GetLength(0);
        int col = arr.GetLength(1);
        
        int[] maxValues = new int[row];
       
        for(int i=0;i<row;i++)
        {
            int max = arr[i,0];
            for(int j=1;j<col;j++)
            {
                if(arr[i,j]>max)
                {
                    max = arr[i,j];
                }
            }
            maxValues[i] = max;
        }
        return maxValues;
        
    }
    public static void Main(string[] args)
    {
        int[,] arr = {
            {2, 4, 8, 5},
            {3, 2, 1, 7},
            {4, 5, 3, 2}
        };
        
    int[] res = MaxValue(arr);
    
    foreach(int num in res)
    {
     Console.WriteLine(num);   
    }
    }
}