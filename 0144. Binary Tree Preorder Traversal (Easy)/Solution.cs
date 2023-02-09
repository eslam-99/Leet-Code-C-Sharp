public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root is null) return new List<int>();
        List<int> result = new List<int>();
        result.Add(root.val);
        result.AddRange(PreorderTraversal(root.left));
        result.AddRange(PreorderTraversal(root.right));
        return result;
    }
}