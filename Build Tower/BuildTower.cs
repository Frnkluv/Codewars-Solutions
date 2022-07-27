/*
Build Tower
Build a pyramid-shaped tower given a positive integer number of floors. A tower block is represented with "*" character.

For example, a tower with 3 floors looks like this:

[
  "  *  ",
  " *** ", 
  "*****"
]
And a tower with 6 floors looks like this:

[
  "     *     ", 
  "    ***    ", 
  "   *****   ", 
  "  *******  ", 
  " ********* ", 
  "***********"
]
*/

// Solution 1
public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] result = new string[nFloors];
        int length = (nFloors - 1) * 2 + 1;

        for (int i = 0; i < nFloors; i++)
        {
            int star = i * 2 + 1;
            int gap = (length - star) / 2;
            string str = "";
            for (int a = 0; a < gap; a++) { str += " "; }
            for (int a = 0; a < star; a++) { str += "*"; }
            for (int a = 0; a < gap; a++) { str += " "; }
            result[i] = str;
        }

        return result;
    }
}


//Solution 2
public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        var result = new string[nFloors];
        for (int i = 0; i < nFloors; i++)
            result[i] = string.Concat(new string(' ', nFloors - i - 1),
                                      new string('*', i * 2 + 1),
                                      new string(' ', nFloors - i - 1));
        return result;
    }
}