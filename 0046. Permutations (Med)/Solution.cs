public class Solution
{
    private List<IList<int>> result = new();
    public IList<IList<int>> Permute(int[] nums)
    {
        Backtrack(nums, 0);
        return result;
    }

    private void Backtrack(int[] nums, int start)
    {
        if (start == nums.Length)
        {
            result.Add(nums.ToList());
            return;
        }
        for (int i = start; i < nums.Length; i++)
        {
            (nums[start], nums[i]) = (nums[i], nums[start]);
            Backtrack(nums, start + 1);
            (nums[start], nums[i]) = (nums[i], nums[start]);
        }
    }
}