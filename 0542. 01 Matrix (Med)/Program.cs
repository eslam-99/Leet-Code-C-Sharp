internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        int[][] result;

        //result = s.UpdateMatrix(
        //    new int[][]
        //    {
        //        new int[] { 0, 0, 0 },
        //        new int[] { 0, 1, 0 },
        //        new int[] { 0, 0, 0 },
        //    }
        //);
        //Console.WriteLine(string.Join('\n', result.Select(c => string.Join(',', c))));

        result = s.UpdateMatrix(
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 },
            }
        );
        Console.WriteLine(string.Join('\n', result.Select(c => string.Join(',', c))));
    }
}