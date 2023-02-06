using System.Linq;

internal partial class Program
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1 ; i >= 0 ; i--)
            {
                digits[i]++;
                if (digits[i] < 10) break;
                digits[i] = 0;
                if (i == 0 && digits[i] == 10)
                {
                    int[] newDigits = new int[digits.Length + 1];
                    newDigits[0] = 1;
                    digits.CopyTo(newDigits, 1);
                    return newDigits;
                }
            }
            return digits;
        }
    }
}