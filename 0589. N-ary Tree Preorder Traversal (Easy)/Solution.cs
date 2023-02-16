public class Solution
{
    public IList<int> Preorder(Node root)
    {
        return PreOrderTraversal(root).ToArray();
    }

    private IEnumerable<int> PreOrderTraversal(Node root)
    {
        if (root is null) yield break;
        yield return root.val;
        foreach (var c in root.children)
            foreach (int n in PreOrderTraversal(c))
                yield return n;

    }
}