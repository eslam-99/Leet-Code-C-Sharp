internal partial class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        ListNode res = s.MergeTwoLists
            (
                new ListNode( val: 1, next: new ListNode( val: 2, next: new ListNode( val: 4 ) ) ),
                new ListNode( val: 1, next: new ListNode( val: 3, next: new ListNode( val: 4 ) ) )
            );
        while ( res != null )
        {
            Console.Write($"{res.val} ");
            res = res.next;
        }
        Console.WriteLine();

        res = s.MergeTwoLists(null, null);
        while ( res != null )
        {
            Console.Write($"{res.val} ");
            res = res.next;
        }
        Console.WriteLine();

        res = s.MergeTwoLists
            (
                null,
                new ListNode( val: 0 )
            );
        while ( res != null )
        {
            Console.Write($"{res.val} ");
            res = res.next;
        }
        Console.WriteLine();
    }
}