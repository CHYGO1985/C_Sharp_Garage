using System;

/*
 * 
 * @jingjiejiang Mar 2, 2019
 */ 
public class Class1
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        // reverse A and B, then get the first node that is different

        if (headA == null || headB == null) return null;
       
        ListNode newHeadA = reverse(headA);
        ListNode newHeadB = reverse(headB);

        if (newHeadA != newHeadB) return null;

        while (newHeadA != null && newHeadB != null)
        {
        }
    }

    private ListNode reverse(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode newHead = reverse(head.next);
        head.next.next = head;
        head.next = null;

        return newHead;
    }
}
