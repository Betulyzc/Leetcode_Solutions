
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            int[] counter = new int[26];

            foreach (char c in word)
            {
                counter[c - 'a']++;
            }

            string key = string.Join(",", counter);

            if (dic.ContainsKey(key))
            {
                dic[key].Add(word);
            }
            else
            {
                dic[key] = new List<string> { word };
            }

        }
        return dic.Values.Select(group => (IList<string>)group).ToList();

    }
}