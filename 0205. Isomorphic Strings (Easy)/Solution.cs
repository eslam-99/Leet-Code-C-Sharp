public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> to = new(26);
        Dictionary<char, char> from = new(26);
        for (int i = 0; i < s.Length; i++)
        {
            if (to.ContainsKey(s[i]))
            {
                if (to[s[i]] != t[i]) return false;
            }
            else to.Add(s[i], t[i]);
            if (from.ContainsKey(t[i]))
            {
                if (from[t[i]] != s[i]) return false;
            }
            else from.Add(t[i], s[i]);
        }
        return true;
    }
}