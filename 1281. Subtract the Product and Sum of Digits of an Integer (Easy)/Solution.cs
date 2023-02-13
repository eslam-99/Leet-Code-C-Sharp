public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int sum = 0, prod = 1;
        while (n > 0)
        {
            int x = n % 10;
            sum += x;
            prod *= x;
            n /= 10;
        }
        return prod - sum;
    }
}