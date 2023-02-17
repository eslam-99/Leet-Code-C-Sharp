public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int nextZeroIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[nextZeroIndex]) = (nums[nextZeroIndex++], nums[i]);
            }
        }
    }
}