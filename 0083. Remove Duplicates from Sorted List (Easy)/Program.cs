internal partial class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        ListNode head = s.DeleteDuplicates(new ListNode( val: 1, next: new ListNode(val: 1, next: new ListNode(val: 2))));
        while(head != null)
        {
            Console.WriteLine(head.val);
            head = head.next;
        }
        
        head = s.DeleteDuplicates(new ListNode( val: 1, next: new ListNode(val: 1, next: new ListNode(val: 1))));
        while(head != null)
        {
            Console.WriteLine(head.val);
            head = head.next;
        }
    }
}