/*
Task
In this simple Kata your task is to create a function that turns a string into a Mexican Wave. 
You will be passed a string and you must return that string in an array where an uppercase letter 
is a person standing up. 

Rules
 1.  The input string will always be lower case but maybe empty.
 2.  If the character in the string is whitespace then pass over it as if it was an empty seat

Example
wave("hello") => []string{"Hello", "hEllo", "heLlo", "helLo", "hellO"}
*/

namespace CodeWars
{
    public class Kata
    {
        public List<string> Wave(string str)
        {
            var wave = str
            .Select((c, i) => str.Substring(0, i) + str.Substring(i, 1).ToUpper() +
            str.Substring(i + 1, str.Length - i - 1))
            .Where(s => !s.All(c => c.ToString() == c.ToString().ToLower()));

            var list = wave.ToList();
            return list;
        }
    }
}