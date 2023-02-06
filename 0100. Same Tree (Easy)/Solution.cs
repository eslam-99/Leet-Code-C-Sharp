internal partial class Program
{
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p is null && q is null) return true;
            if (p is null || q is null) return false;
            if (p.val != q.val) return false;
            return IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
        }
    }
}