public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int sum = 0, max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            max = Math.Max(max, sum);
            sum = Math.Max(0, sum);
        }
        return max;
    }
}