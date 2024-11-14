﻿//Create a function taking a positive integer between 1 and 3999 (both included) as its parameter and returning a string containing the Roman Numeral representation of that integer.

//Modern Roman numerals are written by expressing each digit separately starting with the leftmost digit and skipping any digit with a value of zero. There cannot be more than 3 identical symbols in a row.

//In Roman numerals:

//    1990 is rendered: 1000 = M + 900 = CM + 90 = XC; resulting in MCMXC.
//    2008 is written as 2000=MM, 8=VIII; or MMVIII.
//    1666 uses each Roman symbol in descending order: MDCLXVI.

//Example:

//   1-- > "I"
//1000-- > "M"
//1666-- > "MDCLXVI"

//Help:

//Symbol Value
//I          1
//V          5
//X          10
//L          50
//C          100
//D          500
//M          1,000

static string Solution(int n)
{
    string res = "";
    string year = n.ToString();

    for(int i = 0; i < year.Length; i++)
    {
        if (year[i] != '0')
        {
            year.Substring(i).Length switch
            {
                4 => res += 'a',
                3 => res += 's',
                2 => res += 'd',
                1 => res += 'z',
                _ => res += 'z'
            }
        }
    }

    return "asd";
}