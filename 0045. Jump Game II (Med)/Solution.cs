public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length == 1) return 0;
        int end = nums[0], far = nums[0], answer = 1;
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (far >= nums.Length - 1) return answer;
            if (i + nums[i] > far)
            {
                far = i + nums[i];
                if (far >= nums.Length - 1) return ++answer;
            }
            if (i == end)
            {
                if (i + nums[i] > far) far = i + nums[i];
                end = far;
                answer++;
            }
        }
        return answer;
    }
}