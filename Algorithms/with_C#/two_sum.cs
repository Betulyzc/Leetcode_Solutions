

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];
            int complement = target - current;

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            else
            {
                map[current] = i;
            }
        }
        return new int[0];

    }
}