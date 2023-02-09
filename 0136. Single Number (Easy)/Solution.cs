public class Solution
{
    public int SingleNumber(int[] nums)
    {
        return SingleNumber_V2(nums);
    }
    public int SingleNumber_V1(int[] nums)
    {
        HashSet<int> visited = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (visited.Contains(nums[i])) visited.Remove(nums[i]);
            else visited.Add(nums[i]);
        }
        return visited.First();
    }
    public int SingleNumber_V2(int[] nums)
    {
        int mask = 0;
        foreach (int num in nums) mask ^= num;
        return mask;
    }
}