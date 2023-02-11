internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        ListNode h = new ListNode(1, new(2, new(3, new(4, new(5)))));
        h = s.ReverseList(h);
        while (h is not null)
        {
            Console.Write($"{h.val} -> ");
            h = h.next;
        }
        Console.WriteLine("NULL");
    }
}
