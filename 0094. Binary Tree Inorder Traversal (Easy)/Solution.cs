internal partial class Program
{
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root is null) return new List<int>();
            List<int> result = new List<int>();
            result.AddRange(InorderTraversal(root.left));
            result.Add(root.val);
            result.AddRange(InorderTraversal(root.right));
            return result;
        }
    }
}