public class Solution
{
    public int Compress(char[] chars)
    {
        int startIndex = 0;
        int nextIndex = 0;
        for (int i = 0; i < chars.Length; i++)
            if (chars[i] != chars[startIndex])
                WriteChars(chars, ref startIndex, ref nextIndex, i);
        if (startIndex < chars.Length - 1)
            WriteChars(chars, ref startIndex, ref nextIndex, chars.Length);
        if (startIndex == chars.Length - 1)
            WriteChars(chars, ref startIndex, ref nextIndex, chars.Length);
        return nextIndex;
    }

    private void WriteChars(char[] chars, ref int startIndex, ref int nextIndex, int i)
    {
        int count = i - startIndex;
        if (count > 1)
        {
            string s = NumToChars(count);
            chars[nextIndex++] = chars[startIndex];
            foreach (char c in s) chars[nextIndex++] = c;
            startIndex = i;
        }
        else chars[nextIndex++] = chars[startIndex++];
    }

    private string NumToChars(int n)
    {
        string s = "";
        while(n > 0)
        {
            s = n % 10 + s;
            n /= 10;
        }
        return s;
    }
}