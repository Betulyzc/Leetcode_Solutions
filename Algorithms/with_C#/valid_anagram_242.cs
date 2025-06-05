
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] counterArr = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            counterArr[s[i] - 'a']++;
            counterArr[t[i] - 'a']--;
        }

        foreach (int index in counterArr)
        {
            if (index != 0)
            {
                return false;
            }
        }

        return true;

    }
}
