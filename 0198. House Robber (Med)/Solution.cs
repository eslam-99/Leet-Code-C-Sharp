public class Solution
{
    private int[] memo;
    public int Rob(int[] nums)
    {
        return Rob_V2(nums);
    }
    public int Rob_V1(int[] nums)
    {
        memo = Enumerable.Repeat(-1, nums.Length).ToArray();
        return Backtrack(nums, 0);
    }
    public int Rob_V2(int[] nums)
    {
        int[] memo = new int[nums.Length + 1];
        memo[1] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            memo[i + 1] = Math.Max(memo[i], memo[i - 1] + nums[i]);

        return memo[^1];
    }

    private int Backtrack(int[] nums, int index)
    {
        if (index >= nums.Length) return 0;
        if (memo[index] >= 0) return memo[index];
        int result = Math.Max(nums[index] + Backtrack(nums, index + 2), Backtrack(nums, index + 1));
        memo[index] = result;
        return result;
    }
}