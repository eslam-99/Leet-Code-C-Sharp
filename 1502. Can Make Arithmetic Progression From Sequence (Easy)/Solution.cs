public class Solution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);
        int diff = Math.Abs(arr[0] - arr[1]);
        for (int i = 2; i < arr.Length; i++)
            if (diff != Math.Abs(arr[i - 1] - arr[i])) return false;
        return true;
    }
}