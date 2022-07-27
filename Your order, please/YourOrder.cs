/*
Your task is to sort a given string. Each word in the string will contain a single number. 
This number is the position the word should have in the result.

Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

If the input string is empty, return an empty string. The words in the input String will only 
contain valid consecutive numbers.

Examples
"is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
""  -->  ""
*/

// Solution 1
public static class Kata
{
    public static string Order(string words)
    {
        if (string.IsNullOrEmpty(words)) return string.Empty;

        string[] wordsArray = words.Split();
        string[] result = new string[wordsArray.Length];

        foreach (string word in wordsArray)
        {
            foreach (char ch in word)
            {
                if (char.IsDigit(ch))
                {
                    int preIndex = ch - '0';
                    result[preIndex - 1] = word;
                }
            }
        }
        return string.Join(" ", result);
    }
}


// Solution 2
public static class Kata
{
    public static string Order(string words)
    {
        if (string.IsNullOrEmpty(words)) return words;

        return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
    }
}