internal partial class Program
{
    public class Solution
    {
        public int RomanToInt_v1(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("I", 1);
            dict.Add("V", 5);
            dict.Add("X", 10);
            dict.Add("L", 50);
            dict.Add("C", 100);
            dict.Add("D", 500);
            dict.Add("M", 1000);

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && dict[s[i].ToString()] < dict[s[i+1].ToString()])
                {
                    result -= dict[s[i].ToString()];
                }
                else
                {
                    result += dict[s[i].ToString()];
                }
            }

            return result;
        }
        public int RomanToInt_v2(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        switch (s[i+1])
                        {
                            case 'V': result -= 1; break;
                            case 'X': result -= 1; break;
                            default: result += 1; break;
                        }
                        break;
                    case 'V': result += 5; break;
                    case 'X':
                        switch (s[i + 1])
                        {
                            case 'L': result -= 10; break;
                            case 'C': result -= 10; break;
                            default: result += 10; break;
                        }
                        break;
                    case 'L': result += 50; break;
                    case 'C':
                        switch (s[i + 1])
                        {
                            case 'D': result -= 100; break;
                            case 'M': result -= 100; break;
                            default: result += 100; break;
                        }
                        break;
                    case 'D': result += 500; break;
                    case 'M': result += 1000; break;
                    default: result += 0; break;
                }
            }

            switch (s[s.Length - 1])
            {
                case 'I': result += 1; break;
                case 'V': result += 5; break;
                case 'X': result += 10; break;
                case 'L': result += 50; break;
                case 'C': result += 100; break;
                case 'D': result += 500; break;
                case 'M': result += 1000; break;
                default: result += 0; break;
            }

            return result;
        }
    }
}