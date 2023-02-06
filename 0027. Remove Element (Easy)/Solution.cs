internal partial class Program
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int nextInsertIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[nextInsertIndex] = nums[i];
                    nextInsertIndex++;
                }
            }
            return nextInsertIndex;
        }
    }
}