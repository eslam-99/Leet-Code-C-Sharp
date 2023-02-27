using System.Text;

public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder result = new();
        int wordStartIndex = 0, wordLength = 0;
        foreach (char c in s)
        {
            if (c == ' ')
            {
                int i = wordStartIndex + wordLength - 1;
                while (i >= wordStartIndex) result.Append(s[i--]);
                result.Append(' ');
                wordStartIndex += wordLength + 1;
                wordLength = 0;
            }
            else wordLength++;
        }

        int j = wordStartIndex + wordLength - 1;
        while (j >= wordStartIndex) result.Append(s[j--]);

        return result.ToString();
    }
}