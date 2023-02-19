public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        if (root is null) return new List<IList<int>>();
        return new List<IList<int>>() { new List<int> { root.val } }.Concat(BFS(root, true)).ToList();
    }

    private List<List<int>> BFS(TreeNode root, bool reversed)
    {
        if (root == null) return null!;
        List<List<int>> result = new();
        List<List<int>> leftTree = new();
        List<List<int>> rightTree = new();
        List<int> children = new();
        if (root.left is not null)
        {
            children.Add(root.left.val);
            leftTree = BFS(root.left, !reversed);
        }
        if (root.right is not null)
        {
            children.Add(root.right.val);
            rightTree = BFS(root.right, !reversed);
        }
        if (children.Count > 0) result.Add(reversed ? Enumerable.Reverse(children).ToList() : children);
        if (leftTree.Count > 0 && rightTree.Count > 0)
        {
            for (int i = 0; i < Math.Max(leftTree.Count, rightTree.Count); i++)
            {
                if (i < leftTree.Count && i < rightTree.Count)
                {
                    if (reversed && i % 2 == 1)
                        result.Add((leftTree[i].Concat(rightTree[i]).Reverse()).ToList());
                        //result.Add(rightTree[i].Concat(leftTree[i]).ToList());
                    else
                        result.Add(leftTree[i].Concat(rightTree[i]).ToList());
                }
                else if (i < leftTree.Count) result.Add(leftTree[i]);
                else if (i < rightTree.Count) result.Add(rightTree[i]);
            }
        }
        else if (leftTree.Count > 0)
            for (int i = 0; i < leftTree.Count; i++) result.Add(leftTree[i]);
        else if (rightTree.Count > 0)
            for (int i = 0; i < rightTree.Count; i++) result.Add(rightTree[i]);

        return result;
    }
}