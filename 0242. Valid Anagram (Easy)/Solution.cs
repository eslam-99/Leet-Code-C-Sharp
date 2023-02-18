public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        uint[] chars = new uint[26];
        foreach (char c in s) chars[c - 'a']++;
        foreach (char c in t) if (chars[c - 'a']-- == 0) return false;
        return true;
    }
}