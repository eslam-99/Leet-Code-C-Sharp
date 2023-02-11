public class Solution
{
    public int HammingWeight(uint n)
    {
        int c = 0;
        for (int i = 0; i < 32; i++)
        {
            c += (n & 1) == 1 ? 1 : 0;
            n >>= 1;
        }
        return c;
    }
}