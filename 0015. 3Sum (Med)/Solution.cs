public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        HashSet<(int, int, int)> result = new();
        Array.Sort(nums);
        for (int lower = 0; lower < nums.Length - 2; lower++)
        {
            int middle = lower + 1, upper = nums.Length - 1;
            while (upper > middle)
            {
                int sum = nums[lower] + nums[middle] + nums[upper];
                if (sum == 0)
                {
                    result.Add((nums[lower], nums[middle], nums[upper]));
                    middle++;
                    upper--;
                }
                else if (sum < 0) middle++;
                else upper--;
            }
        }
        return result.Select(x => new[] { x.Item1, x.Item2, x.Item3 }).ToArray();
    }
}