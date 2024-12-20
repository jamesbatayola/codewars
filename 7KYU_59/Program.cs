﻿//In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. For example: 5! = 5 * 4 * 3 * 2 * 1 = 120.By convention the value of 0! is 1.

//Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException (C#) or IllegalArgumentException (Java) or RangeException (PHP) or throw a RangeError (JavaScript) or ValueError (Python) or return -1 (C).

//More details about factorial can be found here.

//Console.WriteLine(Factorial(5));
//Console.WriteLine(Factorial(13));
Console.WriteLine(Factorial(3));

static int Factorial(int n)
{
    if(n > 12 || n < 0)
    {
        throw new ArgumentOutOfRangeException("Error");
    }

    int res = 1;

    for(int i = 2; i <= n; i++)
    {
        res *= i;
    }

    return res;
}