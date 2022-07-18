/*
Create a RomanNumerals class that can convert a roman numeral to and from an integer value. 
It should follow the API demonstrated in the examples below. Multiple roman numeral values will be tested 
for each helper method.

Modern Roman numerals are written by expressing each digit separately starting with the left most digit 
and skipping any digit with a value of zero. 

In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; 
or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

Input range : 1 <= n < 4000

In this kata 4 should be represented as IV, NOT as IIII (the "watchmaker's four").

Examples
RomanNumerals.toRoman(1000); // should return 'M'
RomanNumerals.fromRoman('M'); // should return 1000
*/

// Solution 1
public class RomanNumerals
{
    private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    private static Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };
    public static string ToRoman(int number)
    {
        string result = string.Empty;
        int x = 0;
        foreach (var item in dict)
        {
            x = number / item.Key;
            for (int i = 0; i < x; i++)
            {
                result += item.Value;
            }
            number = number % item.Key;
        }
        return result;
    }

    public static int FromRoman(string romanNumeral)
    {
        int number = 0;
        for (int i = 0; i < romanNumeral.Length; i++)
        {
            if (i + 1 < romanNumeral.Length && RomanMap[romanNumeral[i]] < RomanMap[romanNumeral[i + 1]])
            {
                number -= RomanMap[romanNumeral[i]];
            }
            else
            {
                number += RomanMap[romanNumeral[i]];
            }
        }
        return number;
    }
}


// Solution 2
public class RomanNumerals
{
    private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    public static string ToRoman(int n)
    {
        return
        new string('I', n)
            .Replace(new string('I', 1000), "M")
            .Replace(new string('I', 900), "CM")
            .Replace(new string('I', 500), "D")
            .Replace(new string('I', 400), "CD")
            .Replace(new string('I', 100), "C")
            .Replace(new string('I', 90), "XC")
            .Replace(new string('I', 50), "L")
            .Replace(new string('I', 40), "XL")
            .Replace(new string('I', 10), "X")
            .Replace(new string('I', 9), "IX")
            .Replace(new string('I', 5), "V")
            .Replace(new string('I', 4), "IV");
    }

    public static int FromRoman(string romanNumeral)
    {
        int number = 0;
        for (int i = 0; i < romanNumeral.Length; i++)
        {
            if (i + 1 < romanNumeral.Length && RomanMap[romanNumeral[i]] < RomanMap[romanNumeral[i + 1]])
            {
                number -= RomanMap[romanNumeral[i]];
            }
            else
            {
                number += RomanMap[romanNumeral[i]];
            }
        }
        return number;
    }
}