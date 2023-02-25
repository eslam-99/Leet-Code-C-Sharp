public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (k > nums.Length) k %= nums.Length;
        if (k == 0 || k == nums.Length) return;
        int swaps = 0;
        for (int i = 0; swaps < nums.Length - 1; i++)
        {
            int pos = i;
            int n = nums[^(k - i)];
            do
            {
                (n, nums[pos]) = (nums[pos], n);
                pos = (pos + k) % nums.Length;
                swaps++;
            } while (pos != i);
        }
    }
}