﻿namespace _8KYU_12;

// Create a function with two arguments that will return an array of the first n multiples of x.

// Assume both the given number and the number of times to count will be positive numbers greater than 0.

// Return the results as an array or list(depending on language ).

// Examples
// countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
// countBy(2, 5)  should return {2,4,6,8,10}

internal class Program
{
    static void Main(string[] args)
    {
        var asd = CountBy(1, 10);

        foreach (int i in asd)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }

    // SOLUTION
    public static int[] CountBy(int x, int n)
    {
        int[] result = new int[n];
        int temp = 0;

        for(int i = 0; i < n; i++)
        {
            result[i] = temp += x; ; 
        }
        
        return result;
    }

    // OTHER ANSWER

    public static int[] _CountBy(int x, int n)
    {
        return Enumerable.Range(1, n).Select(i => i * x).ToArray();
    }


}
