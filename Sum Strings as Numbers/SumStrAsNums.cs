/*
Given the string representations of two integers, return the string representation of the sum of those integers.

For example:

sumStrings('1','2') // => '3'
A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
*/
using System.Numerics;

// Solution 1
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        BigInteger.TryParse(a, out BigInteger bigA);
        BigInteger.TryParse(b, out BigInteger bigB);

        return (bigA + bigB).ToString();
    }
}

// Solution 2
public static class Kata
{
    public static string sumStrings(string str1, string str2)
    {
        if (str1.Length > str2.Length)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }
        string str = string.Empty;

        char[] chars1 = str1.ToCharArray();
        Array.Reverse(chars1);
        str1 = new string(chars1);

        char[] chars2 = str2.ToCharArray();
        Array.Reverse(chars2);
        str2 = new String(chars2);

        int carry = 0;
        for (int i = 0; i < str1.Length; i++)
        {
            int sum = ((int)(str1[i] - '0') + (int)(str2[i] - '0') + carry);
            str += (char)(sum % 10 + '0');

            // Calculate carry for next step
            carry = sum / 10;
        }

        // Add remaining digits of larger number
        for (int i = str1.Length; i < str2.Length; i++)
        {
            int sum = ((int)(str2[i] - '0') + carry);
            str += (char)(sum % 10 + '0');
            carry = sum / 10;
        }

        if (carry > 0)
            str += (char)(carry + '0');

        char[] charsResult = str.ToCharArray();
        Array.Reverse(charsResult);
        str = new string(charsResult);

        return str[0] == '0' ? str.Substring(1) : str;
    }
}