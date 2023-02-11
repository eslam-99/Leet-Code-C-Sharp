public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root is null) return null!;
        (root.left, root.right) = (InvertTree(root.right), InvertTree(root.left));
        return root;
    }
}