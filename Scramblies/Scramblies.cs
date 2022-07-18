/*
Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

Notes:

Only lower case letters will be used (a-z). No punctuation or digits will be included.
Performance needs to be considered.
Examples
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
*/

public class Scramblies
{

    public static bool Scramble(string str1, string str2)
    {
        if (str1.Length < str2.Length) return false;
        foreach (var item in str1.ToCharArray())
        {
            if (str2.Contains(item.ToString()))
                str2 = str2.Remove(str2.IndexOf(item.ToString()), 1);
        }
        return str2 == string.Empty ? true : false;
    }
}