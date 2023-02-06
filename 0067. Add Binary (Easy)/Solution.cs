using System.Text;

internal partial class Program
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int carry = 0;
            string result = "";
            if (a.Length < b.Length) a = new string('0', (b.Length - a.Length)) + a;
            else if (a.Length > b.Length) b = new string('0', (a.Length - b.Length)) + b;
            for ( int i = a.Length - 1 ; i >= 0 ; i-- )
            {
                if (carry == 1) result = (a[i] ^ b[i] ^ 1) + result;
                else result = (a[i] ^ b[i]) + result;
                if (a[i] + b[i] - '0' * 2 + carry > 1) carry = 1;
                else carry = 0;
            }
            if (carry == 1) return "1" + result;
            return result;
        }
    }
}