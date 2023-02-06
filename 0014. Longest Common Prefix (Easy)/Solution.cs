internal partial class Program
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            return LongestCommonPrefix_v2(strs);
        }
        public string LongestCommonPrefix_v1(string[] strs)
        {
            Dictionary<string, int> prefixes = new();

            for (int n = 0; n < strs.Length; n++)
            {
                if (strs[n].Length == 0) return "";
            }

            for (int i = 0; i < strs.Length; i++)
            {
                for (int j = 0; j < strs[i].Length; j++)
                {
                    string subStr = strs[i][0..(j + 1)];
                    bool found = true;
                    for (int k = 0; k < strs.Length; k++)
                    {
                        if (k != i)
                        {
                            if (!strs[k].Contains(subStr))
                            {
                                found = false;
                                break;
                            }
                        }
                    }
                    if (found)
                    {
                        if (prefixes.ContainsKey(subStr))
                        {
                            prefixes[subStr] = prefixes[subStr] + 1;
                        }
                        else
                        {
                            prefixes.Add(subStr, 1);
                        }
                    }
                }
            }

            if (prefixes.Keys.Count == 0)
                return "";

            string longestCommonPrefix = prefixes.Keys.First();
            foreach (string key in prefixes.Keys)
            {
                if (prefixes[key] > prefixes[longestCommonPrefix])
                {
                    longestCommonPrefix = key;
                }
                else if (prefixes[key] == prefixes[longestCommonPrefix] && key.Length > longestCommonPrefix.Length)
                {
                    longestCommonPrefix = key;
                }
            }

            if (prefixes[longestCommonPrefix] >= strs.Length)
                return longestCommonPrefix;
            return "";
        }

        public string LongestCommonPrefix_v2(string[] strs)
        {
            Dictionary<string, int> prefixes = new();

            if (strs[0].Length == 0) return "";
            for (int j = 0 ; j < strs[0].Length; j++)
            {
                string subStr = strs[0][0..(j + 1)];
                bool found = true;
                for (int k = 1; k < strs.Length; k++)
                {
                    if (strs[k].Length == 0) return "";
                    if (!strs[k].StartsWith(subStr))
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    if (prefixes.ContainsKey(subStr))
                    {
                        prefixes[subStr] = prefixes[subStr] + 1;
                    }
                    else
                    {
                        prefixes.Add(subStr, 1);
                    }
                }
            }

            if (prefixes.Keys.Count == 0)
                return "";

            string longestCommonPrefix = prefixes.Keys.First();
            foreach (string key in prefixes.Keys)
            {
                if (prefixes[key] > prefixes[longestCommonPrefix])
                {
                    longestCommonPrefix = key;
                }
                else if (prefixes[key] == prefixes[longestCommonPrefix] && key.Length > longestCommonPrefix.Length)
                {
                    longestCommonPrefix = key;
                }
            }

            return longestCommonPrefix;
        }
    }
}