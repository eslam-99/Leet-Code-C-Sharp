public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int diff = 0;
        foreach (char c in s + t) diff ^= c;
        return (char)diff;
    }
}