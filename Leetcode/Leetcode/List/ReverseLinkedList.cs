using System;

/**
 * 
 * @jingjiejiang Mar 29, 2019
 */
namespace Leetcode.List
{
    public class ReverseList
    {
        public ListNode ReverseList1(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode headNext = head.next;
            ListNode newHead = ReverseList1(head.next);
            headNext.next = head;
            head.next = null;
            return newHead;
        }
    }
}
