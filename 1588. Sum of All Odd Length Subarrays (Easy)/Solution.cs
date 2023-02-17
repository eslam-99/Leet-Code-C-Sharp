public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        int n = (arr.Length + 1) / 2, sum = 0;
        for (int i = 0 ; i < n ; i++)
        {
            int c = 1, left = 0, right = arr.Length - 1;
            int windowSize = i * 2 + 1;
            while (left < right)
            {
                int repeatition = Math.Min(c, Math.Min(arr.Length + 1 - windowSize, windowSize));
                sum += arr[left++] * repeatition + arr[right--] * repeatition;
                c++;
            }
            if (left == right)
            {
                int repeatition = Math.Min(c, Math.Min(arr.Length + 1 - windowSize, windowSize));
                sum += arr[left] * repeatition;
            }
        }
        return sum;
    }
}

// 
// A B C D E F G F E D C B A
// 1 1 1 1 1 1 1 1 1 1 1 1 1 : 1
// 1 2 3 3 3 3 3 3 3 3 3 2 1 : 3
// 1 2 3 4 5 5 5 5 5 4 3 2 1 : 5
// 1 2 3 4 5 6 7 6 5 4 3 2 1 : 7
// 1 2 3 4 5 5 5 5 5 4 3 2 1 : 9
// 1 2 3 3 3 3 3 3 3 3 3 2 1 : 11
// 1 1 1 1 1 1 1 1 1 1 1 1 1 : 13
// 
// A B C D E F F E D C B A
// 1 1 1 1 1 1 1 1 1 1 1 1 : 1
// 1 2 3 3 3 3 3 3 3 3 2 1 : 3
// 1 2 3 4 5 5 5 5 4 3 2 1 : 5
// 1 2 3 4 5 6 6 5 4 3 2 1 : 7
// 1 2 3 4 4 4 4 4 4 4 2 1 : 9
// 1 1 1 1 1 1 1 1 1 1 1 1 : 11
// 
// A B C D E F E D C B A
// 1 1 1 1 1 1 1 1 1 1 1 : 1
// 1 2 3 3 3 3 3 3 3 2 1 : 3
// 1 2 3 4 5 5 5 4 3 2 1 : 5
// 1 2 3 4 5 5 5 4 3 2 1 : 7
// 1 2 3 3 3 3 3 3 3 2 1 : 9
// 1 1 1 1 1 1 1 1 1 1 1 : 11
// 
// A B C D E D C B A
// 1 1 1 1 1 1 1 1 1 : 1
// 1 2 3 3 3 3 3 2 1 : 3
// 1 2 3 4 5 4 3 2 1 : 5
// 1 2 3 3 3 3 3 2 1 : 7
// 1 1 1 1 1 1 1 1 1 : 9
// 
// A B C D C B A
// 1 1 1 1 1 1 1 : 1
// 1 2 3 3 3 2 1 : 3
// 1 2 3 3 3 2 1 : 5
// 1 1 1 1 1 1 1 : 7
// 
// A B C B A
// 1 1 1 1 1 : 1
// 1 2 3 2 1 : 3
// 1 1 1 1 1 : 5
// 
// 
// 
// 
// 
// 
// 