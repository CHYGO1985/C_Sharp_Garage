using System;

/*
 * 
 * @jingjiejiang May 1, 2019
 */ 
public class Class1
{
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null) return true;

        // find the mid node
        ListNode slow = head;
        ListNode fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        // reverse the second half list (due to even/odd position difference, need to use the second half)
        ListNode secHead = slow.next;
        
        while (secHead.next != null)
        {
            ListNode tmpNext = secHead.next;
            secHead.next = secHead.next.next;
            tmpNext.next = slow.next;
            slow.next = tmpNext;
        }

        secHead = slow.next;
        while (secHead != null)
        {
            if (head.val != secHead.val) return false;
            head = head.next;
            secHead = secHead.next;
        }

        return true;
    }
}
