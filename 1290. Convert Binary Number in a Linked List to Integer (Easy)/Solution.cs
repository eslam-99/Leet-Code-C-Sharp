public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        int result = 0, level = 0;
        ListNode temp = head;
        while (temp is not null)
        {
            temp = temp.next;
            level++;
        }
        while (head is not null)
        {
            result += (int)Math.Pow(2, --level) * head.val;
            head = head.next;
        }
        return result;
    }
}