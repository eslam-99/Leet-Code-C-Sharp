using static System.Net.Mime.MediaTypeNames;

internal partial class Program
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head!;
            if (head.val == head.next.val) head = DeleteDuplicates(head.next);
            else head.next = DeleteDuplicates(head.next);
            return head;
        }
        //public ListNode DeleteDuplicatesRec(ListNode head, ListNode next)
        //{
        //    if (head.val == next.val)
        //    {
        //        if (next.next == null)
        //        {
        //            head.next = null;
        //            return head;
        //        }
        //        else
        //        {
        //            next = next.next;
        //            return head;
        //        }
        //    }
        //    if (next.next == null && head.val == next.val) return head;
        //    return
        //}
    }
}