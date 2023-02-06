internal partial class Program
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetric(root.left, root.right);
        }
        public bool IsSymmetric(TreeNode l, TreeNode r)
        {
            if (l is null && r is null) return true;
            if (l is null || r is null) return false;
            if (l.val != r.val) return false;
            return IsSymmetric(l.left, r.right) && IsSymmetric(l.right, r.left);
        }
    }
}