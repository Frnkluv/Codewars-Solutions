﻿/*
Write a function that takes an array of numbers (integers for the tests) and a target number. 
It should find two different items in the array that, when added together, give the target value. 
The indices of these items should then be returned in a tuple / list (depending on your language) 
like so: (index1, index2).

For the purposes of this kata, some tests may have multiple answers; any valid solutions 
will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, 
and all of the items will be numbers; target will always be the sum of two different items from 
that array).

two_sum([1, 2, 3], 4) == {0, 2}
 */

public class Kata
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length < 2)
        {
            return Array.Empty<int>();
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                    return new int[] { i, j };
            }
        }
        return Array.Empty<int>();
    }
}