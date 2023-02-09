public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        if (root is null) return new List<int>();
        List<int> result = new List<int>();
        result.AddRange(PostorderTraversal(root.left));
        result.AddRange(PostorderTraversal(root.right));
        result.Add(root.val);
        return result;
    }
}