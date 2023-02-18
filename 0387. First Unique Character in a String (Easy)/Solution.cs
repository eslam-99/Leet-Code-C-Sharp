public class Solution
{
    public int FirstUniqChar(string s)
    {
        int[] chars = new int[26];
        foreach (char c in s) chars[c - 'a'] += 1;
        for (int i = 0; i < s.Length; i++) if (chars[s[i] - 'a'] == 1) return i;
        return -1;
    }
}