internal partial class Program
{
    public class Solution
    {

        public bool IsValid(string s)
        {
            return IsValid_v2(s);
        }
        public bool IsValid_v1(string s)
        {
            if (s == null || s.Length % 2 != 0) return false;
            Stack<char> order = new();

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                    case '{':
                    case '[': order.Push(s[i]); break;
                    default:
                        if (order.Count == 0) return false;
                        switch (s[i])
                        {
                            case ')':
                                if (order.Peek() == '(') order.Pop();
                                else return false;
                                break;
                            case '}':
                                if (order.Peek() == '{') order.Pop();
                                else return false;
                                break;
                            case ']':
                                if (order.Peek() == '[') order.Pop();
                                else return false;
                                break;
                            default: return false;
                        }
                        break;
                }
            }
            if (order.Count > 0) return false;
            return true;
        }
        public bool IsValid_v2(string s)
        {
            if (s == null || s.Length % 2 != 0) return false;
            Stack<char> order = new();

            foreach (char c in s)
            {
                if (c is '(' or '[' or '{') order.Push(c);
                else
                {
                    if (order.Count == 0) return false;
                    char p = order.Pop();
                    switch (c)
                    {
                        case ')' when p is '(':
                        case '}' when p is '{':
                        case ']' when p is '[':
                            continue;
                        default: return false;
                    }
                }
            }
            if (order.Count > 0) return false;
            return true;
        }
    }
}