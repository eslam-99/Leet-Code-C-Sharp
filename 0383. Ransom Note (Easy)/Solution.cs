public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        uint[] chars = new uint[26];
        foreach (char c in magazine) chars[c - 'a']++;
        foreach (char c in ransomNote) if (chars[c - 'a']-- == 0) return false;
        return true;
    }
}