public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode oneStep = head, twoSteps = head;
        while (twoSteps is not null && twoSteps.next is not null)
        {
            oneStep= oneStep.next;
            twoSteps = twoSteps.next.next;
            if (oneStep == twoSteps) return true;
        }
        return false;
    }
}