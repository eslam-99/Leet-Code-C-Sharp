﻿public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            int j = 0;
            while (j < needle.Length && haystack[i + j] == needle[j]) j++;
            if (j == needle.Length - 1) return i;
        }
        return -1;
    }
}