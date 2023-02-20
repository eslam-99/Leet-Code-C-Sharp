public class Solution
{
    public string FreqAlphabets(string s)
    {
        string result = "", temp = "";
        foreach (char c in s)
        {
            if (temp.Length == 3)
            {
                result += MapChar(temp[0]);
                temp = temp[1..];
            }
            switch (c)
            {
                case '#':
                    result += MapChar(temp);
                    temp = "";
                    break;
                default: temp += c; break;
            }
        }
        foreach (char c in temp) result += MapChar(c);
        return result;
    }

    private char MapChar(char c) => (char)(c - '1' + 'a');
    private char MapChar(string s) => (char)(int.Parse(s) + 'a' - 1);
}