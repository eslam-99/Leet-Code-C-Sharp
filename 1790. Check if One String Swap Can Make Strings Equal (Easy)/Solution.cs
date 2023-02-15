public class Solution
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        //int diff = 0;
        List<char> chars = new(2);
        bool found = false;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                if (found) return false;
                if (chars.Count != 0 && (chars[0] != s1[i] || chars[1] != s2[i])) return false;
                else if (chars.Count == 0) chars = new() { s1[i], s2[i] };
                else { found = true; chars = new(2); }
            }
        }
        return chars.Count == 0;
    }
}