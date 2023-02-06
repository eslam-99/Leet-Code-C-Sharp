internal partial class Program
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int nextInsertIndex = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[nextInsertIndex] = nums[i];
                    nextInsertIndex++;
                }
            }
            return nextInsertIndex;
        }
    }
}