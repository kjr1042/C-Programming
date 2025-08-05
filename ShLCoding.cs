// 1. char Shift:

using System;

public class HelloWorld
{
    public static char shift(char ch, int target)
    {
        int shifted = (int)ch + target;
        if(shifted>122)
        {
            shifted = (int)ch + target - 26;
        }
        return (char)shifted;
    }
    public static void Main(string[] args)
    {
        char ch = Console.ReadLine()[0];
        int target = Convert.ToInt32(Console.ReadLine());
        char c = shift(ch,target);
        Console.WriteLine(c);
    }
}

// 2. Non Repeating Count of String

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static /*List<char>*/int nonRepeat(string input)
    {
        int count=0;
        Dictionary<char,int> freq = new Dictionary<char,int>();
        List<char> result = new List<char>();
        
        foreach(char ch in input)
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
        foreach(char c in input)
        {
            if(freq[c]==1)
            {
                result.Add(c);
                count++;
            }
        }
       // return result;
       return count;
        
    }
    
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        /*List<char>*/int res = nonRepeat(input);
        Console.WriteLine(res);
        
        // foreach(char op in res)
        // {
        //     Console.Write(op+" ");
        // }
        
    }
}


//3. Calculate Energy

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static int CalEnergy(int initialEnergy, int rate, int time)
    {
        int energy = initialEnergy;
        for(int i=1;i<=time;i++)
        {
            energy += rate*i;
        }
        return energy;
    }
    
    public static void Main(string[] args)
    {
        int initialEnergy = Convert.ToInt32(Console.ReadLine());
        int rate = Convert.ToInt32(Console.ReadLine());
        int time = Convert.ToInt32(Console.ReadLine());
        
        int res = CalEnergy(initialEnergy, rate, time);
        Console.WriteLine(res);
        
        
    }
}


//4. EvenFollowedByOdd

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static List<int> EvenFollowedByOdd(int []arr)
    {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();
        List<int> result = new List<int>();
        foreach(int num in arr)
        {
            if(num%2==0)
            {
                even.Add(num);
            }
            else
            {
                odd.Add(num);
            }
        }
        int evenI =0, oddI =0;
        while(evenI<even.Count || oddI<odd.Count)
        {
            for(int i=0;i<2 && evenI<even.Count;i++)
            {
                result.Add(even[evenI]);
                evenI++;
            }
            for(int i=0;i<2 && oddI<odd.Count;i++)
            {
                result.Add(odd[oddI]);
                oddI++;
            }
        }
        return result;
        
    }
    
    
    public static void Main(string[] args)
    {
        int[] arr = new int[8] {10,11,12,13,15,16,17,18};
        List<int> res = EvenFollowedByOdd(arr);
        
        foreach(int op in res)
        {
            Console.Write(op +" ");
        }   
        
    }
}


//5.AddEvenDigitFollowedByOdd

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static List<int> AddEvenFollowedByOdd(int[] a)
    {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();
        
        foreach(int num in a)
        {
            if(num%2==0)
            {
                even.Add(num);
            }
            else
            {
                odd.Add(num);
            }
        }
        foreach(int oddn in odd)
        {
            even.Add(oddn);
        }
        return even;
    }
    public static void Main(string[] args)
    {
        int[] a = new int[8]{10,11,12,13,15,16,17,18};
        
        List<int> res = AddEvenFollowedByOdd(a);
        foreach (int op in res)
        {
            Console.Write(op+" ");
        }
    }
}


//6. KthIndexOfArray

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static int KthIndexOfArrayElement(int[] a,int index)
    {
        int[] sorted = (int[]) a.Clone();
        Array.Sort(sorted);
        return sorted[index-1];
    }
    
    public static void Main(string[] args)
    {
       int[] a = new int[8]{3,2,1,7,8,5,9,6};
       int index = 4;
        int res = KthIndexOfArrayElement(a,index);
        Console.WriteLine(res);
    }
}

//7.Max element in Array row

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static int[] highestElement(int[,] arr)
    {
        int row = arr.GetLength(0);
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
            maxValues[i]=max;
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
        int[] res = highestElement(arr);
        foreach(int op in res)
        {
            Console.WriteLine(op);
        }
    }
}

//8. PerfectSquare numbers in array

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static bool isPerfectSquare(int num)
    {
        if(num<0)
        {
            return false;
        }
        
        int sqrt = (int)Math.Sqrt(num);
        
        return num == sqrt*sqrt;
    }
    
    public static void Main(string[] args)
    {
       int[] arr = new int[5] {10,20,30,25,4};
       
       foreach(int op in arr)
       {
           if(isPerfectSquare(op))
           {
               Console.Write(op+" ");
           }
       }
    }
}

//9.Prime numbers sum in Array

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
            if(num%i==0)
            {
                return false;
            }
        }
        return true;
    }
    
    
    public static void Main(string[] args)
    {
       int num = Convert.ToInt32(Console.ReadLine());
       int sum =0;
       int temp = num;
       while(temp>0)
       {
           int digit = temp%10;
           if(isPrime(digit))
           {
               sum += digit;
           }
           temp /=10;
       }
       Console.WriteLine(sum);
       
    }
}

//10. Repeating Count of Array

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static List<int> RepeatCount(int[] arr, int target)
    {
        List<int> result = new List<int>();
        Dictionary<int,int> freq = new Dictionary<int,int>();
        
        foreach(int num in arr)
        {
            if(freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq[num]=1;
            }
        }
        if(freq.ContainsKey(target))
        {
            result.Add(freq[target]);
        }
        return result;
        
    }
    public static void Main(string[] args)
    {
       int[] arr = new int[6]{5,2,2,2,3,1};
       int target = 2;
       List<int> res = RepeatCount(arr,target);
       
       foreach(int op in res)
       {
            Console.WriteLine(op);
       }
    }
}

// 11. Non repeating char in two strings

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static List<char> NonRepeatChar(string word1, string word2)
    {
        List<char> result = new List<char>();
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
            if(pair.Value==1)
            {
                result.Add(pair.Key);
            }
        }
        return result;
        
    }
    public static void Main(string[] args)
    {
       string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        
        List<char> res = NonRepeatChar( word1, word2);
        foreach(char op in res)
        {
            Console.Write(op+" ");
        }
        
    }
}

//12. Sum of two maximum numbers in array

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static int sumOfFirstAndSecondMax(int[] arr)
    {
        int max1 = int.MinValue;
        foreach(int num in arr)
        {
            if(num>max1)
            {
                max1 = num;
            }
        }
        int max2 = int.MinValue;
        foreach(int num in arr)
        {
            if(num>max2 && num<max1)
            {
                max2 = num;
            }
        }
        return max1+max2;
    }
    public static void Main(string[] args)
    {
       int[] arr = new int[4]{-1,-2,-3,4};
       int res = sumOfFirstAndSecondMax(arr);
       Console.WriteLine(res);
       
        
    }
}

//13. oddnumbers sum in Array

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static int sumOfOddNumbers(int[] arr)
    {
        int sum=0;
        foreach(int num in arr)
        {
            if(num%2 != 0)
            {
                sum += num;
            }
        }
        return sum;
    }
    public static void Main(string[] args)
    {
       int[] a = new int[8]{2,3,2,5,4,6,7,1};
       int res= sumOfOddNumbers(a);
       Console.WriteLine(res);
        
    }
}

//14. Trailing Zeros in factorial

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static int trailingZerosInFactorial(int num)
    {
        int count=0;
        for(int i=5; num/i>=1;i*=5)
        {
            count +=num/i;
        }
        return count;
    }
    public static void Main(string[] args)
    {
       int num = Convert.ToInt32(Console.ReadLine());
        int res = trailingZerosInFactorial( num);
        Console.WriteLine(res);
    }
}

//15.Count of vowels and consonants

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static List<int> CountVowelsAndConsonants(string input)
    {
        List<int> result = new List<int>();
        int volCount=0;
        int consCount=0;
        foreach(char ch in input)
        {
            if(char.IsLetter(ch))
            {
                if("aeiou".Contains(ch))
                {
                    volCount++;
                }
                else
                {
                    consCount++;
                }
            }
        }
        result.Add(volCount);
        result.Add(consCount);
        return result;
    }
    public static void Main(string[] args)
    {
      string input = Console.ReadLine().ToLower();
      
      List<int> res= CountVowelsAndConsonants(input);
      foreach(int op in res)
      {
          Console.WriteLine(op);
      }
      
    }
}

//16. product of (odd Index elements sum and even Index elements sum)

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static int sumOfOddAndEvenIndexElements(int num)
    {
        int evenSum =0;
        int oddSum=0;
        
        string arr = num.ToString();
        
        for(int i=0;i<arr.Length;i++)
        {
            int digit = arr[i]-'0';
            if(i%2==0)
            {
                evenSum += digit;
            }
            else
            {
                oddSum += digit;
            }
        }
        return evenSum*oddSum;
        
    }
    
    public static void Main(string[] args)
    {
      int num = Convert.ToInt32(Console.ReadLine());
      
      int res= sumOfOddAndEvenIndexElements( num);
      Console.WriteLine(res);
    }
}

// 17. String Variations

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