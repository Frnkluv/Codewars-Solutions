/*
Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

Examples:
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
*/

// Solution 1
public class Kata
{
    public static string PigIt(string str)
    {
        return string.Join(" ", str.Split(' ').Select(x => x.Any(char.IsPunctuation) ? x : x.Substring(1) + x[0] + "ay"));
    }
}

// Solution 2
public class Kata
{
    public static string PigIt(string str)
    {
        string result = string.Empty;

        string[] strArray = str.Split(' ');
        str = string.Join(" ", strArray);
        foreach (var item in strArray)
        {
            var firstLetter = item[0];
            for (int i = 1; i < item.Length; i++)
            {
                result += item[i];
            }
            if (char.IsPunctuation(firstLetter)) result += firstLetter + " ";
            else result += (firstLetter + "ay ");
        }

        return result.Trim();
    }
}