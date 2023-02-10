public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        string result = "";
        while (columnNumber > 0)
        {
            int mod = (columnNumber - 1) % 26;
            result = (char)(mod + 65) + result;
            columnNumber = (columnNumber - mod) / 26;
        }
        return result;
    }
}