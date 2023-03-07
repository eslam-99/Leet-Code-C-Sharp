public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        int a = 1, b = 1;
        for (int i = 1; i < n; i++) (a, b) = (b, a + b);
        return b;
    }
}