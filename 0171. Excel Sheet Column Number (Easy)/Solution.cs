public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int result = ((int)columnTitle[0] - 64);
        for (int i = 1; i < columnTitle.Length; i++)
            result = result * 26 + ((int)columnTitle[i] - 64);
        return result;
    }
}