public class Solution
{
    public long FindTheArrayConcVal(int[] nums)
    {
        long sum = 0;
        int start = 0, end = nums.Length - 1;
        while (start < end)
            sum += int.Parse(nums[start++].ToString() + nums[end--].ToString());
        if (start == end) sum += nums[start];
        return sum;
    }
}