public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0, counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (counter == 0) candidate = nums[i];
            if (nums[i] == candidate) counter++;
            else counter--;
        }
        return candidate;
    }
}