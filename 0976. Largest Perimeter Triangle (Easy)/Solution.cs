public class Solution
{
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        for (int i = nums.Length - 1; i > 1; i--)
        {
            if (nums[i - 2] + nums[i - 1] > nums[i]) return nums[i - 2] + nums[i - 1] + nums[i];
        }
        return 0;
    }
}