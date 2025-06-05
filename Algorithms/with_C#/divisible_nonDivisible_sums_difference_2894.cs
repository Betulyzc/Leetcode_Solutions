
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
