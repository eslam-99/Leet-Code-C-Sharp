public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] == target - numbers[right]) break;
            else if (numbers[left] < target - numbers[right]) left++;
            else right--;
        }
        return new int[] { left, right };
    }
}