public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root is null) return null!;
        if (root.val < p.val && root.val < q.val)
            return LowestCommonAncestor(root.right, p, q);
        else if (root.val > p.val && root.val > q.val)
            return LowestCommonAncestor(root.left, p, q);
        return root;
    }
}