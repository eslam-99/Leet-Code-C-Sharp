using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        IList<IList<int>> result = new List<IList<int>>();

        result = s.ZigzagLevelOrder(
            new TreeNode(
                3,
                new TreeNode(9),
                new TreeNode(20,
                    new TreeNode(15),
                    new TreeNode(7)
                )
            )
        );
        Console.WriteLine("[" + string.Join(',', result.Select(i => " [ " + string.Join(',', i) + " ] ")) + "]");

        result = s.ZigzagLevelOrder(
            new TreeNode( 1 )
        );
        Console.WriteLine("[" + string.Join(',', result.Select(i => " [ " + string.Join(',', i) + " ] ")) + "]");

        result = s.ZigzagLevelOrder( null!);
        Console.WriteLine("[" + string.Join(',', result.Select(i => " [ " + string.Join(',', i) + " ] ")) + "]");

        result = s.ZigzagLevelOrder(
            new TreeNode(
                1,
                new TreeNode(2,
                    new TreeNode(4)
                ),
                new TreeNode(3,
                    null!,
                    new TreeNode(5)
                )
            )
        );
        Console.WriteLine("[" + string.Join(',', result.Select(i => " [ " + string.Join(',', i) + " ] ")) + "]");
        
        result = s.ZigzagLevelOrder(
            new TreeNode(
                0,
                new TreeNode(2,
                    new TreeNode(1,
                        new TreeNode(5),
                        new TreeNode(1)
                    )
                ),
                new TreeNode(4,
                    new TreeNode(3,
                        null!,
                        new TreeNode(6)
                    ),
                    new TreeNode(-1,
                        null!,
                        new TreeNode(8)
                    )
                )
            )
        );
        Console.WriteLine("My Answer    : [" + string.Join(',', result.Select(i => "[" + string.Join(',', i) + "]")) + "]");
        Console.WriteLine("Right Answer : [[0],[4,2],[1,3,-1],[8,6,1,5]]");
    }
}