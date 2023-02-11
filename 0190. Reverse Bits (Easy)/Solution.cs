using System.Text;

public class Solution
{
    public uint reverseBits(uint n)
    {
        return reverseBits_V2(n);
    }
    private uint reverseBits_V1(uint n)
    {
        StringBuilder s = new(Convert.ToString(n, 2), 32);
        s.Insert(0, new string('0', 32 - s.Length));
        int start = 0, end = s.Length - 1;
        while (start < end) (s[start], s[end]) = (s[end--], s[start++]);
        return Convert.ToUInt32(s.ToString(), 2);
    }
    private uint reverseBits_V2(uint n)
    {
        uint m = 0;
        for (int i = 0; i < 32; i++)
        {
            m <<= 1;
            m |= n & 1;
            n >>= 1;
        }
        return m;
    }
}
