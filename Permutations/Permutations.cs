/*
 * In this kata you have to create all permutations of a non empty input string and remove duplicates, if present. This means, you have to shuffle all letters from the input in all possible orders.

Examples:

* With input 'a'
* Your function should return: ['a']
* With input 'ab'
* Your function should return ['ab', 'ba']
* With input 'aabb'
* Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
The order of the permutations doesn't matter.
 */

// Solution 1
class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        var output = new List<string>();
        if (s.Length == 1)
        {
            output.Add(s);
        }
        else
        {
            for (int x = 0; x < s.Length; x++)
            {
                output.AddRange(SinglePermutations(s.Remove(x, 1)).Select(z => s[x] + z));
            }
        }
        return output.Distinct().ToList();
    }
}

// Solution 2
class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        var output = new List<string>();
        if (s.Length == 1)
        {
            output.Add(s);
        }
        else
        {
            for (int x = 0; x < s.Length; x++)
            {
                output.AddRange(SinglePermutations(s.Remove(x, 1)).Select(z => s[x] + z));
            }
        }
        return output.Distinct().ToList();
    }
}