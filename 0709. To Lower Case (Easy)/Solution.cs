public class Solution
{
    public string ToLowerCase(string s)
    {
        string result = "";
        for (int i = 0; i < s.Length; i++)
            if (s[i] >= 65 && s[i] <= 90) result += (char)(s[i] + 32);
            else result += s[i];
        return result;
    }
}