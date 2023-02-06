public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] result = new int[n*2];
        for (int i = 0; i < nums.Length; i+=2)
        {
            result[i] = nums[i/2];
            result[i+1] = nums[n++];
        }
        return result;
    }
}