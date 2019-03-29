using System;

/**
 * 
 * @jingjiejiang Mar 29, 2019
 */
namespace Leetcode.List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode headNext = head.next;
            ListNode newHead = ReverseList(head.next);
            headNext.next = head;
            head.next = null;
            return newHead;
        }
    }
}
