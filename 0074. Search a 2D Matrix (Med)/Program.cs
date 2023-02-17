internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        //Console.WriteLine(s.SearchMatrix(
        //    new int[][]
        //    {
        //        new int[] {1, 3, 5, 7 },
        //        new int[] {10, 11, 16, 20},
        //        new int[] {23, 30, 34, 60}
        //    },
        //    3
        //));
        //Console.WriteLine(s.SearchMatrix(
        //    new int[][]
        //    {
        //        new int[] {1, 3, 5, 7},
        //        new int[] {10, 11, 16, 20},
        //        new int[] { 23, 30, 34, 60 }
        //    },
        //    13
        //));
        //Console.WriteLine(s.SearchMatrix(
        //    new int[][]
        //    {
        //        new int[] {1}
        //    },
        //    1
        //));
        //Console.WriteLine(s.SearchMatrix(
        //    new int[][]
        //    {
        //        new int[] {1, 1}
        //    },
        //    0
        //));
        //Console.WriteLine(s.SearchMatrix(
        //    new int[][]
        //    {
        //        new int[] {1, 1}
        //    },
        //    2
        //));
        //Console.WriteLine(s.SearchMatrix(
        //    new int[][]
        //    {
        //        new int[] {1},
        //        new int[] {3}
        //    },
        //    3
        //));
        Console.WriteLine(s.SearchMatrix(
            new int[][]
            {
                new int[] {1, 1},
                new int[] {2, 2}
            },
            3
        ));
    }
}