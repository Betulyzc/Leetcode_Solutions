"""
You are given positive integers n and m.
Define two integers as follows:
num1: The sum of all integers in the range [1, n] (both inclusive) that are not divisible by m.
num2: The sum of all integers in the range [1, n] (both inclusive) that are divisible by m.
Return the integer num1 - num2.
"""

public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int total = (n * (n + 1)) / 2;
        int divisibleSum = 0;

        for (int i = m; i <= n; i += m)
        {
            divisibleSum += i;
        }

        return total - 2 * divisibleSum;
    }
}
