public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new List<string>();
        int p = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (Math.Abs(nums[i] - nums[i - 1]) > 1)
            {
                if (i - 1 == p) result.Add($"{nums[p]}");
                else result.Add($"{nums[p]}->{nums[i - 1]}");
                p = i;
            }
        }
        if (p == nums.Length - 1) result.Add($"{nums[p]}");
        else if (p < nums.Length - 1) result.Add($"{nums[p]}->{nums[nums.Length - 1]}");
        return result;
    }
}