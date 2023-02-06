internal partial class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(string.Join(", ", s.InorderTraversal(new TreeNode(val: 1, right: new TreeNode(val: 2, left: new TreeNode(val: 3)))).Select(x => x.ToString()))); ;
    }
}