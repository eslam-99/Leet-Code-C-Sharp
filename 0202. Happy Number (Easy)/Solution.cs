public class Solution
{
    public bool IsHappy(int n)
    {
        while (n != 1 && n != 4) n = GetNext(n);
        return n == 1;
    }
    private int GetNext(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int d = n % 10;
            n /= 10;
            sum += d * d;
        }
        return sum;
    }
}