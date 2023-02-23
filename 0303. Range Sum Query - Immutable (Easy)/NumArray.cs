public class NumArray
{
    private int[] Nums { get; set; }
    public NumArray(int[] nums)
    {
        Nums = nums;
    }

    public int SumRange(int left, int right)
    {
        return Nums[left..(right + 1)].Sum();
    }
}