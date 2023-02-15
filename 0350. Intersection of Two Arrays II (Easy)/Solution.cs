public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> values = new();
        List<int> result = new(Math.Min(nums1.Length, nums2.Length));

        foreach (int n in nums1)
            if (values.ContainsKey(n)) values[n]++;
            else values.Add(n, 1);

        foreach (int n in nums2)
        {
            if (values.ContainsKey(n) && values[n] > 0)
            {
                values[n]--;
                result.Add(n);
            }
        }

        return result.ToArray();
    }
}