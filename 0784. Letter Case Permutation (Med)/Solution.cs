public class Solution
{
    List<string> result = new();
    public IList<string> LetterCasePermutation(string s)
    {
        result = new();
        Backtrack(s, 0);
        return result;
    }

    private void Backtrack(string s, int index)
    {
        if (index == s.Length) result.Add(s);
        else if (char.IsLetter(s[index]))
        {
            string s1 = s[..index] + char.ToLower(s[index]) + s[(index + 1)..];
            Backtrack(s1, index + 1);
            string s2 = s[..index] + char.ToUpper(s[index]) + s[(index + 1)..];
            Backtrack(s2, index + 1);
        }
        else Backtrack(s, index + 1);
    }
}