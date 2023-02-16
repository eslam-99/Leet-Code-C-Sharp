public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> nums2Mapping = new();
        int[] result = Enumerable.Repeat<int>(-1, nums1.Length).ToArray();

        for (int i = 0; i < nums2.Length; i++) nums2Mapping[nums2[i]] = i;

        for (int i = 0; i < nums1.Length; i++)
        {
            int index = -1;
            if (nums2Mapping.TryGetValue(nums1[i], out index))
            {
                for (int j = index + 1; j < nums2.Length; j++)
                {
                    if (nums1[i] < nums2[j])
                    {
                        result[i] = nums2[j];
                        break;
                    }
                }
            }
        }
        return result;
    }
}