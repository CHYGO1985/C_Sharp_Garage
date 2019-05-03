using System;

/*
 * 
 * @jingjiejiang Mar 3, 2019
 */ 
public class Class1
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        // reverse A and B, then get the first node that is different
        if (headA == null || headB == null) return null;

        int lenA = 0, lenB = 0;

        lenA = GetLength(headA);
        lenB = GetLength(headB);

        ListNode headLong = lenA >= lenB ? headA : headB;
        ListNode headShort = lenA >= lenB ? headB : headA;
        int longLen = lenA >= lenB ? lenA : lenB;
        int shortLen = lenA >= lenB ? lenB : lenA;

        while (longLen > shortLen)
        {
            if (headLong == headShort) return headShort;
            headLong = headLong.next;
            longLen--;
        }

        while (shortLen != null && headLong != null)
        {
            if (headLong == headShort) return headShort;
            headLong = headLong.next;
            headShort = headShort.next;
        }

        return null;
    }

    private int GetLength(ListNode head)
    {
        int len = 0;

        while (head != null)
        {
            len++;
            head = head.next;
        }

        return len;
    }
}
