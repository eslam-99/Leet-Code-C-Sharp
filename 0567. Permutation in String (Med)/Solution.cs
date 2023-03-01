public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        s1 = SortString(s1);
        for (int i = 0; i < s2.Length - s1.Length + 1; i++)
            if (s1 == SortString(s2.Substring(i, s1.Length))) return true;
        return false;
    }

    private string SortString(string s)
    {
        var chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}