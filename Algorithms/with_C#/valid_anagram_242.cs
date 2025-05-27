"""
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

Example 1:
Input: s = "anagram", t = "nagaram"
Output: true

Example 2:
Input: s = "rat", t = "car"
Output: false
"""

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
