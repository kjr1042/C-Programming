using System;
 
public class Solution
{
    // Helper method: computes energy after `time` seconds
    public static int CalculateEnergy(int initialEnergy, int rate, int time)
    {
        int energy = initialEnergy;
        for (int i = 1; i <= time; i++)
        {
            energy += rate * i;
        }
        return energy;
    }
 
    public static void Main(string[] args)
    {
        // 1. Read inputs from console
        //    (each on its own line)
        int initialEnergy = int.Parse(Console.ReadLine());
        int rate          = int.Parse(Console.ReadLine());
        int time          = int.Parse(Console.ReadLine());
 
        // 2. Call your logic method
        int finalEnergy = CalculateEnergy(initialEnergy, rate, time);
 
        // 3. Print the result
        Console.WriteLine(finalEnergy);
    }
}