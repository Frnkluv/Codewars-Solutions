/*
Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

It should remove all values from list a, which are present in list b keeping their order.
Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}

If a value is present in b, all of its occurrences must be removed from the other:
Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
*/

// Solution 1
public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        return a.Where(x => !b.Contains(x)).ToArray();
    }
}


// Solution 2
public class Kata
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        var list = a.ToList();

        foreach (var item1 in a)
        {
            foreach (var item2 in b)
            {
                if (item1.Equals(item2))
                {
                    list.Remove(item2);
                }
            }
        }

        return list.ToArray();
    }
}