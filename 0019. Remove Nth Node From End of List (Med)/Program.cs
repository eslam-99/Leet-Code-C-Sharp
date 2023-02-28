internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        ListNode head = new(1, new(2, new(3, new(4, new(5)))));
        head = s.RemoveNthFromEnd(head, 1);
        while (head is not null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
        
        head = new(1, new(2, new(3, new(4, new(5)))));
        head = s.RemoveNthFromEnd(head, 3);
        while (head is not null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();

        head = new(1, new(2, new(3, new(4, new(5)))));
        head = s.RemoveNthFromEnd(head, 5);
        while (head is not null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();

        head = new(1);
        head = s.RemoveNthFromEnd(head, 1);
        while (head is not null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
        
        head = new(1, new(2));
        head = s.RemoveNthFromEnd(head, 1);
        while (head is not null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();


    }
}