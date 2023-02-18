public class Solution
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);
        //   lower                    upper
        //     *                        *
        // ******************************....
        // MINUS
        // ****..............................
        return GetRange(nums, upper) - GetRange(nums, lower - 1);
    }

    private long GetRange(int[] nums, int upper)
    {
        long res = 0;
        for (int i = 0, j = nums.Length - 1; i < j; ++i)
        {
            while (i < j && nums[i] + nums[j] > upper) --j;
            res += j - i;
        }
        return res;
    }
}