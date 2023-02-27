public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> substring = new();
        int maxLen = 0, currentLen = 0;
        int i = 0;
        foreach (char c in s)
        {
            if (!substring.ContainsKey(c))
            {
                substring[c] = i;
                currentLen++;
            }
            else
            {
                maxLen = Math.Max(maxLen, currentLen);
                foreach (var p in substring)
                    if (p.Value < substring[c]) substring.Remove(p.Key);
                substring[c] = i;
                currentLen = substring.Count;
            }
            i++;
        }
        return Math.Max(maxLen, currentLen);
    }
}