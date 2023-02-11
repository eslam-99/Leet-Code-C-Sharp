public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (k == 0) return false;
        Dictionary<int, int> d = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (d.ContainsKey(nums[i]))
            {
                if (i - d[nums[i]] <= k) return true;
                d[nums[i]] = i;
            }
            else d.Add(nums[i], i); 
        }
        return false;
    }
}