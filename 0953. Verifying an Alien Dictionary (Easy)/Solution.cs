public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {
        int[] chars = new int[26];
        for (int i = 0; i < 26; i++) chars[order[i] - 'a'] = i;
        for (int i = 0; i < words.Length - 1; i++)
        {
            int len = Math.Min(words[i].Length, words[i + 1].Length);
            for (int j = 0; j < len; j++)
            {
                if (chars[words[i][j] - 'a'] > chars[words[i + 1][j] - 'a']) return false;
                else if (chars[words[i][j] - 'a'] < chars[words[i + 1][j] - 'a']) break;
                if (j == len - 1 && words[i].Length > words[i + 1].Length) return false;
            }
        }
        return true;
    }
}