internal partial class Program
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Merge_V2(nums1, m, nums2, n);
        }
        public void Merge_V1(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;
            //int nextIndex = 0;

            int nextIndex = 0;
            int[] nums = new int[m + n];
            for (int i = 0, j = 0; nextIndex < m + n ; )
            {
                if (j == n || (nums1[i] <= nums2[j] && i != m))
                {
                    nums[nextIndex++] = nums1[i++];
                }
                else
                {
                    nums[nextIndex++] = nums2[j++];
                }
            }

            nums.CopyTo(nums1, 0);
        }
        public void Merge_V2(int[] nums1, int m, int[] nums2, int n)
        {
            int nextIndex = nums1.Length - 1;
            m--;
            n--;
            while (nextIndex >= 0)
            {
                if (n < 0 || (m >= 0 && nums1[m] > nums2[n]))
                    nums1[nextIndex--] = nums1[m--];
                else
                    nums1[nextIndex--] = nums2[n--];
            }
        }
    }
}